using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.settings;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics
{
    public static class FBAgent
    {
        internal static User LoggedInUser { get; set; }

        public static bool LoginAndInit(out string o_AccessToken)
        {
            LoginResult loginResult;
            bool isLoginSucceeded = true;
            o_AccessToken = null;

            //loginResult = FacebookService.Login("2731122040258680", "name", "albums");
            loginResult = FacebookService.Login("2731122040258680",

            "public_profile",
            "email",
            "publish_to_groups",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "publish_to_groups",
            "groups_access_member_info",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown"

            );
            //loginResult = FacebookService.Connect(AccessTokenForTest.Access_Token);
            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                o_AccessToken = loginResult.AccessToken;
                LoggedInUser = loginResult.LoggedInUser;
            }
            else
            {
                isLoginSucceeded = false;
            }

            return isLoginSucceeded;
        }
    } 
}
