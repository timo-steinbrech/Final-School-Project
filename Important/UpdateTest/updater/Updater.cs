using System;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;


namespace updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://pastebin.com/NPCtHLhj").Contains("1.0.2"))
                {
                    if (MessageBox.Show("Looks like there is an update! Do you want to download it?", "Demo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start(@"C:\Users\timo.steinbrech\source\repos\UpdateTest\updater\bin\Debug\net5.0-windows10.0.22000.0\Downloader.exe");
                            this.Close();
                        }
                }
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
