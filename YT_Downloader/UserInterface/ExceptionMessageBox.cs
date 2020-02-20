using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface;
using MaterialSkin.Controls;

namespace UserInterface
{
    public partial class ExceptionMessageBox : MaterialForm
    {
        public ExceptionMessageBox(string exceptionMessage)
        {
            
            InitializeComponent();
            ControlsService.MaterialSkinInitialization(this);
            exceptionMessageLabel.Text = exceptionMessage;
        }

        private void closeMessageBoxButton_Click(object sender, EventArgs e)
        {          
            this.Close();
            this.Dispose();
        }
        
    }
}
