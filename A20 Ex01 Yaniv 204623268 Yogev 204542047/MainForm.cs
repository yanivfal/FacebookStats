using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class MainForm : Form
    {
        private List<WallPhoto> m_CurrentPhotoOnWall = new List<WallPhoto>();

        public MainForm()
        {
            InitializeComponent();
            initializeWindowSettings();

            try
            {
                fetchUserData();
                fetchAlbumsNamesInComboBox();
                comboBoxAlbums.SelectedItem = comboBoxAlbums.Items[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void initializeWindowSettings()
        {
            // Set the window size
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int width = screen.Width / 2 + 20;
            int height = screen.Height - 20;
            this.Size = new Size(width, height);
            // Logo button location
            logoutButton.Left = this.Right - logoutButton.Width - 50;
            logoutLabel.Left = this.Right - logoutButton.Width - 50;
            // Top cover size
            topCover.Width = this.Width - 20;
            // Buttons size and location
            horoscopeButton.Left = this.Left + 30;
            uploadStatisticsButton.Left = this.Right - uploadStatisticsButton.Width
                - 30;

        }

        private void fetchUserData()
        {
            this.profilePicture.Image = FBAgent.LoggedInUser.ImageNormal;
            this.userName.Text = FBAgent.LoggedInUser.Name;
        }

        private void fetchAlbumsNamesInComboBox()
        {
            foreach (Album album in FBAgent.LoggedInUser.Albums)
            {
                if (album.Photos.Count != 0)
                {
                    comboBoxAlbums.Items.Add(album.Name);
                } 
            }
        }

        private void fetchSelcetedAlbum(string i_AlbumName)
        {
            int position = topCover.Bottom + 100;
            int count = 0;
            FacebookObjectCollection<Photo> wallPictures = getAlbumPhotosByName(i_AlbumName);

            foreach (Photo photo in wallPictures)
            {
                WallPhoto photoComponent = new WallPhoto(photo);
                photoComponent.Top = position;
                position = photoComponent.Bottom + 30;
                photoComponent.Left = (this.Width) / 2 - (photoComponent.Width / 2);
                this.Controls.Add(photoComponent);
                m_CurrentPhotoOnWall.Add(photoComponent);
                count++;
                if (count >= 3)
                {
                    break;
                }
            }
        }

        private void uploadStatisticsButton_Click(object sender, EventArgs e)
        {
            UIRunner.HideCurrentForm();
            UIRunner.OpenForm<UploadsStats>();
            //After previous screen is closed
            UIRunner.OpenForm<MainForm>();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AppSettings.Instance.RememberUser = false;
            AppSettings.Instance.LastAccessToken = null;
            AppSettings.Instance.SaveToFile();
            UIRunner.HideCurrentForm();
            UIRunner.OpenForm<LoginForm>();
        }

        private void horoscopeButton_Click(object sender, EventArgs e)
        {
            UIRunner.HideCurrentForm();
            UIRunner.OpenForm<HoroscopeForm>();
            //After previous screen is closed
            UIRunner.OpenForm<MainForm>();
        }

        private FacebookObjectCollection<Photo> getAlbumPhotosByName(string i_AlbumName)
        {
            FacebookObjectCollection<Photo> photos = null;

            foreach (Album album in FBAgent.LoggedInUser.Albums)
            {
                if (i_AlbumName.Equals(album.Name))
                {
                    photos = album.Photos;
                    break;
                }
            }

            return photos;
        }

        private void clearWall()
        {
            foreach (WallPhoto photo in m_CurrentPhotoOnWall)
            {
                this.Controls.Remove(photo);
            }

            m_CurrentPhotoOnWall.Clear();
        }

        private void comboBoxAlbums_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            clearWall();
            fetchSelcetedAlbum(comboBoxAlbums.SelectedItem.ToString());
        }
    }
}
