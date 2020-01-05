using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Proxy
{
    internal class PictureBoxProxy : PictureBox
    {
        private int m_PictureWidth;

        public PictureBoxProxy(Photo i_Photo, int i_PictureWidth)
        {
            m_PictureWidth = i_PictureWidth;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Image = i_Photo.ImageNormal;
            Height = calcHeightByratio(i_Photo);
            Width = m_PictureWidth;
        }

        private int calcHeightByratio(Photo i_Photo)
        {
            int imageHeight = m_PictureWidth;
            int imageWidth = m_PictureWidth;

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
            int height = (int)(m_PictureWidth * imageRatio);

            return height;
        }
    }
}
