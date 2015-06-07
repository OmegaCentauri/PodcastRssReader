namespace PodcastRssReader
{
    partial class DownloadPodcast
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblEpisodes = new System.Windows.Forms.Label();
            this.clbEpisodes = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbGetEpisodes = new System.Windows.Forms.ProgressBar();
            this.txtPodcastSelectedSummary = new System.Windows.Forms.TextBox();
            this.btnGetEpisodes = new System.Windows.Forms.Button();
            this.lbPodcasts = new System.Windows.Forms.ListBox();
            this.bgwGetEpisodes = new System.ComponentModel.BackgroundWorker();
            this.lblDownloadProgress = new System.Windows.Forms.Label();
            this.lbDownloadList = new System.Windows.Forms.ListBox();
            this.txtEpisodeInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(621, 321);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Location = new System.Drawing.Point(621, 25);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(53, 13);
            this.lblEpisodes.TabIndex = 10;
            this.lblEpisodes.Text = "Episodes:";
            // 
            // clbEpisodes
            // 
            this.clbEpisodes.CheckOnClick = true;
            this.clbEpisodes.FormattingEnabled = true;
            this.clbEpisodes.Location = new System.Drawing.Point(621, 41);
            this.clbEpisodes.Name = "clbEpisodes";
            this.clbEpisodes.Size = new System.Drawing.Size(587, 274);
            this.clbEpisodes.TabIndex = 8;
            this.clbEpisodes.SelectedIndexChanged += new System.EventHandler(this.clbEpisodes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbGetEpisodes);
            this.groupBox1.Controls.Add(this.txtPodcastSelectedSummary);
            this.groupBox1.Controls.Add(this.btnGetEpisodes);
            this.groupBox1.Controls.Add(this.lbPodcasts);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podcasts:";
            // 
            // pbGetEpisodes
            // 
            this.pbGetEpisodes.Location = new System.Drawing.Point(394, 19);
            this.pbGetEpisodes.Name = "pbGetEpisodes";
            this.pbGetEpisodes.Size = new System.Drawing.Size(100, 23);
            this.pbGetEpisodes.TabIndex = 3;
            // 
            // txtPodcastSelectedSummary
            // 
            this.txtPodcastSelectedSummary.Location = new System.Drawing.Point(293, 49);
            this.txtPodcastSelectedSummary.Multiline = true;
            this.txtPodcastSelectedSummary.Name = "txtPodcastSelectedSummary";
            this.txtPodcastSelectedSummary.ReadOnly = true;
            this.txtPodcastSelectedSummary.Size = new System.Drawing.Size(307, 117);
            this.txtPodcastSelectedSummary.TabIndex = 2;
            // 
            // btnGetEpisodes
            // 
            this.btnGetEpisodes.Location = new System.Drawing.Point(293, 19);
            this.btnGetEpisodes.Name = "btnGetEpisodes";
            this.btnGetEpisodes.Size = new System.Drawing.Size(91, 23);
            this.btnGetEpisodes.TabIndex = 1;
            this.btnGetEpisodes.Text = "Get Episodes >";
            this.btnGetEpisodes.UseVisualStyleBackColor = true;
            this.btnGetEpisodes.Click += new System.EventHandler(this.btnGetEpisodes_Click);
            // 
            // lbPodcasts
            // 
            this.lbPodcasts.FormattingEnabled = true;
            this.lbPodcasts.Location = new System.Drawing.Point(15, 19);
            this.lbPodcasts.Name = "lbPodcasts";
            this.lbPodcasts.Size = new System.Drawing.Size(271, 147);
            this.lbPodcasts.TabIndex = 0;
            // 
            // bgwGetEpisodes
            // 
            this.bgwGetEpisodes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetEpisodes_DoWork);
            this.bgwGetEpisodes.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwGetEpisodes_ProgressChanged);
            this.bgwGetEpisodes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetEpisodes_RunWorkerCompleted);
            // 
            // lblDownloadProgress
            // 
            this.lblDownloadProgress.AutoSize = true;
            this.lblDownloadProgress.Location = new System.Drawing.Point(711, 326);
            this.lblDownloadProgress.Name = "lblDownloadProgress";
            this.lblDownloadProgress.Size = new System.Drawing.Size(35, 13);
            this.lblDownloadProgress.TabIndex = 13;
            this.lblDownloadProgress.Text = "label1";
            // 
            // lbDownloadList
            // 
            this.lbDownloadList.FormattingEnabled = true;
            this.lbDownloadList.Location = new System.Drawing.Point(3, 371);
            this.lbDownloadList.Name = "lbDownloadList";
            this.lbDownloadList.Size = new System.Drawing.Size(1205, 147);
            this.lbDownloadList.TabIndex = 14;
            // 
            // txtEpisodeInfo
            // 
            this.txtEpisodeInfo.Location = new System.Drawing.Point(3, 201);
            this.txtEpisodeInfo.Multiline = true;
            this.txtEpisodeInfo.Name = "txtEpisodeInfo";
            this.txtEpisodeInfo.ReadOnly = true;
            this.txtEpisodeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEpisodeInfo.Size = new System.Drawing.Size(612, 138);
            this.txtEpisodeInfo.TabIndex = 15;
            // 
            // DownloadPodcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEpisodeInfo);
            this.Controls.Add(this.lbDownloadList);
            this.Controls.Add(this.lblDownloadProgress);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.clbEpisodes);
            this.Controls.Add(this.groupBox1);
            this.Name = "DownloadPodcast";
            this.Size = new System.Drawing.Size(1220, 533);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblEpisodes;
        private System.Windows.Forms.CheckedListBox clbEpisodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbGetEpisodes;
        private System.Windows.Forms.TextBox txtPodcastSelectedSummary;
        private System.Windows.Forms.Button btnGetEpisodes;
        private System.Windows.Forms.ListBox lbPodcasts;
        private System.ComponentModel.BackgroundWorker bgwGetEpisodes;
        private System.Windows.Forms.Label lblDownloadProgress;
        private System.Windows.Forms.ListBox lbDownloadList;
        private System.Windows.Forms.TextBox txtEpisodeInfo;
    }
}
