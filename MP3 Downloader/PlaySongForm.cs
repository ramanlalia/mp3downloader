using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using MP3_Downloader.Properties;

namespace MP3_Downloader
{
    public partial class PlaySongForm : Form
    {
        private String mp3Url;
        private String mp3Name;

        public PlaySongForm(String SongURL, String SongName)
        {
            InitializeComponent();

            axWindowsMediaPlayer1.URL = SongURL;
            mp3Url = SongURL;
            mp3Name = SongName;
        }

        private void mp3Button_Click(object sender, EventArgs e)
        {
            PutOnMP3Form form = new PutOnMP3Form(mp3Url, mp3Name);
            form.Show();
        }        
    }
}
