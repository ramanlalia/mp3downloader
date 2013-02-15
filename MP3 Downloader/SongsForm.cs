using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace MP3_Downloader
{
    public partial class SongsForm : Form
    {
        private WebBrowser webBrowser;
        private String search;

        public SongsForm(String Search)
        {
            InitializeComponent();

            search = Search;

            webBrowser = new WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
            webBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(webBrowser_ProgressChanged);
            webBrowser.Navigate(search);          
        }

        void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0)
            {
                progressBar.Maximum = Convert.ToInt32(e.MaximumProgress);
                progressBar.Value = Convert.ToInt32(e.CurrentProgress);

                String percentLoaded = ((e.CurrentProgress / e.MaximumProgress) * 100).ToString();

                loadingLabel.Text = "Searching - " + percentLoaded + "%";
            }
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri == search)
            {
                loadingLabel.Visible = false;
                progressBar.Visible = false;

                HtmlElementCollection links = webBrowser.Document.GetElementsByTagName("a");
                String[] items = new String[2];

                foreach (HtmlElement link in links)
                {
                    if (link.GetAttribute("className") == "snap_noshots" && link.GetAttribute("target") == "_blank")
                    {
                        items[0] = link.InnerText;
                        items[1] = link.GetAttribute("href");                        
                        songsList.Items.Add(new ListViewItem(items));                        
                    }
                }
                
                songsList.Visible = true;
            }
        }

        private void songsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlaySongForm playSongForm = new PlaySongForm(songsList.SelectedItems[0].SubItems[1].Text, songsList.SelectedItems[0].SubItems[0].Text);
            playSongForm.Show();
        }
    }
}
