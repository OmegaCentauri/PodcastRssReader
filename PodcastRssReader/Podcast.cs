using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastRssReader
{
    public class Podcast
    {
        public Podcast()
        {

        }

        public Podcast(string title, string summary, string url)
        {
            Title = title;
            Summary = summary;
            URL = url;
        }

        public Podcast(string title, string summary, string url, string path)
        {
            Title = title;
            Summary = summary;
            URL = url;
            Path = path;
        }

        public string Title { get; set; }
        public string Summary { get; set; }
        public string URL { get; set; }
        public string Path { get; set; }
    }
}
