using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.UI;
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

        public static void CreateFreindsListTabPage(ref TabPage i_FreindsListTabPage)
        {
            FriendsForm freindsForm = new FriendsForm();
            freindsForm.TopLevel = false;
            freindsForm.Visible = true;
            freindsForm.FormBorderStyle = FormBorderStyle.None;
            freindsForm.Width = i_FreindsListTabPage.Width;
            freindsForm.Height = i_FreindsListTabPage.Height;

            i_FreindsListTabPage.Controls.Add(freindsForm);
        }

        public static void CreateWallTabPage(ref TabPage i_WallTabPage, string i_SelectedAlbum)
        {
            clearWall(ref i_WallTabPage);
            int position = i_WallTabPage.Top + 60;
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

        public static void CreateEventsTabPage(ref TabPage i_EventsTabPage)
        {
            int position = i_EventsTabPage.Top + 60;
            int numOfFetchedPhoto = 0;
            FacebookObjectCollection<Event> userEvents = FBAgent.LoggedInUser.Events;

            foreach (Event fbEvent in userEvents)
            {
                EventComponent eventComponent = new EventComponent(fbEvent);
                eventComponent.Top = position;
                position = eventComponent.Bottom + 30;
                eventComponent.Left = (i_EventsTabPage.Width) / 2 - (eventComponent.Width / 2);
                i_EventsTabPage.Controls.Add(eventComponent);
                if (++numOfFetchedPhoto >= 3)
                {
                    break;
                }
            }
        }

        private static void clearWall(ref TabPage i_WallTabPage)
        {
            foreach (Control photo in i_WallTabPage.Controls)
            {
                if (photo is WallPhoto)
                {
                    i_WallTabPage.Controls.Remove(photo);
                } 
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
