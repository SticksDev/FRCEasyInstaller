using System;
using System.Windows.Forms;

namespace FRCEasyInstaller
{
    public partial class FRCEasyInstaller : Form
    {

        public FRCEasyInstaller()
        {
            InitializeComponent();

        }


        private void initInstaller(string type)
        {
            var form = new InstallerWindow();
            switch (type)
            { 
                case "all":
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                    form.invokeInstaller("all");
                    break;
                case "niOnly":
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                    form.invokeInstaller("niOnly");
                    break;
                case "libOnly":
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                    form.invokeInstaller("lib");
                    break;
                default:
                    MessageBox.Show("An unknown case was passed: " + type, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (this.versionSelectBox.SelectedItem == null)
            {
                MessageBox.Show("You must choose a version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (versionSelectBox.SelectedItem)
                {
                    case "NI + wpilib (2022)":
                        initInstaller("all");
                        break;
                    case "NI Only (2022)":
                        initInstaller("niOnly");
                        break;
                    case "wpilib (2022)":
                        initInstaller("libOnly");
                        break;
                    default:
                        MessageBox.Show("An unknown case was passed: " + versionSelectBox.SelectedItem, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
    }
}
