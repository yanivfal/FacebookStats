using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    internal class WallTabPage : TabPage
    {
        List<WallPhotoComponent> WallPhotosList = new List<WallPhotoComponent>();
        ComboBox m_AlbumsComboBox;

        public WallTabPage()
        {
            this.Height = 685;
            this.Width = 944;
            initializeAlbumsComboBox();
            fetchPhotosOnWall();
        }

        private void fetchPhotosOnWall()
        {
            clearWall();
            int position = this.Top + 60;
            int numOfFetchedPhoto = 0;
            FacebookObjectCollection<Photo> wallPictures = FBAgent.GetAlbumPhotosByName(m_AlbumsComboBox.Items[0].ToString());

            foreach (Photo photo in wallPictures)
            {
                WallPhotoComponent photoComponent = new WallPhotoComponent(photo);
                photoComponent.Top = position;
                position = photoComponent.Bottom + 30;
                photoComponent.Left = (this.Width) / 2 - (photoComponent.Width / 2);
                this.Controls.Add(photoComponent);
                WallPhotosList.Add(photoComponent);
                if (++numOfFetchedPhoto >= 3)
                {
                    break;
                }
            }
        }

        private void initializeAlbumsComboBox()
        {
            //Create ComboBox
            m_AlbumsComboBox = new ComboBox();
            m_AlbumsComboBox.Items.AddRange(FBAgent.GetAlbumsNames().ToArray());
        }

        private void clearWall()
        {
            foreach (WallPhotoComponent photo in WallPhotosList)
            {
                this.Controls.Remove(photo);
            }
        }

        private static void centeringAllControls(Form i_FormToCentering, int i_TabPageWidth)
        {
            // Move all the controls to the center
            foreach (Control control in i_FormToCentering.Controls)
            {
                centeringControl(control, i_TabPageWidth);
            }
        }

        private static void centeringAllControls(TabPage i_TabPageToCentering, int i_TabPageWidth)
        {
            // Move all the controls to the center
            foreach (Control control in i_TabPageToCentering.Controls)
            {
                centeringControl(control, i_TabPageWidth);
            }
        }

        private static void centeringControl(Control i_ControlToCentering, int i_TabPageWidth)
        {
            // Move controls to the center
            i_ControlToCentering.Left = i_TabPageWidth / 2 - (i_ControlToCentering.Width / 2);
        }
    }
}
