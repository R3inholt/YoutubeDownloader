using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Exceptions;

namespace DataClasses
{
    static class ExceptionData
    {
        public static readonly List<Tuple<Type, string>> ExceptionList = new List<Tuple<Type, string>>
        {
            new Tuple<Type, string>(typeof(UnrecognizedStructureException), "Unrecognized structure of URL!"),
            new Tuple<Type, string>(typeof(VideoUnavailableException), "This video is no longer available!"),
            new Tuple<Type, string>(typeof(VideoUnplayableException), "This video is blocked in your country!"),
            new Tuple<Type, string>(typeof(FormatException), "Bad URL format!"),
            new Tuple<Type, string>(typeof(EmptySavePathException), "You cannot leave path empty!"),
            new Tuple<Type, string>(typeof(NullReferenceException), "Pick quality and format!")
        };
    }
}

