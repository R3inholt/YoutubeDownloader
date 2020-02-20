namespace YT_Downloader
{
    partial class MainWindow
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuControl = new MaterialSkin.Controls.MaterialTabControl();
            this.getVideoPage = new System.Windows.Forms.TabPage();
            this.savePathTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.savePathButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.downloadButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.getVideoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.videoUrlTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.savePathPictureBox = new System.Windows.Forms.PictureBox();
            this.qualityFormatPictureBox = new System.Windows.Forms.PictureBox();
            this.getVideoPicture = new System.Windows.Forms.PictureBox();
            this.dataLoadProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.savePathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.videoUrlTxtLabel = new System.Windows.Forms.Label();
            this.qualityFormatLabel = new MaterialSkin.Controls.MaterialLabel();
            this.durationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.thumbNailPictureBox = new System.Windows.Forms.PictureBox();
            this.qualityFormatComboBox = new System.Windows.Forms.ComboBox();
            this.downloadQueuePage = new System.Windows.Forms.TabPage();
            this.deleteDoneCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.downloadQueueMaterialListView = new MaterialSkin.Controls.MaterialListView();
            this.emptyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formatHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.historyPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadHistoryDGV = new System.Windows.Forms.DataGridView();
            this.filesHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.downloadHistoryDBDataSet = new YT_Downloader.DownloadHistoryDBDataSet();
            this.menuSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.filesHistoryTableAdapter = new YT_Downloader.DownloadHistoryDBDataSetTableAdapters.FilesHistoryTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuControl.SuspendLayout();
            this.getVideoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savePathPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityFormatPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getVideoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailPictureBox)).BeginInit();
            this.downloadQueuePage.SuspendLayout();
            this.historyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadHistoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadHistoryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.Controls.Add(this.getVideoPage);
            this.menuControl.Controls.Add(this.downloadQueuePage);
            this.menuControl.Controls.Add(this.historyPage);
            this.menuControl.Depth = 0;
            this.menuControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuControl.Location = new System.Drawing.Point(1, 65);
            this.menuControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuControl.Name = "menuControl";
            this.menuControl.SelectedIndex = 0;
            this.menuControl.Size = new System.Drawing.Size(734, 618);
            this.menuControl.TabIndex = 9;
            // 
            // getVideoPage
            // 
            this.getVideoPage.Controls.Add(this.savePathTxtBox);
            this.getVideoPage.Controls.Add(this.savePathButton);
            this.getVideoPage.Controls.Add(this.downloadButton);
            this.getVideoPage.Controls.Add(this.getVideoButton);
            this.getVideoPage.Controls.Add(this.videoUrlTxtBox);
            this.getVideoPage.Controls.Add(this.savePathPictureBox);
            this.getVideoPage.Controls.Add(this.qualityFormatPictureBox);
            this.getVideoPage.Controls.Add(this.getVideoPicture);
            this.getVideoPage.Controls.Add(this.dataLoadProgressBar);
            this.getVideoPage.Controls.Add(this.savePathLabel);
            this.getVideoPage.Controls.Add(this.titleLabel);
            this.getVideoPage.Controls.Add(this.videoUrlTxtLabel);
            this.getVideoPage.Controls.Add(this.qualityFormatLabel);
            this.getVideoPage.Controls.Add(this.durationLabel);
            this.getVideoPage.Controls.Add(this.thumbNailPictureBox);
            this.getVideoPage.Controls.Add(this.qualityFormatComboBox);
            this.getVideoPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.getVideoPage.Location = new System.Drawing.Point(4, 22);
            this.getVideoPage.Name = "getVideoPage";
            this.getVideoPage.Padding = new System.Windows.Forms.Padding(3);
            this.getVideoPage.Size = new System.Drawing.Size(726, 592);
            this.getVideoPage.TabIndex = 1;
            this.getVideoPage.Text = "Get Video";
            this.getVideoPage.UseVisualStyleBackColor = true;
            // 
            // savePathTxtBox
            // 
            this.savePathTxtBox.Depth = 0;
            this.savePathTxtBox.Enabled = false;
            this.savePathTxtBox.Hint = "";
            this.savePathTxtBox.Location = new System.Drawing.Point(61, 479);
            this.savePathTxtBox.MaxLength = 32767;
            this.savePathTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePathTxtBox.Name = "savePathTxtBox";
            this.savePathTxtBox.PasswordChar = '\0';
            this.savePathTxtBox.SelectedText = "";
            this.savePathTxtBox.SelectionLength = 0;
            this.savePathTxtBox.SelectionStart = 0;
            this.savePathTxtBox.Size = new System.Drawing.Size(351, 23);
            this.savePathTxtBox.TabIndex = 11;
            this.savePathTxtBox.TabStop = false;
            this.savePathTxtBox.UseSystemPasswordChar = false;
            // 
            // savePathButton
            // 
            this.savePathButton.AutoSize = true;
            this.savePathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savePathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePathButton.Depth = 0;
            this.savePathButton.Icon = null;
            this.savePathButton.Location = new System.Drawing.Point(419, 466);
            this.savePathButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.savePathButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Primary = false;
            this.savePathButton.Size = new System.Drawing.Size(32, 36);
            this.savePathButton.TabIndex = 28;
            this.savePathButton.Text = "...";
            this.savePathButton.UseVisualStyleBackColor = true;
            this.savePathButton.Click += new System.EventHandler(this.savePathButton_Click);
            this.savePathButton.MouseHover += new System.EventHandler(this.savePathButton_MouseHover);
            // 
            // downloadButton
            // 
            this.downloadButton.AutoSize = true;
            this.downloadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.Depth = 0;
            this.downloadButton.Icon = null;
            this.downloadButton.Location = new System.Drawing.Point(596, 550);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.downloadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Primary = false;
            this.downloadButton.Size = new System.Drawing.Size(116, 36);
            this.downloadButton.TabIndex = 20;
            this.downloadButton.Text = "Add to queue";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // getVideoButton
            // 
            this.getVideoButton.AutoSize = true;
            this.getVideoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getVideoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getVideoButton.Depth = 0;
            this.getVideoButton.Icon = null;
            this.getVideoButton.Location = new System.Drawing.Point(665, 32);
            this.getVideoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getVideoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getVideoButton.Name = "getVideoButton";
            this.getVideoButton.Primary = false;
            this.getVideoButton.Size = new System.Drawing.Size(46, 36);
            this.getVideoButton.TabIndex = 0;
            this.getVideoButton.Text = "Get";
            this.getVideoButton.UseVisualStyleBackColor = true;
            this.getVideoButton.Click += new System.EventHandler(this.getVideoButton_Click);
            this.getVideoButton.MouseHover += new System.EventHandler(this.getVideoButton_MouseHover);
            // 
            // videoUrlTxtBox
            // 
            this.videoUrlTxtBox.Depth = 0;
            this.videoUrlTxtBox.Hint = "";
            this.videoUrlTxtBox.Location = new System.Drawing.Point(61, 45);
            this.videoUrlTxtBox.MaxLength = 32767;
            this.videoUrlTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.videoUrlTxtBox.Name = "videoUrlTxtBox";
            this.videoUrlTxtBox.PasswordChar = '\0';
            this.videoUrlTxtBox.SelectedText = "";
            this.videoUrlTxtBox.SelectionLength = 0;
            this.videoUrlTxtBox.SelectionStart = 0;
            this.videoUrlTxtBox.Size = new System.Drawing.Size(596, 23);
            this.videoUrlTxtBox.TabIndex = 12;
            this.videoUrlTxtBox.TabStop = false;
            this.videoUrlTxtBox.UseSystemPasswordChar = false;
            // 
            // savePathPictureBox
            // 
            this.savePathPictureBox.Image = global::YT_Downloader.Properties.Resources.folder;
            this.savePathPictureBox.Location = new System.Drawing.Point(16, 465);
            this.savePathPictureBox.Name = "savePathPictureBox";
            this.savePathPictureBox.Size = new System.Drawing.Size(39, 37);
            this.savePathPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.savePathPictureBox.TabIndex = 31;
            this.savePathPictureBox.TabStop = false;
            // 
            // qualityFormatPictureBox
            // 
            this.qualityFormatPictureBox.Image = global::YT_Downloader.Properties.Resources.gears;
            this.qualityFormatPictureBox.Location = new System.Drawing.Point(499, 466);
            this.qualityFormatPictureBox.Name = "qualityFormatPictureBox";
            this.qualityFormatPictureBox.Size = new System.Drawing.Size(39, 36);
            this.qualityFormatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qualityFormatPictureBox.TabIndex = 30;
            this.qualityFormatPictureBox.TabStop = false;
            // 
            // getVideoPicture
            // 
            this.getVideoPicture.Image = global::YT_Downloader.Properties.Resources.youtube_logo;
            this.getVideoPicture.Location = new System.Drawing.Point(16, 30);
            this.getVideoPicture.Name = "getVideoPicture";
            this.getVideoPicture.Size = new System.Drawing.Size(39, 38);
            this.getVideoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.getVideoPicture.TabIndex = 29;
            this.getVideoPicture.TabStop = false;
            // 
            // dataLoadProgressBar
            // 
            this.dataLoadProgressBar.Depth = 0;
            this.dataLoadProgressBar.Location = new System.Drawing.Point(16, 419);
            this.dataLoadProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.dataLoadProgressBar.Name = "dataLoadProgressBar";
            this.dataLoadProgressBar.Size = new System.Drawing.Size(696, 5);
            this.dataLoadProgressBar.TabIndex = 27;
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Depth = 0;
            this.savePathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.savePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.savePathLabel.Location = new System.Drawing.Point(57, 457);
            this.savePathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(75, 19);
            this.savePathLabel.TabIndex = 24;
            this.savePathLabel.Text = "Save Path";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(25, 85);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 20);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.MouseHover += new System.EventHandler(this.titleLabel_MouseHover);
            // 
            // videoUrlTxtLabel
            // 
            this.videoUrlTxtLabel.AutoSize = true;
            this.videoUrlTxtLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.videoUrlTxtLabel.ForeColor = System.Drawing.Color.White;
            this.videoUrlTxtLabel.Location = new System.Drawing.Point(58, 25);
            this.videoUrlTxtLabel.Name = "videoUrlTxtLabel";
            this.videoUrlTxtLabel.Size = new System.Drawing.Size(71, 17);
            this.videoUrlTxtLabel.TabIndex = 22;
            this.videoUrlTxtLabel.Text = "VIDEO URL";
            // 
            // qualityFormatLabel
            // 
            this.qualityFormatLabel.AutoSize = true;
            this.qualityFormatLabel.Depth = 0;
            this.qualityFormatLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.qualityFormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.qualityFormatLabel.Location = new System.Drawing.Point(540, 459);
            this.qualityFormatLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.qualityFormatLabel.Name = "qualityFormatLabel";
            this.qualityFormatLabel.Size = new System.Drawing.Size(117, 19);
            this.qualityFormatLabel.TabIndex = 19;
            this.qualityFormatLabel.Text = "Quality / Format";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.BackColor = System.Drawing.Color.Black;
            this.durationLabel.Depth = 0;
            this.durationLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.durationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.durationLabel.Location = new System.Drawing.Point(637, 380);
            this.durationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(0, 19);
            this.durationLabel.TabIndex = 15;
            // 
            // thumbNailPictureBox
            // 
            this.thumbNailPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbNailPictureBox.Location = new System.Drawing.Point(16, 74);
            this.thumbNailPictureBox.Name = "thumbNailPictureBox";
            this.thumbNailPictureBox.Size = new System.Drawing.Size(696, 339);
            this.thumbNailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbNailPictureBox.TabIndex = 13;
            this.thumbNailPictureBox.TabStop = false;
            // 
            // qualityFormatComboBox
            // 
            this.qualityFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityFormatComboBox.FormattingEnabled = true;
            this.qualityFormatComboBox.Location = new System.Drawing.Point(544, 481);
            this.qualityFormatComboBox.Name = "qualityFormatComboBox";
            this.qualityFormatComboBox.Size = new System.Drawing.Size(167, 21);
            this.qualityFormatComboBox.TabIndex = 12;
            // 
            // downloadQueuePage
            // 
            this.downloadQueuePage.Controls.Add(this.deleteDoneCheckBox);
            this.downloadQueuePage.Controls.Add(this.downloadQueueMaterialListView);
            this.downloadQueuePage.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.downloadQueuePage.Location = new System.Drawing.Point(4, 22);
            this.downloadQueuePage.Name = "downloadQueuePage";
            this.downloadQueuePage.Padding = new System.Windows.Forms.Padding(3);
            this.downloadQueuePage.Size = new System.Drawing.Size(726, 592);
            this.downloadQueuePage.TabIndex = 2;
            this.downloadQueuePage.Text = "Download Queue";
            this.downloadQueuePage.UseVisualStyleBackColor = true;
            // 
            // deleteDoneCheckBox
            // 
            this.deleteDoneCheckBox.AutoSize = true;
            this.deleteDoneCheckBox.Depth = 0;
            this.deleteDoneCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.deleteDoneCheckBox.Location = new System.Drawing.Point(4, 12);
            this.deleteDoneCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.deleteDoneCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.deleteDoneCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteDoneCheckBox.Name = "deleteDoneCheckBox";
            this.deleteDoneCheckBox.Ripple = true;
            this.deleteDoneCheckBox.Size = new System.Drawing.Size(229, 30);
            this.deleteDoneCheckBox.TabIndex = 1;
            this.deleteDoneCheckBox.Text = "Delete done downloads from list";
            this.deleteDoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // downloadQueueMaterialListView
            // 
            this.downloadQueueMaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.downloadQueueMaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emptyHeader,
            this.titleHeader,
            this.formatHeader,
            this.pathHeader,
            this.progressHeader});
            this.downloadQueueMaterialListView.Depth = 0;
            this.downloadQueueMaterialListView.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.downloadQueueMaterialListView.FullRowSelect = true;
            this.downloadQueueMaterialListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.downloadQueueMaterialListView.HideSelection = false;
            this.downloadQueueMaterialListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.downloadQueueMaterialListView.Location = new System.Drawing.Point(0, 55);
            this.downloadQueueMaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.downloadQueueMaterialListView.MouseState = MaterialSkin.MouseState.OUT;
            this.downloadQueueMaterialListView.Name = "downloadQueueMaterialListView";
            this.downloadQueueMaterialListView.OwnerDraw = true;
            this.downloadQueueMaterialListView.Scrollable = false;
            this.downloadQueueMaterialListView.ShowItemToolTips = true;
            this.downloadQueueMaterialListView.Size = new System.Drawing.Size(724, 507);
            this.downloadQueueMaterialListView.TabIndex = 0;
            this.downloadQueueMaterialListView.UseCompatibleStateImageBehavior = false;
            this.downloadQueueMaterialListView.View = System.Windows.Forms.View.Details;
            this.downloadQueueMaterialListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.downloadQueueMaterialListView_ColumnWidthChanging);
            this.downloadQueueMaterialListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.downloadQueueMaterialListView_ItemMouseHover);
            // 
            // emptyHeader
            // 
            this.emptyHeader.Text = "";
            this.emptyHeader.Width = 0;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 270;
            // 
            // formatHeader
            // 
            this.formatHeader.Text = "Format";
            this.formatHeader.Width = 100;
            // 
            // pathHeader
            // 
            this.pathHeader.Text = "Save path";
            this.pathHeader.Width = 250;
            // 
            // progressHeader
            // 
            this.progressHeader.Text = "Progress";
            this.progressHeader.Width = 200;
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.label3);
            this.historyPage.Controls.Add(this.label2);
            this.historyPage.Controls.Add(this.label1);
            this.historyPage.Controls.Add(this.downloadHistoryDGV);
            this.historyPage.Location = new System.Drawing.Point(4, 22);
            this.historyPage.Name = "historyPage";
            this.historyPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyPage.Size = new System.Drawing.Size(726, 592);
            this.historyPage.TabIndex = 3;
            this.historyPage.Text = "History";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(427, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Save path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name";
            // 
            // downloadHistoryDGV
            // 
            this.downloadHistoryDGV.AllowUserToAddRows = false;
            this.downloadHistoryDGV.AllowUserToDeleteRows = false;
            this.downloadHistoryDGV.AllowUserToResizeColumns = false;
            this.downloadHistoryDGV.AllowUserToResizeRows = false;
            this.downloadHistoryDGV.AutoGenerateColumns = false;
            this.downloadHistoryDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.downloadHistoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.downloadHistoryDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.downloadHistoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.downloadHistoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.downloadHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.downloadHistoryDGV.ColumnHeadersVisible = false;
            this.downloadHistoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.savePathDataGridViewTextBoxColumn});
            this.downloadHistoryDGV.DataSource = this.filesHistoryBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.downloadHistoryDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.downloadHistoryDGV.EnableHeadersVisualStyles = false;
            this.downloadHistoryDGV.GridColor = System.Drawing.Color.Black;
            this.downloadHistoryDGV.Location = new System.Drawing.Point(3, 72);
            this.downloadHistoryDGV.Name = "downloadHistoryDGV";
            this.downloadHistoryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.downloadHistoryDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.downloadHistoryDGV.RowHeadersVisible = false;
            this.downloadHistoryDGV.Size = new System.Drawing.Size(714, 500);
            this.downloadHistoryDGV.TabIndex = 0;
            // 
            // filesHistoryBindingSource
            // 
            this.filesHistoryBindingSource.DataMember = "FilesHistory";
            this.filesHistoryBindingSource.DataSource = this.downloadHistoryDBDataSet;
            // 
            // downloadHistoryDBDataSet
            // 
            this.downloadHistoryDBDataSet.DataSetName = "DownloadHistoryDBDataSet";
            this.downloadHistoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuSelector
            // 
            this.menuSelector.BaseTabControl = this.menuControl;
            this.menuSelector.Depth = 0;
            this.menuSelector.Location = new System.Drawing.Point(200, 27);
            this.menuSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuSelector.Name = "menuSelector";
            this.menuSelector.Size = new System.Drawing.Size(426, 32);
            this.menuSelector.TabIndex = 10;
            this.menuSelector.Text = "materialTabSelector1";
            // 
            // infoToolTip
            // 
            this.infoToolTip.ShowAlways = true;
            // 
            // filesHistoryTableAdapter
            // 
            this.filesHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.titleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.titleDataGridViewTextBoxColumn.HeaderText = "File name";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.titleDataGridViewTextBoxColumn.Width = 300;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            this.formatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.formatDataGridViewTextBoxColumn.Width = 125;
            // 
            // savePathDataGridViewTextBoxColumn
            // 
            this.savePathDataGridViewTextBoxColumn.DataPropertyName = "Save path";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            this.savePathDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.savePathDataGridViewTextBoxColumn.HeaderText = "Save path";
            this.savePathDataGridViewTextBoxColumn.Name = "savePathDataGridViewTextBoxColumn";
            this.savePathDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.savePathDataGridViewTextBoxColumn.Width = 286;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 683);
            this.Controls.Add(this.menuSelector);
            this.Controls.Add(this.menuControl);
            this.Name = "MainWindow";
            this.Text = "YoutubeDownloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuControl.ResumeLayout(false);
            this.getVideoPage.ResumeLayout(false);
            this.getVideoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savePathPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityFormatPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getVideoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailPictureBox)).EndInit();
            this.downloadQueuePage.ResumeLayout(false);
            this.downloadQueuePage.PerformLayout();
            this.historyPage.ResumeLayout(false);
            this.historyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadHistoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadHistoryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl menuControl;
        private System.Windows.Forms.TabPage getVideoPage;
        private MaterialSkin.Controls.MaterialTabSelector menuSelector;
        private System.Windows.Forms.TabPage downloadQueuePage;
        private MaterialSkin.Controls.MaterialFlatButton getVideoButton;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.ComboBox qualityFormatComboBox;
        private System.Windows.Forms.PictureBox thumbNailPictureBox;
        private MaterialSkin.Controls.MaterialLabel durationLabel;
        private MaterialSkin.Controls.MaterialLabel qualityFormatLabel;
        private MaterialSkin.Controls.MaterialFlatButton downloadButton;
        private System.Windows.Forms.Label videoUrlTxtLabel;
        private System.Windows.Forms.Label titleLabel;
        private MaterialSkin.Controls.MaterialLabel savePathLabel;
        private MaterialSkin.Controls.MaterialProgressBar dataLoadProgressBar;
        private System.Windows.Forms.ToolTip infoToolTip;
        private MaterialSkin.Controls.MaterialFlatButton savePathButton;
        private System.Windows.Forms.PictureBox getVideoPicture;
        private System.Windows.Forms.PictureBox qualityFormatPictureBox;
        private System.Windows.Forms.PictureBox savePathPictureBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField savePathTxtBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField videoUrlTxtBox;
        private MaterialSkin.Controls.MaterialListView downloadQueueMaterialListView;
        private System.Windows.Forms.ColumnHeader emptyHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader formatHeader;
        private System.Windows.Forms.ColumnHeader pathHeader;
        private System.Windows.Forms.ColumnHeader progressHeader;
        public MaterialSkin.Controls.MaterialCheckBox deleteDoneCheckBox;
        private DownloadHistoryDBDataSet downloadHistoryDBDataSet;
        private System.Windows.Forms.BindingSource filesHistoryBindingSource;
        private DownloadHistoryDBDataSetTableAdapters.FilesHistoryTableAdapter filesHistoryTableAdapter;
        private System.Windows.Forms.DataGridView downloadHistoryDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savePathDataGridViewTextBoxColumn;
    }
}

