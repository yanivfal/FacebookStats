using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class WallPhoto : UserControl
    {
        private const int k_PhotoWidth = 400;
        private readonly int r_PhotoHeight;

        public WallPhoto(Photo i_Photo)
        {
            r_PhotoHeight = calcHeightByratio(i_Photo);
            InitializeComponent();
            InitializePhotoProperties(i_Photo);
        }

        private void InitializePhotoProperties(Photo photo)
        {
            this.Width = k_PhotoWidth;
            this.Height = r_PhotoHeight + 100;
            setPictureSizeAndPosition(photo);
            setPictureDetails(photo);
        }

        private int calcHeightByratio(Photo i_Photo)
        {
            int height;

            int imageHeight = 300;
            int imageWidth = 200;

            try
            {
                imageHeight = i_Photo.ImageNormal.Height;
                imageWidth = i_Photo.ImageNormal.Width;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            float imageRatio = imageHeight / (float)imageWidth;
            height = (int)(k_PhotoWidth * imageRatio);

            return height;
        }

        private void setPictureSizeAndPosition(Photo i_Photo)
        {
            wallPhotoPictureBox.Width = k_PhotoWidth;
            wallPhotoPictureBox.Height = r_PhotoHeight;

            try
            {
                wallPhotoPictureBox.Image = i_Photo.ImageNormal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            wallPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            wallPhotoPictureBox.Left = this.Left;
            wallPhotoPictureBox.Top = DateIcon.Bottom + 5;
        }

        //Insert demmy data
        private void setPictureDetails(Photo i_Photo)
        {
            labelDate.Text = i_Photo.CreatedTime.Value.ToString("MMMM dd");

            // labelLikes.Text = i_Photo.LikedBy.Count().ToString();

            labelLikes.Text = "267";

            //labelLikes.Text = i_Photo.LikedBy.Count().ToString();

            labelLocation.Text = "IDC, Herzeliya";
        }     
    }
}
