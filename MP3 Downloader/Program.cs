using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace MP3_Downloader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Directory.Exists("tmp"))
            {
                Directory.Delete("tmp", true);
            }
            Directory.CreateDirectory("tmp");
            Application.Run(new SearchForm());            
        }
    }
}
