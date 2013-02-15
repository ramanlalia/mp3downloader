using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP3_Downloader
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            String search = "http://www.skreemr.com/results.jsp?q=" + searchTxt.Text.Replace(" ", "+");
            SongsForm songForm = new SongsForm(search);
            songForm.Show();
        }

        private void searchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                String search = "http://www.skreemr.com/results.jsp?q=" + searchTxt.Text.Replace(" ", "+");
                SongsForm songForm = new SongsForm(search);
                songForm.Show();
            }
        }
    }
}
