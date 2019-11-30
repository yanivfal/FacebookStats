using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            // loginResult = FacebookService.Login("2731122040258680", "name", "albums");
            loginResult = FacebookService.Connect("EAAmz8OcMQHgBAN1VM2Kccomr3ftEr8Ftr9WAp2yXkQ6gBoSKLc3KimP8I1cdVAhRREBZC31b2BZA7MhYUyk9wPaAZB1H3Ud9viIulWXar5LE1puY8jNl4wwtyFEshFfAGGHJ5iu4yyp6yzlPAUR6lVJJROHjbIihRRlWh60ZBA1yowI6EhA86BXgRcBZCEVcZD");
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
