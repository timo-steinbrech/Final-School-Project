using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace UpdateTest
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            { 
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\updater.exe");
                client.DownloadFile(@"http://localhost/test/", "Demo.zip");
                string zipPath = @".\Demo.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\Demo.zip");
                Process.Start(@".\updater.exe");
                this.Close();
            }
            catch
            {
                Process.Start(@"C:\Users\timo.steinbrech\Downloads\TestApp\UpdateTest\updater\bin\Debug\net5.0-windows10.0.22000.0\updater.exe");
                this.Close();
            }
        }


        


    }
}
