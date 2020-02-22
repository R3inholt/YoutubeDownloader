using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using YT_Downloader;

namespace UserInterface
{
    class ControlsService
    {
        public static void MaterialSkinInitialization(MaterialForm form)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red800, Primary.Red900, Accent.Red100, TextShade.WHITE);
        }

        public static void ShowToolTip(Control control, string message)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(control, message);
        }

        public static void ChangeHeaderColors(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)   
            {
                column.HeaderCell.Style.BackColor = Color.FromArgb(244, 67, 54);
                column.HeaderCell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                column.HeaderCell.Style.Font = new Font("Roboto", 15);
            }
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
