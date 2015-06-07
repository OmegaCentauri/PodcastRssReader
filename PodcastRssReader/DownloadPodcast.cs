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
using System.Net;
using System.Reflection;

namespace PodcastRssReader
{
    public partial class DownloadPodcast : UserControl
    {
        List<Episode> episodes = new List<Episode>();
        Dictionary<string, string> downloadingEpisodes = new Dictionary<string, string>();

        public DownloadPodcast()
        {
            InitializeComponent();
            lblDownloadProgress.Text = "";
            bgwGetEpisodes.WorkerReportsProgress = true;
            PopulatePodcastList();
        }

        public void PopulatePodcastList()
        {
            string podcastJSON = File.ReadAllText("T:/Development/RSS/PodcastRssReader/PodcastRssReader/PodcastData/Podcasts.json");
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

        private void btnGetEpisodes_Click(object sender, EventArgs e)
        {
            clbEpisodes.Items.Clear();
            Podcast selectedPodcastInfo = GetSelectedPodcastInfo(lbPodcasts.SelectedItem.ToString());
            if (!String.IsNullOrEmpty(selectedPodcastInfo.Title) && !bgwGetEpisodes.IsBusy)
            {
                bgwGetEpisodes.RunWorkerAsync(selectedPodcastInfo.URL);
            }
            else
            {
                MessageBox.Show("Podcast not found.");
            }
        }

        private void bgwGetEpisodes_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(50);
            ReadRSS rss = new ReadRSS();
            List<Episode> lstEpisodes = new List<Episode>();
            lstEpisodes = rss.GetPodcastEpisodes(e.Argument.ToString());
            e.Result = lstEpisodes;
        }

        private void bgwGetEpisodes_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbGetEpisodes.Style = ProgressBarStyle.Marquee;
            pbGetEpisodes.Visible = true;
        }

        private void bgwGetEpisodes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbGetEpisodes.Visible = false;
            if (e.Error != null)
            {
                MessageBox.Show("Error:" + e.Error.Message);
            }
            else
            {

                if (e.Result != null)
                {
                    episodes = (List<Episode>)e.Result;
                    Podcast selectedPodcast = GetSelectedPodcastInfo(lbPodcasts.SelectedItem.ToString());
                    foreach (Episode ep in episodes)
                    {
                        if (File.Exists(selectedPodcast.Path + "\\" + MakeValidFileName(ep.Name + ".mp3")))
                        {
                            clbEpisodes.Items.Add("Exists:Yes - " + ep.Name);
                        }
                        else
                        {
                            clbEpisodes.Items.Add("Exists:No - " + ep.Name);
                        }
                    }
                }
                else
                    MessageBox.Show("URL was not valid.");
            }
        }

        private void lbPodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Podcast selectedPodcastInfo = GetSelectedPodcastInfo(lbPodcasts.SelectedItem.ToString());
            if (!String.IsNullOrEmpty(selectedPodcastInfo.Title))
            {
                txtPodcastSelectedSummary.Text = selectedPodcastInfo.Summary;
            }
        }

        private Podcast GetSelectedPodcastInfo(string podcastTitle)
        {
            Podcast selectedPodcastObject = new Podcast();
            List<Podcast> podcasts = new List<Podcast>();
            string podcastJSON = File.ReadAllText("T:/Development/RSS/PodcastRssReader/PodcastRssReader/PodcastData/Podcasts.json");
            if (!String.IsNullOrEmpty(podcastJSON))
            {
                podcasts = JsonConvert.DeserializeObject<List<Podcast>>(podcastJSON);

                foreach (Podcast podcast in podcasts)
                {
                    if (podcast.Title == lbPodcasts.SelectedItem.ToString())
                    {
                        selectedPodcastObject = podcast;
                    }
                }
            }
            return selectedPodcastObject;
        }

        private void clbEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Episode selectedEpisode = episodes.ElementAt(clbEpisodes.SelectedIndex);

            txtEpisodeInfo.Text = selectedEpisode.Summary;

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string podcastURL = "";
            Episode selectedEpisode = new Episode();
            downloadingEpisodes.Clear();
            if (clbEpisodes.Items.Count != 0 && clbEpisodes.CheckedItems.Count > 0)
            {
                Podcast selectedPodcast = GetSelectedPodcastInfo(lbPodcasts.SelectedItem.ToString());

                foreach (int selectedIndex in clbEpisodes.CheckedIndices)
                {
                    selectedEpisode = episodes.ElementAt(selectedIndex);
                    podcastURL = selectedEpisode.URL;

                    if (podcastURL != null)
                    {
                        using (WebClient getWebFile = new WebClient())
                        {
                            getWebFile.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleteCallback);
                            getWebFile.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                            getWebFile.DownloadFileAsync(new Uri(podcastURL), selectedPodcast.Path + "\\" + MakeValidFileName(selectedEpisode.Name) + ".mp3", MakeValidFileName(selectedEpisode.Name));
                            downloadingEpisodes.Add(MakeValidFileName(selectedEpisode.Name), "");
                        }
                    }
                    else
                    {
                        MessageBox.Show(selectedEpisode.Name + " could not be downloaded. No URL found.");
                    }
                }
                //MessageBox.Show("Download Commencing");
            }
            else
            {
                MessageBox.Show("No episodes selected");
                return;
            }

        }

        public void DownloadFileCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        public void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            string listItem = string.Format("{0} download progress {1} of {2} kilobytes. {3}% complete...", new string[] { (string)e.UserState, Convert.ToString(e.BytesReceived/1024f), 
                Convert.ToString(e.TotalBytesToReceive/1024f), Convert.ToString(e.ProgressPercentage) });
            downloadingEpisodes[(string)e.UserState] = listItem;
            lbDownloadList.DataSource = downloadingEpisodes.Values.ToList<string>();
            //lblDownloadProgress.Text = listItem;
        }

        private static string MakeValidFileName(string name)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
        }
    }
}
