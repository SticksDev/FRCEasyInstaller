using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
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


        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }


        private async Task installOnlyNI(bool ExitOnFinsh)
        {
            this.taskProgress.Value = 0;
            this.taskState.Text = "Getting ready to download...";
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Headers.Add("User-Agent", "FRCEasyInstaller-WebClient1.0");
                webClient.DownloadFileAsync(new Uri("https://download.ni.com/support/nipkg/products/ni-f/ni-frc-2022-game-tools/22.0/online/ni-frc-2022-game-tools_22.0_online.exe"), Path.Combine(currentpth, "installer-bin/ni/ni-online-installer.exe"));
                webClient.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                {
                    DLoadState.Text = "Dowloading File (frcgametools.exe): " + Decimal.Round((decimal)ConvertBytesToMegabytes(e.BytesReceived), 2) + " of " + Decimal.Round((decimal)ConvertBytesToMegabytes(e.TotalBytesToReceive), 2) + " MiB ";
                    taskProgress.Value = e.ProgressPercentage;
                };
                webClient.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs e) =>
                {
                    DLoadState.Text = "";
                    taskState.Text = "NI gametools downloaded successfully. Executing installer!";
                    using (Process niInstaller = Process.Start(Path.Combine(currentpth, @"installer-bin\ni\ni-online-installer.exe")))
                    {
                        taskState.Text = "Waiting for installer to exit.";
                        taskProgress.Value = 100;
                        niInstaller.WaitForExit();
                        if (niInstaller.ExitCode != 0)
                        {
                            taskState.Text = "Installer Error";
                            MessageBox.Show("This may be do to an internal error within ni's installer software. (" + niInstaller.ExitCode + ") \n Install Done With 1 Warnings.", "ni install did not exit correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (ExitOnFinsh) { System.Windows.Forms.Application.Exit(); }
                        }
                        taskState.Text = "Installer Done!";
                        MessageBox.Show("NI gametools LAUNCHER has been installed.\nPlease follow the instructions proivded by the gametools installer.\nHave a nice day :)", "Install finshed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (ExitOnFinsh) { System.Windows.Forms.Application.Exit(); }
                    }
                };
            }
        }

        private async Task installOnlyLib(bool ExitOnFinsh)
        {
            this.taskProgress.Value = 0;
            this.taskState.Text = "Getting ready to download...";
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Headers.Add("User-Agent", "FRCEasyInstaller-WebClient1.0");
                if(Environment.Is64BitOperatingSystem)
                {
                    taskState.Text = "Downloading WPIlib x64 and extracting.";
                    webClient.DownloadFileAsync(new Uri("https://files.sticks.network/files/latest_win64.zip"), Path.Combine(currentpth, "installer-bin/WPIlib/WPIlib_x64.zip"));
                    webClient.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                    {
                        DLoadState.Text = "Dowloading File (latest_win64.zip): " + Decimal.Round((decimal)ConvertBytesToMegabytes(e.BytesReceived), 2) + " of " + Decimal.Round((decimal)ConvertBytesToMegabytes(e.TotalBytesToReceive), 2) + " MiB ";
                        taskProgress.Value = e.ProgressPercentage;
                    };
                    webClient.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs e) =>
                    {
                        DLoadState.Text = "";
                        using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(Path.Combine(currentpth, "installer-bin/WPIlib/WPIlib_x64.zip")))
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
                                }
                            };
                            foreach (var i in zip.Entries)
                            {
                                i.Extract(Path.Combine(currentpth, "installer-bin/WPIlib/"), Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                            };
                        }
                        taskState.Text = "WPIlib downloaded and extracted successfully. Executing installer!";
                        using (Process wpiInstaller = Process.Start(Path.Combine(currentpth, @"installer-bin\WPIlib\latest_win64\WPILibInstaller.exe")))
                        {
                            taskState.Text = "Waiting for installer to exit.";
                            taskProgress.Value = 100;
                            wpiInstaller.WaitForExit();
                            if(wpiInstaller.ExitCode != 0)
                            {
                                taskState.Text = "Installer Error";
                                MessageBox.Show("This may be do to an internal error within WPIlib's installer software. (" + wpiInstaller.ExitCode + ") \n Install Done With 1 Warnings.", "WPIlib install did not exit correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (ExitOnFinsh) { System.Windows.Forms.Application.Exit(); }
                            }
                            taskState.Text = "Installer Done!";
                            MessageBox.Show("Install Done With 0 Warnings and 0 errors. \nHave a nice day :)", "Install finshed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (ExitOnFinsh) { System.Windows.Forms.Application.Exit(); }
                        }

                    };
                } else if (!Environment.Is64BitOperatingSystem)
                {
                    webClient.DownloadFileAsync(new Uri("https://files.sticks.network/files/latest_win32.zip"), Path.Combine(currentpth, "installer-bin/WPIlib/WPIlib_x32.zip"));
                    webClient.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
                    {
                        DLoadState.Text = "Dowloading File (latest_win32.zip): " + Decimal.Round((decimal)ConvertBytesToMegabytes(e.BytesReceived), 2) + " of " + Decimal.Round((decimal)ConvertBytesToMegabytes(e.TotalBytesToReceive), 2) + " MiB ";
                        taskProgress.Value = e.ProgressPercentage;
                    };
                    webClient.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs e) =>
                    {
                        DLoadState.Text = "";
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
                                }
                            };
                            foreach (var i in zip.Entries)
                            {
                                i.Extract(Path.Combine(currentpth, "installer-bin/WPIlib/"), Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                            };
                        }
                        taskState.Text = "WPIlib downloaded and extracted successfully. Executing installer!";
                        using (Process wpiInstaller = Process.Start(Path.Combine(currentpth, @"installer-bin\WPIlib\latest_win32\WPILibInstaller.exe")))
                        {
                            taskState.Text = "Waiting for installer to exit.";
                            taskProgress.Value = 100;
                            wpiInstaller.WaitForExit();
                            if (wpiInstaller.ExitCode != 0)
                            {
                                taskState.Text = "Installer Error";
                                MessageBox.Show("This may be do to an internal error within WPIlib's installer software. (" + wpiInstaller.ExitCode + ") \n Install Done With 1 Warnings.", "WPIlib install did not exit correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (ExitOnFinsh) { System.Windows.Forms.Application.Exit(); }
                            }
                            taskState.Text = "Installer Done!";
                            MessageBox.Show("Install Done With 0 Warnings and 0 errors. \nHave a nice day :)", "Install finshed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (ExitOnFinsh) { System.Windows.Forms.Application.Exit(); }
                        }
                    };
                }
            }
        }


        public async Task invokeInstaller(String type)
        {
            createToolDirs();
            switch (type)
            {
                case "niOnly":
                    await installOnlyNI(true);
                    break;
                case "lib":
                    await installOnlyLib(true);
                    break;
                default:
                    MessageBox.Show("An unknown case was passed: " + type, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void stopOp_bttn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void spinControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(spinControlCheckBox.Checked)
            {
                MessageBox.Show("#WaterGame 2023", "#WaterGame 2023", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("You unchecked watergame", "How dare you.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void InstallerWindow_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.FRCEasyIco;
        }
    }
}
