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
            List<RelativeUserDetails> relativeUserLikesDetails = Utils.GetUsersLikesInPhotos(photos);

            int yPos = 350;

            foreach (RelativeUserDetails relatedUser in relativeUserLikesDetails)
            {
                PictureBox picture = new PictureBox();
                picture.Image = relatedUser.User.ImageNormal;
                picture.Top = yPos;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Height = 200;
                picture.Width = 200;

                Label label = new Label();
                label.Text = string.Format("Likes - {0}", relatedUser.Likes);
                label.Top = yPos;
                label.Left = 250;

                this.Controls.Add(picture);
                this.Controls.Add(label);

                yPos += 205;
            }
        }
    }
}
