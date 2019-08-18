using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader
{
    public partial class Form1 : Form
    {

        private delegate void MyDelegate();
        private event MyDelegate DownloadEvent;
        private WebClient myWebClient = new WebClient();

        /// <summary>
        /// Dictionary with Title of tools and links to download
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> downloadLinks = new Dictionary<string, string>()
        {
            { "Google Chrome", @"https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B7A1780AD-3F6F-742D-21EB-69989F896ADE%7D%26lang%3Den%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe" },
            { "Sublime", @"https://download.sublimetext.com/Sublime Text Build 3207 x64 Setup.exe" },
            { "Docker", @"https://download.docker.com/win/stable/Docker%20for%20Windows%20Installer.exe" },
            { "Steam", @"https://steamcdn-a.akamaihd.net/client/installer/SteamSetup.exe" },
            { "Origin", @"https://origin-a.akamaihd.net/Origin-Client-Download/origin/live/OriginThinSetup.exe" },
            { "Skype", @"https://go.skype.com/windows.desktop.download" },
            { "Spotify", @"https://www.spotify.com/int/download/windows/" },
            { "Visual Studio", @"https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Professional&rel=16" },
            { "Tunnel Bear VPN", @"https://tunnelbear.s3.amazonaws.com/downloads/pc/public/TunnelBear-Installer.exe" },
            { "uTorrent", @"https://www.utorrent.com/intl/ru/downloads/complete/track/stable/os/win" },
            { "Foxit Reader", @"" },
            { "Battle Net", @"https://www.battle.net/download/getInstallerForGame?os=win&locale=enUS&version=LIVE&gameProgram=BATTLENET_APP&id=244389858.1565729819" }
        };

        public Form1()
        {
            InitializeComponent();
            UpdateToolsList();
        }

        private void UpdateToolsList()
        {
            foreach (var tools in downloadLinks)
            {
                comboBox.Items.Add(tools.Key);
            }
        }

        private void StartDownloadAsync()
        {
            using (myWebClient)
            {
                new  Thread(() =>
                {
                    Action action = (() =>
                    {
                        foreach (var tool in downloadLinks.Where(x => label.Text.Split('\n').Contains(x.Key)))
                        {
                            myWebClient = new WebClient();
                            
                            if (label1.Text == string.Empty)
                            {
                                label1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            }

                            myWebClient.DownloadFileAsync(new Uri(tool.Value), label1.Text + "/" + $"{tool.Key}.exe");

                        }
                        //delegate + DownloadDataCallback method
                        //delegate + Install method
                        DownloadEvent += InstallAllDownloadedTools ;

                        myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadDataCallback);

                    });

                    if (InvokeRequired)
                    {
                        Invoke(action);
                    }
                    else
                    {
                        action();
                    }

                }).Start();
            }
        }

        private void DownloadDataCallback(object s, AsyncCompletedEventArgs e)
        {
            MessageBox.Show($"Download finished successful to {label1.Text} path");
            // run delegate methods here => DownloadDataCallback and Install methods will be invoked here 

            DownloadEvent?.Invoke();

            if (checkBox5.Checked)
            {
                InstallAllDownloadedTools();
            }

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            StartDownloadAsync();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label.Show();
            label.Text += $"{comboBox.SelectedItem}\n";
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (var fldrDlg = new FolderBrowserDialog())
            {
                if (fldrDlg.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = fldrDlg.SelectedPath;
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // TODO: Fix it
            try
            {
                downloadLinks.Add(Title.Text, Link.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            UpdateToolsList();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
        }

        private void InstallAllDownloadedTools()
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    var downloadedTools = Directory.GetFiles(label1.Text, "*.exe");

                    foreach (var tool in downloadedTools)
                    {
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = tool;
                        myProcess.StartInfo.Verb = "runas";
                        myProcess.StartInfo.CreateNoWindow = true;
                        myProcess.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void MyProcessOnExited(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                DeleteAllDownloadedTools();
            }
        }

        private void DeleteAllDownloadedTools()
        {
            File.Delete(label1.Text);
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
        }
    }
}
