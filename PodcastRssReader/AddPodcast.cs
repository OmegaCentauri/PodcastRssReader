using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;

namespace PodcastRssReader
{
    public partial class AddPodcast : UserControl
    {
        public AddPodcast()
        {
            InitializeComponent();
            bgwGetPodcast.WorkerReportsProgress = true;
        }


        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 episodesForm = new Form1();
            episodesForm.Show();
        }

        private void btnAddRSS_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRSSURL.Text) && !bgwGetPodcast.IsBusy)
            {
                bgwGetPodcast.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Enter a URL or wait for current request to complete.");
            }
        }

        private void bgwGetPodcast_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(50);
            ReadRSS rss = new ReadRSS();
            Podcast podcast = new Podcast();
            podcast = rss.GetPodcastInfo(txtRSSURL.Text);
            e.Result = podcast;
        }

        private void bgwGetPodcast_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbGetPodcastInfo.Style = ProgressBarStyle.Marquee;
            pbGetPodcastInfo.Visible = true;
        }

        private void bgwGetPodcast_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbGetPodcastInfo.Visible = false;
            if (e.Error != null)
            {
                MessageBox.Show("Error:" + e.Error.Message);
            }
            else
            {

                if (e.Result != null)
                {
                    Podcast podcast = (Podcast)e.Result;
                    txtPodcastTitle.Text = podcast.Title;
                    txtPodcastSummary.Text = podcast.Summary;
                    btnSavePodcast.Enabled = true;
                }
                else
                    MessageBox.Show("URL was not valid.");
            }
        }



        private void btnSavePodcast_Click(object sender, EventArgs e)
        {
            try
            {
                string podcastJSON = File.ReadAllText("../../PodcastData/Podcasts.json");
                Podcast podcast = new Podcast(txtPodcastTitle.Text, txtPodcastSummary.Text, txtRSSURL.Text, txtPodcastPath.Text);
                string json;
                if (!String.IsNullOrEmpty(podcastJSON))
                {
                    List<Podcast> savedPodcasts = JsonConvert.DeserializeObject<List<Podcast>>(podcastJSON);
                    savedPodcasts.Add(podcast);
                    json = JsonConvert.SerializeObject(savedPodcasts);
                }
                else
                {
                    json = JsonConvert.SerializeObject(new[] { podcast });
                }
                File.WriteAllText("../../PodcastData/Podcasts.json", json);
                PopulatePodcastList();
                MessageBox.Show("Podcast saved successfully;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving podcast.");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult selectedPath = fbdPodcastPath.ShowDialog();
            txtPodcastPath.Text = fbdPodcastPath.SelectedPath;
        }

        private void PopulatePodcastList()
        {
            string podcastJSON = File.ReadAllText("../../PodcastData/Podcasts.json");
            if (!String.IsNullOrEmpty(podcastJSON))
            {
                List<Podcast> podcasts = JsonConvert.DeserializeObject<List<Podcast>>(podcastJSON);
                List<string> podcastTitles = new List<string>();
                foreach (Podcast podcast in podcasts)
                {
                    podcastTitles.Add(podcast.Title);
                }
                lbPodcasts.DataSource = podcastTitles;
            }
        }
    }
}
