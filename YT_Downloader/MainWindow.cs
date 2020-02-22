using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Models;
using System.Threading;
using DataClasses;
using UserInterface;
using Helpers;
using YoutubeExplode.Exceptions;
using System.IO;
using DataRepository;

namespace YT_Downloader
{
    public partial class MainWindow : MaterialForm
    {
        string _quality;
        long _bitrate;
        string _format;
        bool _isSaveNeeded = true;
        
        

        public MainWindow()
        {
            InitializeComponent();
            if (ControlsService.CheckForInternetConnection() == false)
            {
                MessageBox.Show("Internet connection is necessary to run this application!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();                
            }
            ControlsService.MaterialSkinInitialization(this);
            ControlsService.ChangeHeaderColors(downloadHistoryDGV);
        }

        private async void getVideoButton_Click(object sender, EventArgs e)
        {
            try
            {
                IProgress<int> progress = new Progress<int>(p =>
                {
                    dataLoadProgressBar.Value = p;
                });

                await Task.Run(() => DataService.LoadMetaData(progress, dataLoadProgressBar, qualityFormatComboBox, videoUrlTxtBox, titleLabel, durationLabel, thumbNailPictureBox));
            }
            catch (Exception ex)
            {
                DataValidation.CheckException(ex, dataLoadProgressBar);
            }
        }

        private void titleLabel_MouseHover(object sender, EventArgs e)
        {
            if (titleLabel.Text.Length >= 82)
                ControlsService.ShowToolTip(titleLabel, DataService.FullTitle);
        }

        private void savePathButton_MouseHover(object sender, EventArgs e)
        {
            ControlsService.ShowToolTip(savePathButton, savePathTxtBox.Text);
        }

        private void savePathButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.FileName = DataService.FullTitle;               
                if (sf.ShowDialog() == DialogResult.OK)
                {                   
                    savePathTxtBox.Text = Path.GetDirectoryName(sf.FileName + @"\");
                }
            }
        }

        private void getVideoButton_MouseHover(object sender, EventArgs e)
        {
            ControlsService.ShowToolTip(getVideoButton, "Gets video specified by URL.");
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (DataValidation.isSavePathValid(savePathTxtBox) == true)
                {
                    _quality = (qualityFormatComboBox.SelectedItem as DownloadOption).quality;
                    _bitrate = (qualityFormatComboBox.SelectedItem as DownloadOption).bitrate;
                    _format = (qualityFormatComboBox.SelectedItem as DownloadOption).format;

                    bool _isAudio = (qualityFormatComboBox.SelectedItem as DownloadOption).isAudio;

                    await DataService.DownloadItem(titleLabel.Text, _format, _quality, _bitrate, savePathTxtBox.Text, downloadQueueMaterialListView, _isAudio, deleteDoneCheckBox);
                }                    
                else
                    throw new EmptySavePathException();
            }
            catch(Exception ex)
            {
                DataValidation.CheckException(ex, dataLoadProgressBar);
            }
            finally
            {
                downloadHistoryDGV.Update();
                downloadHistoryDGV.Refresh();
            }
        }    


        private void downloadQueueMaterialListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = downloadQueueMaterialListView.Columns[e.ColumnIndex].Width;
        }

        private void downloadQueueMaterialListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            ControlsService.ShowToolTip(downloadQueueMaterialListView, ".");
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_isSaveNeeded == true)
                Properties.Settings.Default.Save();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.Guid == null)
            {
                Properties.Settings.Default.Guid = Guid.NewGuid().ToString();
                DatabaseOperations.AddNewUserGuid(Properties.Settings.Default.Guid);
            }
            else
            {
                _isSaveNeeded = DatabaseValidation.CheckUserGuid(Properties.Settings.Default.Guid);
                downloadHistoryDGV.DataSource = DatabaseOperations.FillDataGridView(Properties.Settings.Default.Guid);
            }

            MessageBox.Show(Properties.Settings.Default.Guid);
        }
    }
}
