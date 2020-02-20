using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Models;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;
using Helpers;
using DataClasses;
using YoutubeExplode.Models.MediaStreams;
using YT_Downloader;
using DataRepository;
using YT_Downloader.Properties;

namespace UserInterface
{
    static class DataService
    {  
        private static readonly YoutubeClient _client = new YoutubeClient();
        private static readonly YoutubeConverter _converter = new YoutubeConverter();
        private static string _id;

        public static string FullTitle;

        static void TitleTooLong(Video metaData, Label titleLabel)
        {
            string subStringTitle = metaData.Title.Substring(0, 79);
            subStringTitle += "...";
            ExtensionMethods.SynchronizedInvoke(titleLabel, () => titleLabel.Text = subStringTitle);
            FullTitle = metaData.Title;
        }

        public static async Task<Video> GetMetaData(YoutubeClient client, string id)
        {
            var _metaData = await client.GetVideoAsync(id);
            return _metaData;
        }

        public static async Task LoadMetaData(IProgress<int> progress, MaterialProgressBar dataLoadProgressBar, ComboBox qualityFormatComboBox, MaterialSingleLineTextField videoUrlTxtBox
            , Label titleLabel, MaterialLabel durationLabel, PictureBox thumbNailPictureBox)
        {

            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
                if (dataLoadProgressBar.Value == 25)
                {
                    ExtensionMethods.SynchronizedInvoke(qualityFormatComboBox, () => qualityFormatComboBox.Items.Clear());
                    progress.Report(i);
                }
                else if (dataLoadProgressBar.Value == 50)
                {
                    _id = YoutubeClient.ParseVideoId(videoUrlTxtBox.Text);
                    GetDownloadOptions(qualityFormatComboBox);                    
                    progress.Report(i);
                }
                else if (dataLoadProgressBar.Value == 75)
                {
                    var _metaData = await GetMetaData(_client, _id);
                    UpdateVideoInfoControls(_metaData, _id, titleLabel, durationLabel, thumbNailPictureBox);
                    progress.Report(i);
                }
                else if (dataLoadProgressBar.Value == 0 || dataLoadProgressBar.Value > 0)
                    progress.Report(i);
            }

        }

        static void UpdateVideoInfoControls(Video metaData, string id, Label titleLabel, MaterialLabel durationLabel, PictureBox thumbNailPictureBox)
        {  
           
            ExtensionMethods.SynchronizedInvoke(thumbNailPictureBox, () => thumbNailPictureBox.ImageLocation = String.Format("https://i.ytimg.com/vi/{0}/hqdefault.jpg", id));
            Thread.Sleep(200);            
            titleLabel.Text = "";
            if (metaData.Title.Length > 82)
            {
                TitleTooLong(metaData, titleLabel);
            }
            else
                ExtensionMethods.SynchronizedInvoke(titleLabel, () => titleLabel.Text = metaData.Title);

            ExtensionMethods.SynchronizedInvoke(durationLabel, () => durationLabel.Text = metaData.Duration.ToString());

            FullTitle = metaData.Title;

        }

        static async void GetDownloadOptions(ComboBox qualityFormatComboBox)
        {

            var _streamInfoSet = await _client.GetVideoMediaStreamInfosAsync(_id);
            var _videoInfo = _streamInfoSet.Video;
            var _audioInfo = _streamInfoSet.Audio;

            foreach (var video in _videoInfo)
            {              
                ExtensionMethods.SynchronizedInvoke(qualityFormatComboBox, () => qualityFormatComboBox.Items.Add(new DownloadOption(video.Container.ToString(), video.VideoQualityLabel)));
            }
            foreach (var audio in _audioInfo)
            {
                ExtensionMethods.SynchronizedInvoke(qualityFormatComboBox, () => qualityFormatComboBox.Items.Add(new DownloadOption(audio.Container.ToString(), audio.Bitrate)));
            }
        }

        public static async Task DownloadItem(string fileTitle, string format, string quality, long bitrate, string savePath, MaterialListView downloadQueueMaterialListView, bool isAudio, MaterialCheckBox deleteDoneCheckBox)
        {

            ListViewItem _file = new DownloadItem(fileTitle, format, savePath, isAudio).NewItem();

            ExtensionMethods.SynchronizedInvoke(downloadQueueMaterialListView, () => downloadQueueMaterialListView.Items.Add(_file));

            int _listViewItems = downloadQueueMaterialListView.Items.Count - 1;

            var _mediaStreamInfoSet = await _client.GetVideoMediaStreamInfosAsync(_id);

            if (isAudio == false)
            {
                DownloadVideo(_mediaStreamInfoSet, fileTitle, downloadQueueMaterialListView, format, quality, _listViewItems, savePath, deleteDoneCheckBox);                   
            }
            else
            {
                DownloadAudio(_mediaStreamInfoSet, fileTitle, downloadQueueMaterialListView, format, bitrate, _listViewItems, savePath, deleteDoneCheckBox);
            }

        }

        static async void DownloadVideo(MediaStreamInfoSet mediaStreamInfoSet, string title, MaterialListView downloadQueueMaterialListView, string format, string quality, int _listViewItems, string savePath, MaterialCheckBox deleteDoneCheckBox)
        {
            var _audioStreamInfo = mediaStreamInfoSet.Audio.OrderByDescending(a => a.Bitrate).First();
            var _videoStreamInfo = mediaStreamInfoSet.Video.Where(v => v.Container.ToString() == format && v.VideoQualityLabel == quality).First();
            var _mediaStreamInfos = new MediaStreamInfo[] { _audioStreamInfo, _videoStreamInfo };

            IProgress<double> progress = new Progress<double>(p =>
            {
                ExtensionMethods.SynchronizedInvoke(downloadQueueMaterialListView, () => downloadQueueMaterialListView.Items[_listViewItems].SubItems[4].Text = (p * 100).ToString("0.00") + "%");
                if (p*100 == 100)
                {
                    ExtensionMethods.SynchronizedInvoke(downloadQueueMaterialListView, () => downloadQueueMaterialListView.Items[_listViewItems].SubItems[4].Text = "Done!");
                    DatabaseOperations.AddNewRecord(Settings.Default.Guid, title, format, savePath);

                    if (deleteDoneCheckBox.Checked == true)
                    {
                        Thread.Sleep(2000);
                        ExtensionMethods.SynchronizedInvoke(downloadQueueMaterialListView, () => downloadQueueMaterialListView.Items[_listViewItems].Remove());
                    }
                }
                    
            });

            await Task.Run(() => _converter.DownloadAndProcessMediaStreamsAsync(_mediaStreamInfos, savePath + "." + format, format, progress));
        }

        static async void DownloadAudio(MediaStreamInfoSet mediaStreamInfoSet, string title, MaterialListView downloadQueueMaterialListView, string format, long bitrate, int _listViewItems, string savePath, MaterialCheckBox deleteDoneCheckBox)
        {
            var _audioStreamInfo = mediaStreamInfoSet.Audio.OrderByDescending(a => a.Bitrate/1024 == bitrate).First();

            IProgress<double> progress = new Progress<double>(p =>
            {
                ExtensionMethods.SynchronizedInvoke(downloadQueueMaterialListView, () => downloadQueueMaterialListView.Items[_listViewItems].SubItems[4].Text = (p * 100).ToString("0.00") + "%");

                if(p*100 == 100)
                {                    
                    ExtensionMethods.SynchronizedInvoke(downloadQueueMaterialListView, () => downloadQueueMaterialListView.Items[_listViewItems].SubItems[4].Text = "Done!");
                    DatabaseOperations.AddNewRecord(Settings.Default.Guid, title, format, savePath);

                    if (deleteDoneCheckBox.Checked == true)
                    {
                        Thread.Sleep(2000);
                        ExtensionMethods.SynchronizedInvoke(downloadQueueMaterialListView, () => downloadQueueMaterialListView.Items[_listViewItems].Remove());
                    }                    
                }
                 
            });

            await Task.Run(() => _client.DownloadMediaStreamAsync(_audioStreamInfo, savePath +".mp3", progress));
        }

    }
}
