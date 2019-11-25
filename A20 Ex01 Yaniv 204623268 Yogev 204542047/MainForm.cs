using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class MainForm : Form
    {
        User m_LoggedInUser;

        public MainForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;

            InitializeComponent();
            fetchUserData();
        }

        private void fetchUserData()
        {
            this.profilePicture.Image = m_LoggedInUser.ImageNormal;
            this.userName.Text = m_LoggedInUser.Name;
        }

        private void likeStatisticsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void uploadStatisticsButton_Click(object sender, EventArgs e)
        {
            new UploadsStats().Show();
        }
    }
}
