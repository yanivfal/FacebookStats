using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    internal class WallTabPage : TabPage
    {
        private List<WallPhotoComponent> m_WallPhotosList = new List<WallPhotoComponent>();
        private ComboBox m_AlbumsComboBox;

        public WallTabPage(string i_TabText) : base(i_TabText)
        {   
            InitializeComponent();
            fetchPhotosOnWall(m_AlbumsComboBox.Items[0].ToString());
        }

        private void fetchPhotosOnWall(string i_AlbumToFetch)
        {
            clearWall();
            int position = this.Top + 60;
            int numOfFetchedPhoto = 0;
            FacebookObjectCollection<Photo> wallPictures = FBAgent.GetAlbumPhotosByName(i_AlbumToFetch);

            foreach (Photo photo in wallPictures)
            {
                WallPhotoComponent photoComponent = new WallPhotoComponent(photo);
                photoComponent.Top = position;
                position = photoComponent.Bottom + 30;
                //photoComponent.Left = (this.Width) / 2 - (photoComponent.Width / 2);
                this.Controls.Add(photoComponent);
                m_WallPhotosList.Add(photoComponent);
                if (++numOfFetchedPhoto >= 3)
                {
                    break;
                }
            }

            ControlsUtils.CenteringAllControls(this);
        }

        private void clearWall()
        {
            foreach (WallPhotoComponent photo in m_WallPhotosList)
            {
                this.Controls.Remove(photo);
            }

            m_WallPhotosList.Clear();
        }

        private void InitializeComponent()
        {
            //
            //this
            //
            this.AutoScroll = true;
            this.Height = AppSettings.Instance.MainWindowHeight;
            this.Width = AppSettings.Instance.MainWindowWidth;

            // 
            // m_AlbumsComboBox
            // 
            this.m_AlbumsComboBox = new ComboBox();
            this.SuspendLayout();
            
            this.m_AlbumsComboBox.FormattingEnabled = true;
            this.m_AlbumsComboBox.Location = new System.Drawing.Point(0, 0);
            this.m_AlbumsComboBox.Name = "m_AlbumsComboBox";
            this.m_AlbumsComboBox.Size = new System.Drawing.Size(121, 28);
            this.m_AlbumsComboBox.TabIndex = 0;
            this.m_AlbumsComboBox.SelectedValueChanged += new EventHandler(this.albumComboBox_SelectedValueChanged);
            this.ResumeLayout(false);
            this.m_AlbumsComboBox.Top = this.Top + 10;
            this.m_AlbumsComboBox.Left = (this.Width) / 2 - (m_AlbumsComboBox.Width / 2);
            this.m_AlbumsComboBox.Items.AddRange(FBAgent.GetAlbumsNames().ToArray());

            this.Controls.Add(m_AlbumsComboBox);
        }

        private void albumComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            fetchPhotosOnWall(m_AlbumsComboBox.SelectedItem.ToString());
        }
    }
}