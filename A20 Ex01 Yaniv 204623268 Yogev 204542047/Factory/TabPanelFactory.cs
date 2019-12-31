using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Factory
{
    public class TabPanelFactory
    {
        public static void CreateHoroscopeTabPage(ref TabPage i_HoroscopeTabPage)
        {
            HoroscopeForm horoscopeForm = new HoroscopeForm();
            horoscopeForm.TopLevel = false;
            horoscopeForm.Visible = true;
            horoscopeForm.FormBorderStyle = FormBorderStyle.None;
            horoscopeForm.Height = i_HoroscopeTabPage.Height;
            horoscopeForm.Width = i_HoroscopeTabPage.Width;
            centeringAllControls(horoscopeForm, i_HoroscopeTabPage.Width);

            i_HoroscopeTabPage.Controls.Add(horoscopeForm);
        }

        public static void CreateLikesDistTabPage(ref TabPage i_LikesDistTabPage)
        {
            LikesDistributionForm likesDistForm = new LikesDistributionForm();
            likesDistForm.TopLevel = false;
            likesDistForm.Visible = true;
            likesDistForm.FormBorderStyle = FormBorderStyle.None;
            likesDistForm.Width = i_LikesDistTabPage.Width;

            i_LikesDistTabPage.Controls.Add(likesDistForm);
        }

        public static void CreateWallTabPage(ref TabPage i_WallTabPage, string i_SelectedAlbum)
        {
            clearWall(ref i_WallTabPage);
            int position = i_WallTabPage.Top + 100;
            int numOfFetchedPhoto = 0;
            FacebookObjectCollection<Photo> wallPictures = FBAgent.GetAlbumPhotosByName(i_SelectedAlbum);

            foreach (Photo photo in wallPictures)
            {
                WallPhoto photoComponent = new WallPhoto(photo);
                photoComponent.Top = position;
                position = photoComponent.Bottom + 30;
                photoComponent.Left = (i_WallTabPage.Width) / 2 - (photoComponent.Width / 2);
                i_WallTabPage.Controls.Add(photoComponent);
                if (++numOfFetchedPhoto >= 3)
                {
                    break;
                }
            }
        }

        private static void clearWall(ref TabPage i_WallTabPage)
        {
            foreach (WallPhoto photo in i_WallTabPage.Controls)
            {
                i_WallTabPage.Controls.Remove(photo);
            }
        }

        private static void centeringAllControls(Form i_FormToCentering, int i_TabPageWidth)
        {
            // Move all the controls to the center
            foreach (Control control in i_FormToCentering.Controls)
            {
                control.Left = i_TabPageWidth / 2 - (control.Width / 2);
            }
        }
    }
}
