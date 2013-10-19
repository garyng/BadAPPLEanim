namespace BadApple
{
    partial class frmSetup
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
			this.rbWindowed = new System.Windows.Forms.RadioButton();
			this.rbLayered = new System.Windows.Forms.RadioButton();
			this.lblWinMode = new System.Windows.Forms.Label();
			this.cbOnTop = new System.Windows.Forms.CheckBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cbBitBlt = new System.Windows.Forms.CheckBox();
			this.cbTransBack = new System.Windows.Forms.CheckBox();
			this.cbFullScr = new System.Windows.Forms.CheckBox();
			this.cbShowTskBar = new System.Windows.Forms.CheckBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lnkBrowse = new System.Windows.Forms.LinkLabel();
			this.lnkTest = new System.Windows.Forms.LinkLabel();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtSSP = new System.Windows.Forms.TextBox();
			this.lnkSSP = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBGM = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rbWindowed
			// 
			this.rbWindowed.AutoSize = true;
			this.rbWindowed.BackColor = System.Drawing.Color.Transparent;
			this.rbWindowed.Checked = true;
			this.rbWindowed.ForeColor = System.Drawing.Color.White;
			this.rbWindowed.Location = new System.Drawing.Point(215, 129);
			this.rbWindowed.Name = "rbWindowed";
			this.rbWindowed.Size = new System.Drawing.Size(82, 17);
			this.rbWindowed.TabIndex = 0;
			this.rbWindowed.TabStop = true;
			this.rbWindowed.Text = "Windowed";
			this.rbWindowed.UseVisualStyleBackColor = false;
			this.rbWindowed.CheckedChanged += new System.EventHandler(this.rbWindowed_CheckedChanged);
			// 
			// rbLayered
			// 
			this.rbLayered.AutoSize = true;
			this.rbLayered.BackColor = System.Drawing.Color.Transparent;
			this.rbLayered.ForeColor = System.Drawing.Color.White;
			this.rbLayered.Location = new System.Drawing.Point(233, 152);
			this.rbLayered.Name = "rbLayered";
			this.rbLayered.Size = new System.Drawing.Size(64, 17);
			this.rbLayered.TabIndex = 1;
			this.rbLayered.Text = "Layered";
			this.rbLayered.UseVisualStyleBackColor = false;
			this.rbLayered.CheckedChanged += new System.EventHandler(this.rbLayered_CheckedChanged);
			// 
			// lblWinMode
			// 
			this.lblWinMode.AutoSize = true;
			this.lblWinMode.BackColor = System.Drawing.Color.Transparent;
			this.lblWinMode.ForeColor = System.Drawing.Color.White;
			this.lblWinMode.Location = new System.Drawing.Point(199, 103);
			this.lblWinMode.Name = "lblWinMode";
			this.lblWinMode.Size = new System.Drawing.Size(98, 13);
			this.lblWinMode.TabIndex = 2;
			this.lblWinMode.Text = "- Window Mode -";
			// 
			// cbOnTop
			// 
			this.cbOnTop.AutoSize = true;
			this.cbOnTop.BackColor = System.Drawing.Color.Transparent;
			this.cbOnTop.ForeColor = System.Drawing.Color.White;
			this.cbOnTop.Location = new System.Drawing.Point(195, 189);
			this.cbOnTop.Name = "cbOnTop";
			this.cbOnTop.Size = new System.Drawing.Size(102, 17);
			this.cbOnTop.TabIndex = 3;
			this.cbOnTop.Text = "Always On Top";
			this.cbOnTop.UseVisualStyleBackColor = false;
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.ForeColor = System.Drawing.Color.Black;
			this.Label3.Location = new System.Drawing.Point(311, 12);
			this.Label3.Margin = new System.Windows.Forms.Padding(3);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(171, 15);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "a remade from MaiSoft (2013)...";
			// 
			// cbBitBlt
			// 
			this.cbBitBlt.AutoSize = true;
			this.cbBitBlt.BackColor = System.Drawing.Color.Transparent;
			this.cbBitBlt.ForeColor = System.Drawing.Color.Black;
			this.cbBitBlt.Location = new System.Drawing.Point(314, 130);
			this.cbBitBlt.Name = "cbBitBlt";
			this.cbBitBlt.Size = new System.Drawing.Size(177, 17);
			this.cbBitBlt.TabIndex = 9;
			this.cbBitBlt.Text = "Use BitBlt (faster on some PC)";
			this.cbBitBlt.UseVisualStyleBackColor = false;
			// 
			// cbTransBack
			// 
			this.cbTransBack.AutoSize = true;
			this.cbTransBack.BackColor = System.Drawing.Color.Transparent;
			this.cbTransBack.Enabled = false;
			this.cbTransBack.ForeColor = System.Drawing.Color.Black;
			this.cbTransBack.Location = new System.Drawing.Point(314, 152);
			this.cbTransBack.Name = "cbTransBack";
			this.cbTransBack.Size = new System.Drawing.Size(153, 17);
			this.cbTransBack.TabIndex = 10;
			this.cbTransBack.Text = "Transparent Background";
			this.cbTransBack.UseVisualStyleBackColor = false;
			// 
			// cbFullScr
			// 
			this.cbFullScr.AutoSize = true;
			this.cbFullScr.BackColor = System.Drawing.Color.Transparent;
			this.cbFullScr.Enabled = false;
			this.cbFullScr.ForeColor = System.Drawing.Color.Black;
			this.cbFullScr.Location = new System.Drawing.Point(314, 175);
			this.cbFullScr.Name = "cbFullScr";
			this.cbFullScr.Size = new System.Drawing.Size(78, 17);
			this.cbFullScr.TabIndex = 11;
			this.cbFullScr.Text = "Fullscreen";
			this.cbFullScr.UseVisualStyleBackColor = false;
			this.cbFullScr.CheckedChanged += new System.EventHandler(this.cbFullScr_CheckedChanged);
			// 
			// cbShowTskBar
			// 
			this.cbShowTskBar.AutoSize = true;
			this.cbShowTskBar.BackColor = System.Drawing.Color.Transparent;
			this.cbShowTskBar.Enabled = false;
			this.cbShowTskBar.ForeColor = System.Drawing.Color.Black;
			this.cbShowTskBar.Location = new System.Drawing.Point(328, 198);
			this.cbShowTskBar.Name = "cbShowTskBar";
			this.cbShowTskBar.Size = new System.Drawing.Size(116, 17);
			this.cbShowTskBar.TabIndex = 12;
			this.cbShowTskBar.Text = "but show taskbar";
			this.cbShowTskBar.UseVisualStyleBackColor = false;
			// 
			// txtPath
			// 
			this.txtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txtPath.BackColor = System.Drawing.Color.Black;
			this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPath.ForeColor = System.Drawing.Color.White;
			this.txtPath.Location = new System.Drawing.Point(162, 296);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(135, 22);
			this.txtPath.TabIndex = 13;
			this.txtPath.Text = "\\ba.mp3";
			// 
			// lnkBrowse
			// 
			this.lnkBrowse.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkBrowse.AutoSize = true;
			this.lnkBrowse.BackColor = System.Drawing.Color.Transparent;
			this.lnkBrowse.Location = new System.Drawing.Point(311, 298);
			this.lnkBrowse.Name = "lnkBrowse";
			this.lnkBrowse.Size = new System.Drawing.Size(45, 13);
			this.lnkBrowse.TabIndex = 15;
			this.lnkBrowse.TabStop = true;
			this.lnkBrowse.Text = "Browse";
			this.lnkBrowse.VisitedLinkColor = System.Drawing.Color.Black;
			this.lnkBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBrowse_LinkClicked);
			// 
			// lnkTest
			// 
			this.lnkTest.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkTest.AutoSize = true;
			this.lnkTest.BackColor = System.Drawing.Color.Transparent;
			this.lnkTest.Location = new System.Drawing.Point(375, 298);
			this.lnkTest.Name = "lnkTest";
			this.lnkTest.Size = new System.Drawing.Size(27, 13);
			this.lnkTest.TabIndex = 16;
			this.lnkTest.TabStop = true;
			this.lnkTest.Text = "Test";
			this.lnkTest.VisitedLinkColor = System.Drawing.Color.Black;
			this.lnkTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTest_LinkClicked);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(262, 390);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 17;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtSSP
			// 
			this.txtSSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txtSSP.BackColor = System.Drawing.Color.Black;
			this.txtSSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSSP.ForeColor = System.Drawing.Color.White;
			this.txtSSP.Location = new System.Drawing.Point(162, 324);
			this.txtSSP.Name = "txtSSP";
			this.txtSSP.Size = new System.Drawing.Size(135, 22);
			this.txtSSP.TabIndex = 18;
			this.txtSSP.Text = "\\ba.ssp";
			// 
			// lnkSSP
			// 
			this.lnkSSP.ActiveLinkColor = System.Drawing.Color.Blue;
			this.lnkSSP.AutoSize = true;
			this.lnkSSP.BackColor = System.Drawing.Color.Transparent;
			this.lnkSSP.Location = new System.Drawing.Point(311, 326);
			this.lnkSSP.Name = "lnkSSP";
			this.lnkSSP.Size = new System.Drawing.Size(45, 13);
			this.lnkSSP.TabIndex = 19;
			this.lnkSSP.TabStop = true;
			this.lnkSSP.Text = "Browse";
			this.lnkSSP.VisitedLinkColor = System.Drawing.Color.Black;
			this.lnkSSP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSSP_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(110, 298);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "- BGM -";
			// 
			// lblBGM
			// 
			this.lblBGM.AutoSize = true;
			this.lblBGM.BackColor = System.Drawing.Color.Transparent;
			this.lblBGM.ForeColor = System.Drawing.Color.White;
			this.lblBGM.Location = new System.Drawing.Point(114, 326);
			this.lblBGM.Name = "lblBGM";
			this.lblBGM.Size = new System.Drawing.Size(39, 13);
			this.lblBGM.TabIndex = 21;
			this.lblBGM.Text = "- SSP -";
			// 
			// frmSetup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BadApple.Properties.Resources.BadApple_Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(593, 450);
			this.Controls.Add(this.lblBGM);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lnkSSP);
			this.Controls.Add(this.txtSSP);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lnkTest);
			this.Controls.Add(this.lnkBrowse);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.cbShowTskBar);
			this.Controls.Add(this.cbFullScr);
			this.Controls.Add(this.cbTransBack);
			this.Controls.Add(this.cbBitBlt);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.cbOnTop);
			this.Controls.Add(this.lblWinMode);
			this.Controls.Add(this.rbLayered);
			this.Controls.Add(this.rbWindowed);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSetup";
			this.Text = "Bad Apple Setup";
			this.Load += new System.EventHandler(this.frmSetup_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbWindowed;
        private System.Windows.Forms.RadioButton rbLayered;
        private System.Windows.Forms.Label lblWinMode;
        private System.Windows.Forms.CheckBox cbOnTop;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox cbBitBlt;
        private System.Windows.Forms.CheckBox cbTransBack;
        private System.Windows.Forms.CheckBox cbFullScr;
        private System.Windows.Forms.CheckBox cbShowTskBar;
		private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.LinkLabel lnkBrowse;
        private System.Windows.Forms.LinkLabel lnkTest;
        private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtSSP;
		private System.Windows.Forms.LinkLabel lnkSSP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBGM;
    }
}

