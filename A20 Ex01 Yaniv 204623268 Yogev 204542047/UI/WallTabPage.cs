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
        private List<WallPhotoComponent> m_WallPhotosList = new List<WallPhotoComponent>();
        private ComboBox m_AlbumsComboBox;
        // Need to add selectedAlbum
        public WallTabPage(string i_TabText) : base(i_TabText)
        {
            this.AutoScroll = true;
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
                m_WallPhotosList.Add(photoComponent);
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
            foreach (WallPhotoComponent photo in m_WallPhotosList)
            {
                this.Controls.Remove(photo);
            }
        }
    }
}