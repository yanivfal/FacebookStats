using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class LikesStatisticsForm : Form
    {
        public LikesStatisticsForm()
        {
            InitializeComponent();
        }

        private void checkLikesButton_Click(object sender, EventArgs e)
        {
            List<Photo> photos = Utils.GetPhotosBetweenDates(this.likesFromDate.Value, this.likesToDate.Value);
            //Dictionary<String, User> 
            //photos[0].LikedBy[];
            photos.Sort((i_Image1, i_Image2) => (i_Image1.LikedBy.Count).CompareTo(i_Image2.LikedBy.Count));
            int yPos = 350;
            foreach (Photo photo in photos)
            {
                PictureBox picture = new PictureBox();
                picture.Image = photo.ImageNormal;
                picture.Top = yPos;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Height = 200;
                picture.Width = 200;

                Label label = new Label();
                label.Text = string.Format("Likes - {0}", photo.LikedBy.Count);
                label.Top = yPos;
                label.Left = 250;

                this.Controls.Add(picture);
                this.Controls.Add(label);

                yPos += 205;
            }
        }
    }
}
