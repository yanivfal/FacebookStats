using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
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
            fetchPhotos();
        }

        private void fetchPhotos()
        {
            int position = likeStatisticsButton.Bottom + 10;
            FacebookObjectCollection<Photo> wallPictures = m_LoggedInUser.PhotosTaggedIn;
            Size pictureSize = new Size(300, 300);
            foreach (Photo photo in wallPictures)
            {
                PictureBox picture = new PictureBox();
                picture.BackgroundImage = photo.ImageNormal;
                picture.Left = (this.Left + this.Right)/2 - (picture.Width/2);
                picture.Top = position;
                picture.Size = pictureSize;
           
                picture.BackgroundImageLayout = ImageLayout.Stretch;
                position = picture.Bottom + 50;
                this.Controls.Add(picture);
            }
        }

        private void fetchUserData()
        {
            this.profilePicture.Image = m_LoggedInUser.ImageNormal;
            this.userName.Text = m_LoggedInUser.Name;
        }

        private void uploadStatisticsButton_Click(object sender, EventArgs e)
        {

            new UploadsStats(m_LoggedInUser).Show();
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

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            AppSettings.Instance.RememberUser = false;
            AppSettings.Instance.LastAccessToken = null;
            AppSettings.Instance.SaveToFile();
            this.Hide();
            LoginForm logInForm = new LoginForm();
            logInForm.ShowDialog();
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
    }
}
