using System;
using System.Windows.Forms;

namespace Downloader
{
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
            // Download here 
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                label.Show();
                label.Text += $"{comboBox.SelectedItem}\n";
            }
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
