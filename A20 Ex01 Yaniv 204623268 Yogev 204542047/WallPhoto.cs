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
            initializePhotoProperties(i_Photo);
        }

        private void initializePhotoProperties(Photo photo)
        {
            this.Width = k_PhotoWidth;
            this.Height = r_PhotoHeight + 100;
            setPictureSizeAndPosition(photo);
            setPictureDetails(photo);
        }

        private int calcHeightByratio(Photo i_Photo)
        {
            int height;

            float imageRatio = i_Photo.ImageNormal.Height / (float) i_Photo.ImageNormal.Width;
            height = (int)(k_PhotoWidth * imageRatio);

            return height;
        }

        private void setPictureSizeAndPosition(Photo i_Photo)
        {
            wallPhotoPictureBox.Width = k_PhotoWidth;
            wallPhotoPictureBox.Height = r_PhotoHeight;
            wallPhotoPictureBox.Image = i_Photo.ImageNormal;
            wallPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            wallPhotoPictureBox.Left = this.Left;
            wallPhotoPictureBox.Top = DateIcon.Bottom + 5;
        }

        private void setPictureDetails(Photo i_Photo)
        {
            //Insert dummy data
            labelDate.Text = i_Photo.CreatedTime.Value.ToString("MMMM dd");
            //labelLikes.Text = i_Photo.LikedBy.Count().ToString
            labelLikes.Text = "267";
            //labelLikes.Text = i_Photo.LikedBy.Count().ToString
            labelLocation.Text = "IDC, Herzeliya";
        }
    }
}
