using System;
using System.Drawing;
using System.Drawing.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader
{
    /// <Links>
    /// Google Chrome https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B7A1780AD-3F6F-742D-21EB-69989F896ADE%7D%26lang%3Den%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe
    /// Sublime       https://download.sublimetext.com/Sublime 
    /// Docker        https://download.docker.com/win/stable/Docker%20for%20Windows%20Installer.exe
    /// Steam         https://steamcdn-a.akamaihd.net/client/installer/SteamSetup.exe
    /// Origin        https://origin-a.akamaihd.net/Origin-Client-Download/origin/live/OriginThinSetup.exe
    /// BattleNet     https://www.battle.net/download/getInstallerForGame?os=win&locale=enUS&version=LIVE&gameProgram=BATTLENET_APP&id=2061206683.1565704433
    /// uTorrent      http://download-hr.utorrent.com/track/stable/endpoint/utorrent/os/windows
    /// </Links>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label.Hide();
            var test = Enum.GetValues(typeof(ToolsEnum));

            foreach (var tools in test)
            {
                comboBox.Items.Add(tools);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var toolsList = label.Text.Split('\n');

            // Download here 
            //Task.Run(() =>
            //    {
            //        if (label.Text.Contains("Docker"))
            //        {
            //        }
            //    });
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
                    var test = fldrDlg.SelectedPath;
                }
            }
        }
    }
}
