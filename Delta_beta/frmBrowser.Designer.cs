namespace Delta_beta
{
    partial class frmBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.webViewContainer = new System.Windows.Forms.Panel();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.weakBlockRadio = new System.Windows.Forms.RadioButton();
            this.strongBlockRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.borderPanel = new System.Windows.Forms.Panel();
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassiBtn = new System.Windows.Forms.Button();
            this.YouTubeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addressBar = new System.Windows.Forms.RichTextBox();
            this.starBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.anonymousBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tipBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.webViewContainer.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webViewContainer
            // 
            this.webViewContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webViewContainer.Controls.Add(this.settingPanel);
            this.webViewContainer.Location = new System.Drawing.Point(0, 69);
            this.webViewContainer.Name = "webViewContainer";
            this.webViewContainer.Size = new System.Drawing.Size(988, 453);
            this.webViewContainer.TabIndex = 0;
            // 
            // settingPanel
            // 
            this.settingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settingPanel.Controls.Add(this.groupBox1);
            this.settingPanel.Controls.Add(this.label1);
            this.settingPanel.Location = new System.Drawing.Point(760, 6);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(200, 435);
            this.settingPanel.TabIndex = 1;
            this.settingPanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.weakBlockRadio);
            this.groupBox1.Controls.Add(this.strongBlockRadio);
            this.groupBox1.Location = new System.Drawing.Point(14, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(121, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "無";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.adfreeCheckedChanged);
            // 
            // weakBlockRadio
            // 
            this.weakBlockRadio.AutoSize = true;
            this.weakBlockRadio.Location = new System.Drawing.Point(75, 0);
            this.weakBlockRadio.Name = "weakBlockRadio";
            this.weakBlockRadio.Size = new System.Drawing.Size(35, 16);
            this.weakBlockRadio.TabIndex = 1;
            this.weakBlockRadio.Text = "弱";
            this.weakBlockRadio.UseVisualStyleBackColor = true;
            this.weakBlockRadio.CheckedChanged += new System.EventHandler(this.adfreeCheckedChanged);
            // 
            // strongBlockRadio
            // 
            this.strongBlockRadio.AutoSize = true;
            this.strongBlockRadio.Checked = true;
            this.strongBlockRadio.Location = new System.Drawing.Point(14, 0);
            this.strongBlockRadio.Name = "strongBlockRadio";
            this.strongBlockRadio.Size = new System.Drawing.Size(35, 16);
            this.strongBlockRadio.TabIndex = 0;
            this.strongBlockRadio.TabStop = true;
            this.strongBlockRadio.Text = "強";
            this.strongBlockRadio.UseVisualStyleBackColor = true;
            this.strongBlockRadio.CheckedChanged += new System.EventHandler(this.adfreeCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "広告ブロッカーの強さ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // borderPanel
            // 
            this.borderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.borderPanel.Location = new System.Drawing.Point(153, 8);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(638, 24);
            this.borderPanel.TabIndex = 6;
            this.borderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.borderPanel_Paint);
            // 
            // testBox
            // 
            this.testBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.testBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.testBox.Location = new System.Drawing.Point(797, 7);
            this.testBox.Multiline = false;
            this.testBox.Name = "testBox";
            this.testBox.ReadOnly = true;
            this.testBox.Size = new System.Drawing.Size(56, 24);
            this.testBox.TabIndex = 7;
            this.testBox.Text = "";
            this.testBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ClassiBtn);
            this.panel1.Controls.Add(this.YouTubeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 32);
            this.panel1.TabIndex = 0;
            // 
            // ClassiBtn
            // 
            this.ClassiBtn.Location = new System.Drawing.Point(99, 5);
            this.ClassiBtn.Name = "ClassiBtn";
            this.ClassiBtn.Size = new System.Drawing.Size(75, 24);
            this.ClassiBtn.TabIndex = 2;
            this.ClassiBtn.Text = "Classi";
            this.ClassiBtn.UseVisualStyleBackColor = true;
            this.ClassiBtn.Click += new System.EventHandler(this.ClassiBtn_Click);
            // 
            // YouTubeBtn
            // 
            this.YouTubeBtn.Image = global::Delta_beta.Properties.Resources.YouTube_icon;
            this.YouTubeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YouTubeBtn.Location = new System.Drawing.Point(12, 5);
            this.YouTubeBtn.Name = "YouTubeBtn";
            this.YouTubeBtn.Size = new System.Drawing.Size(80, 24);
            this.YouTubeBtn.TabIndex = 0;
            this.YouTubeBtn.Text = "YouTube";
            this.YouTubeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YouTubeBtn.UseVisualStyleBackColor = true;
            this.YouTubeBtn.Click += new System.EventHandler(this.YouTubeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.addressBar);
            this.panel3.Controls.Add(this.starBtn);
            this.panel3.Controls.Add(this.downloadBtn);
            this.panel3.Controls.Add(this.anonymousBtn);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(153, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 24);
            this.panel3.TabIndex = 4;
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBar.DetectUrls = false;
            this.addressBar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F);
            this.addressBar.Location = new System.Drawing.Point(43, 3);
            this.addressBar.Multiline = false;
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(505, 22);
            this.addressBar.TabIndex = 2;
            this.addressBar.Text = "";
            this.addressBar.Click += new System.EventHandler(this.addressBar_Click);
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // starBtn
            // 
            this.starBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.starBtn.FlatAppearance.BorderSize = 0;
            this.starBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.starBtn.Image = global::Delta_beta.Properties.Resources.star;
            this.starBtn.Location = new System.Drawing.Point(614, 3);
            this.starBtn.Name = "starBtn";
            this.starBtn.Size = new System.Drawing.Size(23, 23);
            this.starBtn.TabIndex = 4;
            this.starBtn.UseVisualStyleBackColor = true;
            this.starBtn.Click += new System.EventHandler(this.starBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBtn.Enabled = false;
            this.downloadBtn.FlatAppearance.BorderSize = 0;
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.Image = global::Delta_beta.Properties.Resources.download__5_;
            this.downloadBtn.Location = new System.Drawing.Point(585, 3);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(23, 23);
            this.downloadBtn.TabIndex = 3;
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Visible = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // anonymousBtn
            // 
            this.anonymousBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anonymousBtn.Enabled = false;
            this.anonymousBtn.FlatAppearance.BorderSize = 0;
            this.anonymousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anonymousBtn.Image = global::Delta_beta.Properties.Resources.invisible;
            this.anonymousBtn.Location = new System.Drawing.Point(554, 3);
            this.anonymousBtn.Name = "anonymousBtn";
            this.anonymousBtn.Size = new System.Drawing.Size(23, 23);
            this.anonymousBtn.TabIndex = 2;
            this.anonymousBtn.UseVisualStyleBackColor = true;
            this.anonymousBtn.Visible = false;
            this.anonymousBtn.Click += new System.EventHandler(this.anonymousBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Delta_beta.Properties.Resources.カギアイコン__2_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.testBox);
            this.panel2.Controls.Add(this.borderPanel);
            this.panel2.Controls.Add(this.tipBtn);
            this.panel2.Controls.Add(this.settingBtn);
            this.panel2.Controls.Add(this.reloadBtn);
            this.panel2.Controls.Add(this.forwardBtn);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 69);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Delta_beta.Properties.Resources.key__1_;
            this.button1.Location = new System.Drawing.Point(876, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipBtn
            // 
            this.tipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tipBtn.Enabled = false;
            this.tipBtn.FlatAppearance.BorderSize = 0;
            this.tipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipBtn.Image = global::Delta_beta.Properties.Resources.money;
            this.tipBtn.Location = new System.Drawing.Point(906, 7);
            this.tipBtn.Name = "tipBtn";
            this.tipBtn.Size = new System.Drawing.Size(24, 24);
            this.tipBtn.TabIndex = 0;
            this.tipBtn.UseVisualStyleBackColor = true;
            this.tipBtn.Visible = false;
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Image = global::Delta_beta.Properties.Resources.settings;
            this.settingBtn.Location = new System.Drawing.Point(936, 7);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(24, 24);
            this.settingBtn.TabIndex = 5;
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Image = global::Delta_beta.Properties.Resources.btn_toolbar_reload;
            this.reloadBtn.Location = new System.Drawing.Point(93, 8);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(24, 24);
            this.reloadBtn.TabIndex = 3;
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            this.forwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardBtn.Image = global::Delta_beta.Properties.Resources.btn_right;
            this.forwardBtn.Location = new System.Drawing.Point(52, 8);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(24, 24);
            this.forwardBtn.TabIndex = 2;
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = global::Delta_beta.Properties.Resources.btn_left;
            this.backBtn.Location = new System.Drawing.Point(12, 8);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(24, 24);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(988, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.webViewContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmBrowser";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            this.webViewContainer.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel webViewContainer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.RichTextBox testBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button YouTubeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button starBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button anonymousBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tipBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton weakBlockRadio;
        private System.Windows.Forms.RadioButton strongBlockRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClassiBtn;
        private System.Windows.Forms.RichTextBox addressBar;
    }
}