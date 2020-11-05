namespace Spotifly
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ControlPanel = new System.Windows.Forms.GroupBox();
            this.ElapsedTimeBarPictureBox = new System.Windows.Forms.PictureBox();
            this.ShuffleBttn = new System.Windows.Forms.Button();
            this.CurrentMediaTxtBox = new System.Windows.Forms.RichTextBox();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.NextMediaBttn = new System.Windows.Forms.Button();
            this.PrevMediaBttn = new System.Windows.Forms.Button();
            this.FullScreenBttn = new System.Windows.Forms.Button();
            this.MediaLengthLabel = new System.Windows.Forms.Label();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.PlayBttn = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ThemeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.ResizeForMediaCheckBox = new System.Windows.Forms.CheckBox();
            this.AboutBttn = new System.Windows.Forms.Button();
            this.DownloadedMediaPanel = new System.Windows.Forms.Panel();
            this.BackBttn = new System.Windows.Forms.Button();
            this.MediaListView = new System.Windows.Forms.ListView();
            this.folderLabel = new System.Windows.Forms.Label();
            this.MediaPlayerPanel = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.DwnldSttsLabel = new System.Windows.Forms.Label();
            this.DownloadLabel = new System.Windows.Forms.Label();
            this.AudioDwnldBttn = new System.Windows.Forms.Button();
            this.ViewsLabel = new System.Windows.Forms.Label();
            this.VideoDwnldBttn = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.UploadDateLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ThumbnailPicture = new System.Windows.Forms.PictureBox();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SongsBttn = new System.Windows.Forms.Button();
            this.BrowseBttn = new System.Windows.Forms.Button();
            this.PanelGroupBox = new System.Windows.Forms.GroupBox();
            this.MediaPlayerBttn = new System.Windows.Forms.Button();
            this.SettingsBttn = new System.Windows.Forms.Button();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.LoadImage = new System.Windows.Forms.PictureBox();
            this.YoutubeBrowserPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElapsedTimeBarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.DownloadedMediaPanel.SuspendLayout();
            this.MediaPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.BrowserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailPicture)).BeginInit();
            this.PanelGroupBox.SuspendLayout();
            this.LoadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel.Controls.Add(this.ElapsedTimeBarPictureBox);
            this.ControlPanel.Controls.Add(this.ShuffleBttn);
            this.ControlPanel.Controls.Add(this.CurrentMediaTxtBox);
            this.ControlPanel.Controls.Add(this.VolumeTrackBar);
            this.ControlPanel.Controls.Add(this.NextMediaBttn);
            this.ControlPanel.Controls.Add(this.PrevMediaBttn);
            this.ControlPanel.Controls.Add(this.FullScreenBttn);
            this.ControlPanel.Controls.Add(this.MediaLengthLabel);
            this.ControlPanel.Controls.Add(this.ElapsedTimeLabel);
            this.ControlPanel.Controls.Add(this.PlayBttn);
            this.ControlPanel.Location = new System.Drawing.Point(0, 433);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(906, 75);
            this.ControlPanel.TabIndex = 1;
            this.ControlPanel.TabStop = false;
            // 
            // ElapsedTimeBarPictureBox
            // 
            this.ElapsedTimeBarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElapsedTimeBarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ElapsedTimeBarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElapsedTimeBarPictureBox.Location = new System.Drawing.Point(7, 12);
            this.ElapsedTimeBarPictureBox.Name = "ElapsedTimeBarPictureBox";
            this.ElapsedTimeBarPictureBox.Size = new System.Drawing.Size(884, 10);
            this.ElapsedTimeBarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ElapsedTimeBarPictureBox.TabIndex = 12;
            this.ElapsedTimeBarPictureBox.TabStop = false;
            this.ElapsedTimeBarPictureBox.Visible = false;
            this.ElapsedTimeBarPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseClick);
            // 
            // ShuffleBttn
            // 
            this.ShuffleBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ShuffleBttn.BackColor = System.Drawing.Color.Transparent;
            this.ShuffleBttn.FlatAppearance.BorderSize = 0;
            this.ShuffleBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleBttn.Image = global::Spotifly.Properties.Resources.Shuffle_Image;
            this.ShuffleBttn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ShuffleBttn.Location = new System.Drawing.Point(577, 27);
            this.ShuffleBttn.Name = "ShuffleBttn";
            this.ShuffleBttn.Size = new System.Drawing.Size(58, 38);
            this.ShuffleBttn.TabIndex = 7;
            this.ShuffleBttn.UseVisualStyleBackColor = false;
            this.ShuffleBttn.Click += new System.EventHandler(this.ShuffleBttn_Click);
            // 
            // CurrentMediaTxtBox
            // 
            this.CurrentMediaTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentMediaTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentMediaTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentMediaTxtBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentMediaTxtBox.DetectUrls = false;
            this.CurrentMediaTxtBox.Location = new System.Drawing.Point(9, 46);
            this.CurrentMediaTxtBox.Multiline = false;
            this.CurrentMediaTxtBox.Name = "CurrentMediaTxtBox";
            this.CurrentMediaTxtBox.ReadOnly = true;
            this.CurrentMediaTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CurrentMediaTxtBox.Size = new System.Drawing.Size(320, 20);
            this.CurrentMediaTxtBox.TabIndex = 11;
            this.CurrentMediaTxtBox.Text = "Current Media";
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.VolumeTrackBar.Location = new System.Drawing.Point(734, 23);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.MaximumSize = new System.Drawing.Size(104, 25);
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeTrackBar.TabIndex = 8;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Value = 50;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // NextMediaBttn
            // 
            this.NextMediaBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextMediaBttn.BackColor = System.Drawing.Color.Transparent;
            this.NextMediaBttn.FlatAppearance.BorderSize = 0;
            this.NextMediaBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextMediaBttn.Image = global::Spotifly.Properties.Resources.Advance;
            this.NextMediaBttn.Location = new System.Drawing.Point(508, 24);
            this.NextMediaBttn.Name = "NextMediaBttn";
            this.NextMediaBttn.Size = new System.Drawing.Size(45, 45);
            this.NextMediaBttn.TabIndex = 6;
            this.NextMediaBttn.UseVisualStyleBackColor = false;
            this.NextMediaBttn.Click += new System.EventHandler(this.NextMediaBttn_Click);
            // 
            // PrevMediaBttn
            // 
            this.PrevMediaBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrevMediaBttn.BackColor = System.Drawing.Color.Transparent;
            this.PrevMediaBttn.FlatAppearance.BorderSize = 0;
            this.PrevMediaBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevMediaBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevMediaBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrevMediaBttn.Image = global::Spotifly.Properties.Resources.Previous;
            this.PrevMediaBttn.Location = new System.Drawing.Point(343, 24);
            this.PrevMediaBttn.Name = "PrevMediaBttn";
            this.PrevMediaBttn.Size = new System.Drawing.Size(45, 45);
            this.PrevMediaBttn.TabIndex = 4;
            this.PrevMediaBttn.UseVisualStyleBackColor = false;
            this.PrevMediaBttn.Click += new System.EventHandler(this.PrevMediaBttn_Click);
            // 
            // FullScreenBttn
            // 
            this.FullScreenBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenBttn.BackColor = System.Drawing.Color.Transparent;
            this.FullScreenBttn.FlatAppearance.BorderSize = 0;
            this.FullScreenBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreenBttn.Location = new System.Drawing.Point(844, 44);
            this.FullScreenBttn.Name = "FullScreenBttn";
            this.FullScreenBttn.Size = new System.Drawing.Size(56, 23);
            this.FullScreenBttn.TabIndex = 7;
            this.FullScreenBttn.Text = "FullScreen";
            this.FullScreenBttn.UseVisualStyleBackColor = false;
            this.FullScreenBttn.Click += new System.EventHandler(this.FullScreenBttn_Click);
            // 
            // MediaLengthLabel
            // 
            this.MediaLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaLengthLabel.AutoSize = true;
            this.MediaLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaLengthLabel.Location = new System.Drawing.Point(860, 28);
            this.MediaLengthLabel.Name = "MediaLengthLabel";
            this.MediaLengthLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MediaLengthLabel.Size = new System.Drawing.Size(34, 13);
            this.MediaLengthLabel.TabIndex = 4;
            this.MediaLengthLabel.Text = "00:00";
            this.MediaLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(6, 28);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(71, 13);
            this.ElapsedTimeLabel.TabIndex = 3;
            this.ElapsedTimeLabel.Text = "Elapsed Time";
            this.ElapsedTimeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ElapsedTimeLabel_MouseClick);
            // 
            // PlayBttn
            // 
            this.PlayBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayBttn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBttn.FlatAppearance.BorderSize = 0;
            this.PlayBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBttn.ForeColor = System.Drawing.Color.Transparent;
            this.PlayBttn.Image = global::Spotifly.Properties.Resources.Playy;
            this.PlayBttn.Location = new System.Drawing.Point(430, 24);
            this.PlayBttn.Name = "PlayBttn";
            this.PlayBttn.Size = new System.Drawing.Size(45, 45);
            this.PlayBttn.TabIndex = 5;
            this.PlayBttn.UseVisualStyleBackColor = false;
            this.PlayBttn.Click += new System.EventHandler(this.PlayBttn_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPanel.Controls.Add(this.ThemeSelectionComboBox);
            this.SettingsPanel.Controls.Add(this.ResizeForMediaCheckBox);
            this.SettingsPanel.Controls.Add(this.AboutBttn);
            this.SettingsPanel.Location = new System.Drawing.Point(12, 168);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(99, 93);
            this.SettingsPanel.TabIndex = 3;
            this.SettingsPanel.Visible = false;
            // 
            // ThemeSelectionComboBox
            // 
            this.ThemeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeSelectionComboBox.FormattingEnabled = true;
            this.ThemeSelectionComboBox.Location = new System.Drawing.Point(0, 30);
            this.ThemeSelectionComboBox.Name = "ThemeSelectionComboBox";
            this.ThemeSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.ThemeSelectionComboBox.TabIndex = 2;
            this.ThemeSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeSelectionComboBox_SelectedIndexChanged);
            // 
            // ResizeForMediaCheckBox
            // 
            this.ResizeForMediaCheckBox.AutoSize = true;
            this.ResizeForMediaCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ResizeForMediaCheckBox.Location = new System.Drawing.Point(0, 5);
            this.ResizeForMediaCheckBox.Name = "ResizeForMediaCheckBox";
            this.ResizeForMediaCheckBox.Size = new System.Drawing.Size(268, 17);
            this.ResizeForMediaCheckBox.TabIndex = 1;
            this.ResizeForMediaCheckBox.Text = "Automatically resize the app to match media\'s video";
            this.ResizeForMediaCheckBox.UseVisualStyleBackColor = false;
            // 
            // AboutBttn
            // 
            this.AboutBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutBttn.Location = new System.Drawing.Point(15, 58);
            this.AboutBttn.Name = "AboutBttn";
            this.AboutBttn.Size = new System.Drawing.Size(75, 23);
            this.AboutBttn.TabIndex = 0;
            this.AboutBttn.Text = "About";
            this.AboutBttn.UseVisualStyleBackColor = true;
            this.AboutBttn.Click += new System.EventHandler(this.AboutBttn_Click);
            // 
            // DownloadedMediaPanel
            // 
            this.DownloadedMediaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadedMediaPanel.BackColor = System.Drawing.Color.Transparent;
            this.DownloadedMediaPanel.Controls.Add(this.BackBttn);
            this.DownloadedMediaPanel.Controls.Add(this.MediaListView);
            this.DownloadedMediaPanel.Controls.Add(this.folderLabel);
            this.DownloadedMediaPanel.Location = new System.Drawing.Point(6, 366);
            this.DownloadedMediaPanel.Name = "DownloadedMediaPanel";
            this.DownloadedMediaPanel.Size = new System.Drawing.Size(102, 73);
            this.DownloadedMediaPanel.TabIndex = 3;
            this.DownloadedMediaPanel.Visible = false;
            this.DownloadedMediaPanel.VisibleChanged += new System.EventHandler(this.DownloadedMediaPanel_VisibleChanged);
            this.DownloadedMediaPanel.Resize += new System.EventHandler(this.DownloadedMediaPanel_Resize);
            // 
            // BackBttn
            // 
            this.BackBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBttn.BackColor = System.Drawing.Color.Transparent;
            this.BackBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BackBttn.FlatAppearance.BorderSize = 0;
            this.BackBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackBttn.Location = new System.Drawing.Point(-42, 3);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(140, 20);
            this.BackBttn.TabIndex = 5;
            this.BackBttn.Text = "Back";
            this.BackBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBttn.UseVisualStyleBackColor = false;
            this.BackBttn.Click += new System.EventHandler(this.BackBttn_Click);
            this.BackBttn.MouseEnter += new System.EventHandler(this.BackBttn_MouseEnter);
            this.BackBttn.MouseLeave += new System.EventHandler(this.BackBttn_MouseLeave);
            // 
            // MediaListView
            // 
            this.MediaListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaListView.BackColor = System.Drawing.SystemColors.Control;
            this.MediaListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MediaListView.GridLines = true;
            this.MediaListView.HideSelection = false;
            this.MediaListView.Location = new System.Drawing.Point(0, 25);
            this.MediaListView.Name = "MediaListView";
            this.MediaListView.Size = new System.Drawing.Size(102, 47);
            this.MediaListView.TabIndex = 1;
            this.MediaListView.UseCompatibleStateImageBehavior = false;
            this.MediaListView.View = System.Windows.Forms.View.List;
            this.MediaListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MediaListView_ItemSelectionChanged);
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(-3, 3);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(130, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Looking to this folder label";
            // 
            // MediaPlayerPanel
            // 
            this.MediaPlayerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaPlayerPanel.Controls.Add(this.axWindowsMediaPlayer);
            this.MediaPlayerPanel.Location = new System.Drawing.Point(4, 269);
            this.MediaPlayerPanel.Name = "MediaPlayerPanel";
            this.MediaPlayerPanel.Size = new System.Drawing.Size(39, 28);
            this.MediaPlayerPanel.TabIndex = 3;
            this.MediaPlayerPanel.Visible = false;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(39, 28);
            this.axWindowsMediaPlayer.TabIndex = 1;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WindowsMediaPlayer_PlayStateChange);
            this.axWindowsMediaPlayer.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.WindowsMediaPlayer_MediaChange);
            this.axWindowsMediaPlayer.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.AxWindowsMediaPlayer_DoubleClickEvent);
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserPanel.BackColor = System.Drawing.Color.Transparent;
            this.BrowserPanel.Controls.Add(this.DwnldSttsLabel);
            this.BrowserPanel.Controls.Add(this.DownloadLabel);
            this.BrowserPanel.Controls.Add(this.AudioDwnldBttn);
            this.BrowserPanel.Controls.Add(this.ViewsLabel);
            this.BrowserPanel.Controls.Add(this.VideoDwnldBttn);
            this.BrowserPanel.Controls.Add(this.DescriptionTextBox);
            this.BrowserPanel.Controls.Add(this.UploadDateLabel);
            this.BrowserPanel.Controls.Add(this.TitleTextBox);
            this.BrowserPanel.Controls.Add(this.ThumbnailPicture);
            this.BrowserPanel.Controls.Add(this.LinkTextBox);
            this.BrowserPanel.Controls.Add(this.label1);
            this.BrowserPanel.Location = new System.Drawing.Point(5, 303);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(93, 44);
            this.BrowserPanel.TabIndex = 2;
            this.BrowserPanel.Visible = false;
            // 
            // DwnldSttsLabel
            // 
            this.DwnldSttsLabel.AutoSize = true;
            this.DwnldSttsLabel.Location = new System.Drawing.Point(334, 142);
            this.DwnldSttsLabel.Name = "DwnldSttsLabel";
            this.DwnldSttsLabel.Size = new System.Drawing.Size(117, 13);
            this.DwnldSttsLabel.TabIndex = 13;
            this.DwnldSttsLabel.Text = "Download Status Label";
            // 
            // DownloadLabel
            // 
            this.DownloadLabel.AutoSize = true;
            this.DownloadLabel.Location = new System.Drawing.Point(332, 90);
            this.DownloadLabel.Name = "DownloadLabel";
            this.DownloadLabel.Size = new System.Drawing.Size(58, 13);
            this.DownloadLabel.TabIndex = 12;
            this.DownloadLabel.Text = "Download:";
            this.DownloadLabel.Visible = false;
            // 
            // AudioDwnldBttn
            // 
            this.AudioDwnldBttn.Location = new System.Drawing.Point(507, 106);
            this.AudioDwnldBttn.Name = "AudioDwnldBttn";
            this.AudioDwnldBttn.Size = new System.Drawing.Size(95, 23);
            this.AudioDwnldBttn.TabIndex = 11;
            this.AudioDwnldBttn.Text = "Audio";
            this.AudioDwnldBttn.UseVisualStyleBackColor = true;
            this.AudioDwnldBttn.Visible = false;
            this.AudioDwnldBttn.Click += new System.EventHandler(this.AudioDwnldBttn_Click);
            // 
            // ViewsLabel
            // 
            this.ViewsLabel.AutoSize = true;
            this.ViewsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewsLabel.Location = new System.Drawing.Point(3, 253);
            this.ViewsLabel.Name = "ViewsLabel";
            this.ViewsLabel.Size = new System.Drawing.Size(35, 13);
            this.ViewsLabel.TabIndex = 10;
            this.ViewsLabel.Text = "Views";
            // 
            // VideoDwnldBttn
            // 
            this.VideoDwnldBttn.Location = new System.Drawing.Point(384, 106);
            this.VideoDwnldBttn.Name = "VideoDwnldBttn";
            this.VideoDwnldBttn.Size = new System.Drawing.Size(95, 23);
            this.VideoDwnldBttn.TabIndex = 9;
            this.VideoDwnldBttn.Text = "Video";
            this.VideoDwnldBttn.UseVisualStyleBackColor = true;
            this.VideoDwnldBttn.Visible = false;
            this.VideoDwnldBttn.Click += new System.EventHandler(this.VideoDwnldBttn_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DescriptionTextBox.Location = new System.Drawing.Point(6, 295);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(82, 0);
            this.DescriptionTextBox.TabIndex = 8;
            this.DescriptionTextBox.Text = "Description";
            this.DescriptionTextBox.Visible = false;
            // 
            // UploadDateLabel
            // 
            this.UploadDateLabel.AutoSize = true;
            this.UploadDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadDateLabel.Location = new System.Drawing.Point(3, 266);
            this.UploadDateLabel.Name = "UploadDateLabel";
            this.UploadDateLabel.Size = new System.Drawing.Size(64, 13);
            this.UploadDateLabel.TabIndex = 7;
            this.UploadDateLabel.Text = "UploadDate";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(6, 228);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(82, 22);
            this.TitleTextBox.TabIndex = 6;
            this.TitleTextBox.Text = "Title";
            // 
            // ThumbnailPicture
            // 
            this.ThumbnailPicture.Location = new System.Drawing.Point(6, 42);
            this.ThumbnailPicture.Name = "ThumbnailPicture";
            this.ThumbnailPicture.Size = new System.Drawing.Size(320, 180);
            this.ThumbnailPicture.TabIndex = 3;
            this.ThumbnailPicture.TabStop = false;
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.AllowDrop = true;
            this.LinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LinkTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LinkTextBox.Location = new System.Drawing.Point(151, 2);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(0, 20);
            this.LinkTextBox.TabIndex = 2;
            this.LinkTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LinkTextBox_DragDrop);
            this.LinkTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.LinkTextBox_DragEnter);
            this.LinkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LinkTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Youtube Link or Youtube ID:";
            // 
            // SongsBttn
            // 
            this.SongsBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongsBttn.BackColor = System.Drawing.Color.Transparent;
            this.SongsBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.SongsBttn.FlatAppearance.BorderSize = 0;
            this.SongsBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SongsBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SongsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongsBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SongsBttn.Location = new System.Drawing.Point(6, 37);
            this.SongsBttn.Name = "SongsBttn";
            this.SongsBttn.Size = new System.Drawing.Size(123, 29);
            this.SongsBttn.TabIndex = 1;
            this.SongsBttn.Text = "Downloaded media";
            this.SongsBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SongsBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SongsBttn.UseVisualStyleBackColor = false;
            this.SongsBttn.Click += new System.EventHandler(this.SongsBttn_Click);
            this.SongsBttn.MouseEnter += new System.EventHandler(this.SongsBttn_MouseEnter);
            this.SongsBttn.MouseLeave += new System.EventHandler(this.SongsBttn_MouseLeave);
            // 
            // BrowseBttn
            // 
            this.BrowseBttn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBttn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BrowseBttn.FlatAppearance.BorderSize = 0;
            this.BrowseBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBttn.Location = new System.Drawing.Point(6, 66);
            this.BrowseBttn.Name = "BrowseBttn";
            this.BrowseBttn.Size = new System.Drawing.Size(123, 26);
            this.BrowseBttn.TabIndex = 2;
            this.BrowseBttn.Text = "Browse";
            this.BrowseBttn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BrowseBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BrowseBttn.UseVisualStyleBackColor = false;
            this.BrowseBttn.Click += new System.EventHandler(this.BrowseBttn_Click);
            this.BrowseBttn.MouseEnter += new System.EventHandler(this.Button2_MouseEnter);
            this.BrowseBttn.MouseLeave += new System.EventHandler(this.Button2_MouseLeave);
            // 
            // PanelGroupBox
            // 
            this.PanelGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PanelGroupBox.Controls.Add(this.MediaPlayerBttn);
            this.PanelGroupBox.Controls.Add(this.SettingsBttn);
            this.PanelGroupBox.Controls.Add(this.SongsBttn);
            this.PanelGroupBox.Location = new System.Drawing.Point(-1, -7);
            this.PanelGroupBox.Name = "PanelGroupBox";
            this.PanelGroupBox.Size = new System.Drawing.Size(135, 132);
            this.PanelGroupBox.TabIndex = 0;
            this.PanelGroupBox.TabStop = false;
            // 
            // MediaPlayerBttn
            // 
            this.MediaPlayerBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaPlayerBttn.BackColor = System.Drawing.Color.Transparent;
            this.MediaPlayerBttn.FlatAppearance.BorderSize = 0;
            this.MediaPlayerBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MediaPlayerBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MediaPlayerBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaPlayerBttn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MediaPlayerBttn.Location = new System.Drawing.Point(6, 8);
            this.MediaPlayerBttn.Name = "MediaPlayerBttn";
            this.MediaPlayerBttn.Size = new System.Drawing.Size(123, 29);
            this.MediaPlayerBttn.TabIndex = 0;
            this.MediaPlayerBttn.Text = "Media Player";
            this.MediaPlayerBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MediaPlayerBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MediaPlayerBttn.UseVisualStyleBackColor = false;
            this.MediaPlayerBttn.Click += new System.EventHandler(this.MediaPlayerBttn_Click);
            this.MediaPlayerBttn.MouseEnter += new System.EventHandler(this.MediaPlayerBttn_MouseEnter);
            this.MediaPlayerBttn.MouseLeave += new System.EventHandler(this.MediaPlayerBttn_MouseLeave);
            // 
            // SettingsBttn
            // 
            this.SettingsBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsBttn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBttn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.SettingsBttn.FlatAppearance.BorderSize = 0;
            this.SettingsBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingsBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBttn.Location = new System.Drawing.Point(6, 99);
            this.SettingsBttn.Name = "SettingsBttn";
            this.SettingsBttn.Size = new System.Drawing.Size(123, 28);
            this.SettingsBttn.TabIndex = 3;
            this.SettingsBttn.Text = "Settings";
            this.SettingsBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBttn.UseVisualStyleBackColor = false;
            this.SettingsBttn.Click += new System.EventHandler(this.SettingsBttn_Click);
            this.SettingsBttn.MouseEnter += new System.EventHandler(this.SettingsBttn_MouseEnter);
            this.SettingsBttn.MouseLeave += new System.EventHandler(this.SettingsBttn_MouseLeave);
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingPanel.Controls.Add(this.LoadImage);
            this.LoadingPanel.Location = new System.Drawing.Point(57, 269);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(41, 36);
            this.LoadingPanel.TabIndex = 3;
            // 
            // LoadImage
            // 
            this.LoadImage.BackColor = System.Drawing.Color.Transparent;
            this.LoadImage.BackgroundImage = global::Spotifly.Properties.Resources.SpotiflyIcon;
            this.LoadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoadImage.InitialImage = null;
            this.LoadImage.Location = new System.Drawing.Point(214, 138);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(191, 148);
            this.LoadImage.TabIndex = 0;
            this.LoadImage.TabStop = false;
            // 
            // YoutubeBrowserPanel
            // 
            this.YoutubeBrowserPanel.Location = new System.Drawing.Point(141, 12);
            this.YoutubeBrowserPanel.Name = "YoutubeBrowserPanel";
            this.YoutubeBrowserPanel.Size = new System.Drawing.Size(740, 418);
            this.YoutubeBrowserPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(906, 508);
            this.Controls.Add(this.YoutubeBrowserPanel);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.BrowseBttn);
            this.Controls.Add(this.MediaPlayerPanel);
            this.Controls.Add(this.PanelGroupBox);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.DownloadedMediaPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.BrowserPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(922, 547);
            this.Name = "Form1";
            this.Text = "Spotifly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElapsedTimeBarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.DownloadedMediaPanel.ResumeLayout(false);
            this.DownloadedMediaPanel.PerformLayout();
            this.MediaPlayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.BrowserPanel.ResumeLayout(false);
            this.BrowserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailPicture)).EndInit();
            this.PanelGroupBox.ResumeLayout(false);
            this.LoadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ControlPanel;
        private System.Windows.Forms.Button PlayBttn;
        private System.Windows.Forms.Button SongsBttn;
        private System.Windows.Forms.Button BrowseBttn;
        private System.Windows.Forms.Panel BrowserPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PanelGroupBox;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.PictureBox ThumbnailPicture;
        private System.Windows.Forms.Button SettingsBttn;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label UploadDateLabel;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Button VideoDwnldBttn;
        private System.Windows.Forms.Label ViewsLabel;
        private System.Windows.Forms.Label DownloadLabel;
        private System.Windows.Forms.Button AudioDwnldBttn;
        private System.Windows.Forms.Label DwnldSttsLabel;
        private System.Windows.Forms.Panel DownloadedMediaPanel;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Button MediaPlayerBttn;
        private System.Windows.Forms.ListView MediaListView;
        private System.Windows.Forms.Panel MediaPlayerPanel;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.Label MediaLengthLabel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button FullScreenBttn;
        private System.Windows.Forms.Button NextMediaBttn;
        private System.Windows.Forms.Button PrevMediaBttn;
        private System.Windows.Forms.Button AboutBttn;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Button BackBttn;
        private System.Windows.Forms.RichTextBox CurrentMediaTxtBox;
        private System.Windows.Forms.Button ShuffleBttn;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.PictureBox LoadImage;
        private System.Windows.Forms.CheckBox ResizeForMediaCheckBox;
        private System.Windows.Forms.PictureBox ElapsedTimeBarPictureBox;
        private System.Windows.Forms.ComboBox ThemeSelectionComboBox;
        private System.Windows.Forms.Panel YoutubeBrowserPanel;
    }
}

