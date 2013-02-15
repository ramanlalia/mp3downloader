using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace MP3_Downloader
{
    public partial class PutOnMP3Form : Form
    {
        private WebClient downloader;
        private String mp3Url;
        private String mp3Name;

        public PutOnMP3Form(String SongURL, String SongName)
        {
            InitializeComponent();

            mp3Url = SongURL;
            mp3Name = SongName;

            downloader = new WebClient();
            downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(downloader_DownloadFileCompleted);
            downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloader_DownloadProgressChanged);
        }

        void downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label2.Text = "Sending to MP3 - " + e.ProgressPercentage + "%";
        }

        void downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("The song has been added to your MP3 Player", "Song Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PutOnMP3Form_Load(object sender, EventArgs e)
        {
            String[] drives = Environment.GetLogicalDrives();

            foreach (String drive in drives)
            {
                DriveInfo driveInfo = new DriveInfo(drive);

                if (driveInfo.DriveType == DriveType.Removable)
                {
                    try
                    {
                        comboBox1.Items.Add("(" + drive + ") " + driveInfo.VolumeLabel);
                    }
                    catch (IOException ex)
                    {
                        continue;
                    }
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                progressBar1.Visible = true;
                label2.Visible = true;
                String drive = comboBox1.SelectedItem.ToString().Substring(1, 1);
                downloader.DownloadFileAsync(new Uri(mp3Url), drive + @":\" + mp3Name + ".mp3");
            }
            else
            {
                MessageBox.Show("Please select your MP3 Player from the list", "Select MP3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
