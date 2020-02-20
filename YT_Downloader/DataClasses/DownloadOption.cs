using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    class DownloadOption
    {
        public string format;
        public string quality;
        public long bitrate;
        public bool isAudio = false;
        public DownloadOption(string _format, string _quality)
        {
            format = _format;
            quality = _quality;
        }

        public DownloadOption(string _format, long _bitrate)
        {
            isAudio = true;
            format = _format;
            bitrate = _bitrate;
            bitrate /= 1024;
        }

        public override string ToString()
        {
            if (!isAudio)
                return quality + " | " + format;
            else
                return bitrate +  " kb/s " + " |  Mp3";
        }
    }
}
