using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;

namespace PodcastRssReader
{
    class ReadRSS
    {
        public string readRSSFeed()
        {
            XmlReader xreader = XmlReader.Create("http://feeds.soundcloud.com/users/soundcloud:users:38128127/sounds.rss"); //TODO: Replace with user supplied RSS URI.
            SyndicationFeed podcasts = SyndicationFeed.Load(xreader);
            xreader.Close();
            string title = "No Title found";

            List<SyndicationItem> lItems = podcasts.Items.ToList();

            for (int i = 0; i < 1;i++)
            {
                SyndicationItem item = lItems[0];
                title = item.Title.Text;
            }
            return title;
        }

        public Podcast GetPodcastInfo(string rssURL)
        {
            Podcast podcastInfo = new Podcast();

            try
            {
                XmlReader xreader = XmlReader.Create(rssURL);
                SyndicationFeed rssFeed = SyndicationFeed.Load(xreader);
                xreader.Close();
                if(rssFeed != null)
                {
                    podcastInfo.Title = rssFeed.Title.Text;
                    podcastInfo.Summary = rssFeed.Description.Text;
                    podcastInfo.URL = rssURL;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an error retrieving the RSS feed.");
                Console.WriteLine(ex.Message);
            }
            return podcastInfo;

        }

        public List<Episode> GetPodcastEpisodes(string rssURL)
        {
            List<Episode> episodes = new List<Episode>();

            try
            {
                XmlReader xreader = XmlReader.Create(rssURL);
                SyndicationFeed rssFeed = SyndicationFeed.Load(xreader);
                xreader.Close();
                if (rssFeed != null)
                {
                   foreach(SyndicationItem item in rssFeed.Items)
                   {
                       string episodeUri = "";
                       foreach(SyndicationLink link in item.Links)
                       {
                           if(link.Uri.AbsoluteUri.Contains("mp3"))
                           {
                               episodeUri = link.Uri.AbsoluteUri;
                           }
                       }
                       episodes.Add(new Episode(item.Title.Text, item.Summary.Text, episodeUri));
                       
                   }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error retrieving the RSS feed.");
                Console.WriteLine(ex.Message);
            }
            return episodes;

        }
        
    }
}
