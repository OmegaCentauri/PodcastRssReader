namespace PodcastRssReader
{
    partial class FormAdd
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPodcastPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGetPodcastInfo = new System.Windows.Forms.ProgressBar();
            this.txtPodcastSummary = new System.Windows.Forms.TextBox();
            this.lblPodcastSummary = new System.Windows.Forms.Label();
            this.btnSavePodcast = new System.Windows.Forms.Button();
            this.txtPodcastTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRSS = new System.Windows.Forms.Button();
            this.txtRSSURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bgwGetPodcast = new System.ComponentModel.BackgroundWorker();
            this.lbPodcasts = new System.Windows.Forms.ListBox();
            this.lblPodcasts = new System.Windows.Forms.Label();
            this.fbdPodcastPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnBrowse);
            this.gbAdd.Controls.Add(this.txtPodcastPath);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.pbGetPodcastInfo);
            this.gbAdd.Controls.Add(this.txtPodcastSummary);
            this.gbAdd.Controls.Add(this.lblPodcastSummary);
            this.gbAdd.Controls.Add(this.btnSavePodcast);
            this.gbAdd.Controls.Add(this.txtPodcastTitle);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Controls.Add(this.btnAddRSS);
            this.gbAdd.Controls.Add(this.txtRSSURL);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Location = new System.Drawing.Point(12, 27);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(1214, 212);
            this.gbAdd.TabIndex = 9;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add RSS Feed:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1107, 66);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtPodcastPath
            // 
            this.txtPodcastPath.Location = new System.Drawing.Point(616, 66);
            this.txtPodcastPath.Name = "txtPodcastPath";
            this.txtPodcastPath.Size = new System.Drawing.Size(485, 20);
            this.txtPodcastPath.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Path:";
            // 
            // pbGetPodcastInfo
            // 
            this.pbGetPodcastInfo.Location = new System.Drawing.Point(1105, 26);
            this.pbGetPodcastInfo.Name = "pbGetPodcastInfo";
            this.pbGetPodcastInfo.Size = new System.Drawing.Size(100, 23);
            this.pbGetPodcastInfo.TabIndex = 8;
            this.pbGetPodcastInfo.Visible = false;
            // 
            // txtPodcastSummary
            // 
            this.txtPodcastSummary.Location = new System.Drawing.Point(116, 93);
            this.txtPodcastSummary.Multiline = true;
            this.txtPodcastSummary.Name = "txtPodcastSummary";
            this.txtPodcastSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPodcastSummary.Size = new System.Drawing.Size(439, 105);
            this.txtPodcastSummary.TabIndex = 7;
            // 
            // lblPodcastSummary
            // 
            this.lblPodcastSummary.AutoSize = true;
            this.lblPodcastSummary.Location = new System.Drawing.Point(14, 93);
            this.lblPodcastSummary.Name = "lblPodcastSummary";
            this.lblPodcastSummary.Size = new System.Drawing.Size(95, 13);
            this.lblPodcastSummary.TabIndex = 6;
            this.lblPodcastSummary.Text = "Podcast Summary:";
            // 
            // btnSavePodcast
            // 
            this.btnSavePodcast.Enabled = false;
            this.btnSavePodcast.Location = new System.Drawing.Point(577, 175);
            this.btnSavePodcast.Name = "btnSavePodcast";
            this.btnSavePodcast.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSavePodcast.Size = new System.Drawing.Size(75, 23);
            this.btnSavePodcast.TabIndex = 5;
            this.btnSavePodcast.Text = "Save";
            this.btnSavePodcast.UseVisualStyleBackColor = true;
            this.btnSavePodcast.Click += new System.EventHandler(this.btnSavePodcast_Click);
            // 
            // txtPodcastTitle
            // 
            this.txtPodcastTitle.Location = new System.Drawing.Point(115, 63);
            this.txtPodcastTitle.Name = "txtPodcastTitle";
            this.txtPodcastTitle.Size = new System.Drawing.Size(453, 20);
            this.txtPodcastTitle.TabIndex = 4;
            this.txtPodcastTitle.Text = "Enter a URL above and click Add";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Podcast Title:";
            // 
            // btnAddRSS
            // 
            this.btnAddRSS.Location = new System.Drawing.Point(1023, 27);
            this.btnAddRSS.Name = "btnAddRSS";
            this.btnAddRSS.Size = new System.Drawing.Size(75, 23);
            this.btnAddRSS.TabIndex = 2;
            this.btnAddRSS.Text = "Add";
            this.btnAddRSS.UseVisualStyleBackColor = true;
            this.btnAddRSS.Click += new System.EventHandler(this.btnAddRSS_Click);
            // 
            // txtRSSURL
            // 
            this.txtRSSURL.Location = new System.Drawing.Point(76, 29);
            this.txtRSSURL.Name = "txtRSSURL";
            this.txtRSSURL.Size = new System.Drawing.Size(941, 20);
            this.txtRSSURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "RSS URL:";
            // 
            // bgwGetPodcast
            // 
            this.bgwGetPodcast.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetPodcast_DoWork);
            this.bgwGetPodcast.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwGetPodcast_ProgressChanged);
            this.bgwGetPodcast.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetPodcast_RunWorkerCompleted);
            // 
            // lbPodcasts
            // 
            this.lbPodcasts.FormattingEnabled = true;
            this.lbPodcasts.Location = new System.Drawing.Point(12, 272);
            this.lbPodcasts.Name = "lbPodcasts";
            this.lbPodcasts.Size = new System.Drawing.Size(271, 147);
            this.lbPodcasts.TabIndex = 11;
            // 
            // lblPodcasts
            // 
            this.lblPodcasts.AutoSize = true;
            this.lblPodcasts.Location = new System.Drawing.Point(9, 256);
            this.lblPodcasts.Name = "lblPodcasts";
            this.lblPodcasts.Size = new System.Drawing.Size(54, 13);
            this.lblPodcasts.TabIndex = 12;
            this.lblPodcasts.Text = "Podcasts:";
            // 
            // fbdPodcastPath
            // 
            this.fbdPodcastPath.SelectedPath = "T:\\Music";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 602);
            this.Controls.Add(this.lblPodcasts);
            this.Controls.Add(this.lbPodcasts);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPodcastPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbGetPodcastInfo;
        private System.Windows.Forms.TextBox txtPodcastSummary;
        private System.Windows.Forms.Label lblPodcastSummary;
        private System.Windows.Forms.Button btnSavePodcast;
        private System.Windows.Forms.TextBox txtPodcastTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRSS;
        private System.Windows.Forms.TextBox txtRSSURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgwGetPodcast;
        private System.Windows.Forms.ListBox lbPodcasts;
        private System.Windows.Forms.Label lblPodcasts;
        private System.Windows.Forms.FolderBrowserDialog fbdPodcastPath;
    }
}