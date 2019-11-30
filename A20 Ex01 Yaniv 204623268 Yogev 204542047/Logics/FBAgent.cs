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

            loginResult = FacebookService.Login("2731122040258680", "name", "albums");
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
