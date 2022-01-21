using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using Ionic.Zip;

namespace FRCEasyInstaller
{
    public partial class InstallerWindow : Form
    {
        String currentpth = Directory.GetCurrentDirectory();
        public InstallerWindow()
        {
            InitializeComponent();
        }

        private void createToolDirs()
        {
            this.taskState.Text = "Checking Directories...";
            this.taskProgress.Value = 50;
            if (!Directory.Exists(Path.Combine(currentpth, "installer-bin")))
            {
                this.taskState.Text = "Creating Directory: installer-bin";
                Directory.CreateDirectory(Path.Combine(currentpth, "installer-bin"));
                this.taskState.Text = "Creating Directory: installer-bin/ni";
                Directory.CreateDirectory(Path.Combine(currentpth, "installer-bin/ni"));
                this.taskState.Text = "Creating Directory: installer-bin/WPIlib";
                Directory.CreateDirectory(Path.Combine(currentpth, "installer-bin/WPIlib"));
                this.taskState.Text = "Done Creating Directories.";
            }
            this.taskProgress.Value = 100;
            this.taskState.Text = "Preparing Downloads...";
        }


        private void installAll()
        {

        }

        private void installOnlyNI()
        {

        }

        private void installOnlyLib()
        {
            this.taskProgress.Value = 0;
            this.taskState.Text = "Getting ready to download...";
            
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Headers.Add("User-Agent", "FRCEasyInstaller-WebClient1.0");
                if(Environment.Is64BitOperatingSystem)
                {
                    webClient.DownloadFileAsync(new Uri("https://files.sticks.network/files/latest_win64.zip"), Path.Combine(currentpth, "installer-bin/WPIlib/WPIlib_x64.zip"));
                    webClient.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                    {
                        taskState.Text = "Dowloading File (latest_win64.zip): " + e.BytesReceived + " of " + e.TotalBytesToReceive + " bytes ";
                        taskProgress.Value = e.ProgressPercentage;
                    };
                    webClient.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs e) =>
                    {
                        using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(Path.Combine(currentpth, "installer-bin/WPIlib/WPIlib_x64.zip")))
                        {
                            zip.ExtractProgress += (object sender1, ExtractProgressEventArgs e1) =>
                            {
                                if(e1.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
                                {
                                    taskProgress.Value = (int)(e1.BytesTransferred / (0.01 * e1.TotalBytesToTransfer));
                                }
                                else if (e1.EventType == ZipProgressEventType.Extracting_BeforeExtractEntry)
                                {
                                    Console.WriteLine("Extracting: {0}", e1.CurrentEntry.FileName);
                                    taskState.Text = "Extracting: " + e1.CurrentEntry.FileName;
                                }
                            };
                            foreach(var i in zip.Entries)
                            {
                                i.Extract(Path.Combine(currentpth, "installer-bin/WPIlib/"), Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                            };
                        }
                    };
                } else if (!Environment.Is64BitOperatingSystem)
                {
                    webClient.DownloadFileAsync(new Uri("https://files.sticks.network/files/latest_win32.zip"), Path.Combine(currentpth, "installer-bin/WPIlib/WPIlib_x32.zip"));
                    webClient.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                    {
                        taskState.Text = "Dowloading File (latest_win32.zip): " + e.BytesReceived + " of " + e.TotalBytesToReceive + " bytes ";
                        taskProgress.Value = e.ProgressPercentage;
                    };
                    webClient.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs e) =>
                    {
                        using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(Path.Combine(currentpth, "installer-bin/WPIlib/WPIlib_x32.zip")))
                        {
                            zip.ExtractProgress += (object sender1, ExtractProgressEventArgs e1) =>
                            {
                                if (e1.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
                                {
                                    taskProgress.Value = (int)(e1.BytesTransferred / (0.01 * e1.TotalBytesToTransfer));
                                }
                                else if (e1.EventType == ZipProgressEventType.Extracting_BeforeExtractEntry)
                                {
                                    Console.WriteLine("Extracting: {0}", e1.CurrentEntry.FileName);
                                    taskState.Text = "Extracting: " + e1.CurrentEntry.FileName;
                                }
                            };
                            foreach (var i in zip.Entries)
                            {
                                i.Extract(Path.Combine(currentpth, "installer-bin/WPIlib/"), Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                            };
                        }
                    };
                }
            }
        }

        public void invokeInstaller(String type)
        {
            createToolDirs();
            switch (type)
            {
                case "all":
                    installAll();
                    break;
                case "niOnly":
                    installOnlyNI();
                    break;
                case "lib":
                    installOnlyLib();
                    break;
                default:
                    MessageBox.Show("An unknown case was passed: " + type, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void stopOp_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spinControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
