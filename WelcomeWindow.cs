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


        private async void initInstaller(string type)
        {
            var form = new InstallerWindow();
            switch (type)
            { 
                case "niOnly":
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                    await form.invokeInstaller("niOnly");
                    break;
                case "libOnly":
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                    await form.invokeInstaller("lib");
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
                    case "Game Tools (2022)":
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

        private void FRCEasyInstaller_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.FRCEasyIco;
        }
    }
}
