using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastRssReader
{
    public class Episode
    {
        public Episode()
        {

        }

        public Episode(string name, string summary, string url)
        {
            Name = name;
            Summary = summary;
            URL = url;
        }

        public string Name { get; set; }
        public string Summary { get; set; }
        public string URL { get; set; }
    }
}
