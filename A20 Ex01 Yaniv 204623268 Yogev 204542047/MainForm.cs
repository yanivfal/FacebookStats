﻿using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            fetchUserData();
            fetchPhotos();
        }

        private void fetchPhotos()
        {
            
            int position = topCover.Bottom + 100;
            FacebookObjectCollection<Photo> wallPictures = FBAgent.LoggedInUser.PhotosTaggedIn;
            int count = 0;
            foreach (Photo photo in wallPictures)
            {
                WallPhoto photoComponent = new WallPhoto(photo);
                photoComponent.Top = position;
                position = photoComponent.Bottom + 30;
                photoComponent.Left = (this.Left + this.Right) / 2 - (photoComponent.Width / 2);
                this.Controls.Add(photoComponent);
                count++;
                if (count >= 3)
                {
                    break;
                } 
            }
        }

        private Label setPictureDetails(Photo i_Photo)
        {
            Label photoDetails = new Label();
            photoDetails.Text = string.Format("Date: {0}, Likes by: {1} people",
                i_Photo.UpdateTime.ToString(), i_Photo.LikedBy.Count);

            return photoDetails;
        }

        private PictureBox setPictureSizeAndPosition(Photo photo, int i_Position)
        {
            int pictureWidth = 400;
            PictureBox picture = new PictureBox();
            float imageRatio;

            imageRatio = photo.Height / (float)photo.Width;
            picture.Image = photo.ImageNormal;
            picture.Left = (this.Left + this.Right) / 2 - pictureWidth / 2;
            picture.Top = i_Position;
            picture.Width = pictureWidth;
            picture.Height = (int)(pictureWidth * imageRatio);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            return picture;
        }

        private void fetchUserData()
        {
            this.profilePicture.Image = FBAgent.LoggedInUser.ImageNormal;
            this.userName.Text = FBAgent.LoggedInUser.Name;
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

        private void likeStatisticsButton_Click_1(object sender, EventArgs e)
        {
            UIRunner.HideCurrentForm();
            UIRunner.OpenForm<LikesStatisticsForm>();
            //After previous screen is closed
            UIRunner.OpenForm<MainForm>();
        }
    }
}
