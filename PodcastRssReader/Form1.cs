using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastRssReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPodcast1.Visible = true;
            downloadPodcast1.Visible = false;
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPodcast1.Visible = false;
            downloadPodcast1.Visible = true;
            downloadPodcast1.PopulatePodcastList();
        }

        private void editPodcastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
