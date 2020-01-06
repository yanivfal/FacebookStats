using System;
using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Proxy
{
    internal class PictureBoxProxy : PictureBox
    {
        private float ImageRatio { get; set; }

        public new Image Image
        {
            get
            {
                return base.Image;
            }
            set
            {
                base.Image = value;
                if (value != null)
                {
                    ImageRatio = calcRatio(this.Image);
                }              
            }
        }

        public new int Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
                if (Image != null)
                {
                    FixResolution();
                }
            }
        }

        public PictureBoxProxy() : base()
        {
        }

        private void FixResolution()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Height = (int)(base.Width * ImageRatio);
        }

        private float calcRatio(Image i_Photo)
        {
            float imageRatio;
            int imageHeight = i_Photo.Width;
            int imageWidth = i_Photo.Width;

            try
            {
                imageHeight = i_Photo.Height;
                imageWidth = i_Photo.Width;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            imageRatio = imageHeight / (float)imageWidth;

            return imageRatio;
        }
    }
}
