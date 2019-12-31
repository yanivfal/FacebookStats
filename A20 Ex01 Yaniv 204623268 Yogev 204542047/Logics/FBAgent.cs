using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics
{
    internal static class FBAgent
    {
        internal static User LoggedInUser { get; set; }

        internal static bool LoginAndInit(out string o_AccessToken)
        {
            LoginResult loginResult = null;
            bool isLoginSucceeded = false;
            o_AccessToken = null;

            try
            {
                loginResult = FacebookService.Login("2731122040258680", "public_profile", "user_birthday", "user_photos", "user_events");

                if (!string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    isLoginSucceeded = true;
                    o_AccessToken = loginResult.AccessToken;
                    LoggedInUser = loginResult.LoggedInUser;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isLoginSucceeded;
        }

        internal static List<string> GetAlbumsNames()
        {
            List<string> albumList = new List<string>();

            foreach (Album album in FBAgent.LoggedInUser.Albums)
            {
                if (album.Photos.Count != 0)
                {
                    albumList.Add(album.Name);
                }
            }

            return albumList;
        }

        internal static LoginResult Connect(string i_LastAccessToken)
        {
            LoginResult result = null;

            try
            {
                result = FacebookService.Connect(AppSettings.Instance.LastAccessToken);
                LoggedInUser = result.LoggedInUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return result;
        }

        internal static FacebookObjectCollection<Photo> GetAlbumPhotosByName(string i_AlbumName)
        {
            FacebookObjectCollection<Photo> photos = null;

            foreach (Album album in LoggedInUser.Albums)
            {
                if (i_AlbumName.Equals(album.Name))
                {
                    photos = album.Photos;
                    break;
                }
            }

            return photos;
        }
    }
}
