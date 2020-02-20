using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataClasses
{
    class DownloadItem
    {

        string fileTitle;
        string format;
        string savePath;
        bool isAudio;

        public DownloadItem(string _fileTitle, string _format, string _savePath, bool _isAudio = false)
        {
            fileTitle = _fileTitle;
            format = _format;
            savePath = _savePath;
            isAudio = _isAudio;
        }

        public ListViewItem NewItem()
        {
            ListViewItem _file = new ListViewItem();
            _file.SubItems.Add(fileTitle);
            if (isAudio == false)
                _file.SubItems.Add(format);
            else
                _file.SubItems.Add("Mp3");
            _file.SubItems.Add(savePath);
            _file.SubItems.Add("0 %");

            return _file;

        }

    }
}
