using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Configuration;
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
        public Form1()
        {
            InitializeComponent();
            label.Hide();

            foreach (var tools in ToolsList())
            {
                comboBox.Items.Add(tools.Key);
            }
            
        }

        /// <summary>
        /// Return Title of tools and links to download
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> ToolsList()
        {
            var downloadLinks = new Dictionary<string, string>
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
                { "Battle Net", @"https://www.battle.net/download/getInstallerForGame?os=win&locale=enUS&version=LIVE&gameProgram=BATTLENET_APP&id=244389858.1565729819" }
            };

            return downloadLinks;
        }

        private async void Download()
        {
            using (var myWebClient = new WebClient())
            {
                await Task.Run(() =>
                {
                    Action action = () =>
                     {
                        foreach (var tool in ToolsList().Where(x => label.Text.Split('\n').Contains(x.Key)))
                        {
                            if (label1.Text == string.Empty)
                            {
                                label1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            }

                            progressBar1.Maximum = 100;
                            progressBar1.Minimum = 0;
                            progressBar1.Value++;

                            myWebClient.DownloadFile(tool.Value, label1.Text + "/" + $"{tool.Key}.exe");

                        }

                        MessageBox.Show($"Download finished successful to {label1.Text} path");

                    };
                    if (InvokeRequired)
                    {
                        Invoke(action);
                    }
                    else
                    {
                        action();
                    }
                });
            }
        }
        private  void DownloadButton_Click(object sender, EventArgs e)
        {
             Download();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            label.Show();
            label.Text += $"{comboBox.SelectedItem}\n";

            //if ()
            //{
            //    label.Show();
            //    label.Text += $"{comboBox.SelectedItem}\n\n";
            //    progressBar1.Visible = true;
            //    progressBar1.Location = new System.Drawing.Point(label.Location.X + 168, label.Location.Y);
            //}
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
                //fldrDlg.Filter = "Png Files (*.png)|*.png";
                //fldrDlg.Filter = "Excel Files (*.xls, *.xlsx)|*.xls;*.xlsx|CSV Files (*.csv)|*.csv"

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
    }
}
