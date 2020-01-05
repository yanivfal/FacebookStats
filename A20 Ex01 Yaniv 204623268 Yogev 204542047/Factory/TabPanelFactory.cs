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
        private static List<WallPhoto> m_CurrentPhotoOnWall = new List<WallPhoto>();

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
            centeringAllControls(i_FreindsListTabPage, i_FreindsListTabPage.Width);
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
                m_CurrentPhotoOnWall.Add(photoComponent);
                if (++numOfFetchedPhoto >= 3)
                {
                    break;
                }
            }
        }

        //Demmy data
        public static void CreateEventsTabPage(ref TabPage i_EventsTabPage)
        {
            centeringAllControls(i_EventsTabPage, i_EventsTabPage.Width);
            int position = i_EventsTabPage.Top + 60;
            EventComponent eventComponent1 = new EventComponent();
            createEventDammyData(ref eventComponent1, "2020 celebrations", "IDC", "01/01/20",
                "00:00", "03:00", position);
            position = eventComponent1.Bottom + 20;
            centeringControl(eventComponent1, i_EventsTabPage.Width);

            EventComponent eventComponent2 = new EventComponent();
            createEventDammyData(ref eventComponent2, "Omer Adam Show", "Keisariya", "18/01/20",
                "20:00", "22:00", position);
            position = eventComponent2.Bottom + 20;
            centeringControl(eventComponent2, i_EventsTabPage.Width);

            EventComponent eventComponent3 = new EventComponent();
            createEventDammyData(ref eventComponent3, "Yogev Wedding", "Mikonos", "?/?/?",
                "20:00", "05:00", position);
            centeringControl(eventComponent3, i_EventsTabPage.Width);

            i_EventsTabPage.Controls.Add(eventComponent1);
            i_EventsTabPage.Controls.Add(eventComponent2);
            i_EventsTabPage.Controls.Add(eventComponent3);
        }

        private static void createEventDammyData(ref EventComponent i_Event, string i_EventName,
            string i_Location, string i_Date, string i_Start, string i_End, int i_Position)
        {
            i_Event.labelEventName.Text = string.Format("{0}", i_EventName);
            i_Event.labelEventLocation.Text = string.Format("{0}{1}", "Location: ", i_Location);
            i_Event.labelEventDate.Text = string.Format("{0}{1}", "Date: ", i_Date);
            i_Event.labelEventStartt.Text = string.Format("{0}{1}", "Starts at: ", i_Start);
            i_Event.labelEventEnd.Text = string.Format("{0}{1}", "Ends at: ", i_End);
            i_Event.Top = i_Position;
        }

        private static void clearWall(ref TabPage i_WallTabPage)
        {
            foreach (WallPhoto photo in m_CurrentPhotoOnWall)
            {
                 i_WallTabPage.Controls.Remove(photo);
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
