using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode.Exceptions;
using MaterialSkin.Controls;
using UserInterface;
using DataClasses;
using System.ComponentModel;

namespace Helpers
{
    static class DataValidation
    {        
        public static void CheckException(Exception ex, MaterialProgressBar dataLoadProgressBar)
        {
            Tuple<Type,string> type = ExceptionData.ExceptionList.Find(e => e.Item1.IsInstanceOfType(ex));

            ExceptionMessageBox exceptionMessage = new ExceptionMessageBox(type.Item2);
            exceptionMessage.ShowDialog();
            dataLoadProgressBar.Value = 0;
        }

        public static bool isSavePathValid(MaterialSingleLineTextField savePathTxtBox)
        {
            if (savePathTxtBox.Text.Length == 0)
                return false;
            else
                return true;
        }
    }
}
