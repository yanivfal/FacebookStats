using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Proxy
{

    internal class PictureBoxProxy : PictureBox
    {
        private const int k_PhotoWidth = 400;

        public PictureBoxProxy(Photo i_Photo)
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Image = i_Photo.ImageNormal;
            Height = calcHeightByratio(i_Photo);
        }

        private int calcHeightByratio(Photo i_Photo)
        {
            int imageHeight = k_PhotoWidth;
            int imageWidth = k_PhotoWidth;

            try
            {
                imageHeight = i_Photo.ImageNormal.Height;
                imageWidth = i_Photo.ImageNormal.Width;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            float imageRatio = imageHeight / (float)imageWidth;
            int height = (int)(k_PhotoWidth * imageRatio);

            return height;
        }
    }
}
