using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            fetchUserData();
            fetchPost();
        }

        private void fetchPost()
        {
            TextBox textBox = new TextBox();
            textBox.Text = FBAgent.LoggedInUser.Posts.ToString();
            this.Controls.Add(textBox);
        }

        private void fetchUserData()
        {
            this.profilePicture.Image = FBAgent.LoggedInUser.ImageNormal;
            this.userName.Text = FBAgent.LoggedInUser.Name;
        }

        private void uploadStatisticsButton_Click(object sender, EventArgs e)
        {
            UIRunner.HideCurrentForm();
            UIRunner.OpenUploadsStatsForm();
            //After previous screen is closed
            UIRunner.OpenMainForm();
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if (AppSettings.Instance.RememberUser)
            {
                AppSettings.Instance.WindowPosition = this.Location;
                AppSettings.Instance.WindowSize = this.Size;
                AppSettings.Instance.SaveToFile();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppSettings.Instance.RememberUser)
            {
                AppSettings.Instance.WindowPosition = this.Location;
                AppSettings.Instance.WindowSize = this.Size;
                AppSettings.Instance.SaveToFile();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AppSettings.Instance.RememberUser = false;
            AppSettings.Instance.LastAccessToken = null;
            AppSettings.Instance.SaveToFile();
            UIRunner.HideCurrentForm();
            UIRunner.OpenLoginForm();
        }
    }
}
