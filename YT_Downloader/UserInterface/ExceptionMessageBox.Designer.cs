namespace UserInterface
{
    partial class ExceptionMessageBox
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorPictureBox = new System.Windows.Forms.PictureBox();
            this.exceptionMessageLabel = new System.Windows.Forms.Label();
            this.closeMessageBoxButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // errorPictureBox
            // 
            this.errorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.errorPictureBox.Image = global::YT_Downloader.Properties.Resources.error;
            this.errorPictureBox.Location = new System.Drawing.Point(12, 89);
            this.errorPictureBox.Name = "errorPictureBox";
            this.errorPictureBox.Size = new System.Drawing.Size(68, 63);
            this.errorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorPictureBox.TabIndex = 0;
            this.errorPictureBox.TabStop = false;
            // 
            // exceptionMessageLabel
            // 
            this.exceptionMessageLabel.AutoSize = true;
            this.exceptionMessageLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exceptionMessageLabel.ForeColor = System.Drawing.Color.White;
            this.exceptionMessageLabel.Location = new System.Drawing.Point(86, 109);
            this.exceptionMessageLabel.Name = "exceptionMessageLabel";
            this.exceptionMessageLabel.Size = new System.Drawing.Size(0, 19);
            this.exceptionMessageLabel.TabIndex = 1;
            // 
            // closeMessageBoxButton
            // 
            this.closeMessageBoxButton.AutoSize = true;
            this.closeMessageBoxButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeMessageBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.closeMessageBoxButton.Depth = 0;
            this.closeMessageBoxButton.ForeColor = System.Drawing.Color.White;
            this.closeMessageBoxButton.Icon = null;
            this.closeMessageBoxButton.Location = new System.Drawing.Point(346, 159);
            this.closeMessageBoxButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeMessageBoxButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeMessageBoxButton.Name = "closeMessageBoxButton";
            this.closeMessageBoxButton.Primary = false;
            this.closeMessageBoxButton.Size = new System.Drawing.Size(39, 36);
            this.closeMessageBoxButton.TabIndex = 2;
            this.closeMessageBoxButton.Text = "Ok";
            this.closeMessageBoxButton.UseVisualStyleBackColor = false;
            this.closeMessageBoxButton.Click += new System.EventHandler(this.closeMessageBoxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "An error occured!";
            // 
            // ExceptionMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(398, 210);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeMessageBoxButton);
            this.Controls.Add(this.exceptionMessageLabel);
            this.Controls.Add(this.errorPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExceptionMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.errorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox errorPictureBox;
        private System.Windows.Forms.Label exceptionMessageLabel;
        private MaterialSkin.Controls.MaterialFlatButton closeMessageBoxButton;
        private System.Windows.Forms.Label label1;
    }
}
