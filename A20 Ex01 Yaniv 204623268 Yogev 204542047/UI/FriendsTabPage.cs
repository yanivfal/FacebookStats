using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    internal class FriendsTabPage : TabPage
    {
        List<FriendComponent> FriendsList;

        internal FriendsTabPage(string i_TabText) : base(i_TabText)
        {
            this.Width = AppSettings.Instance.MainWindowWidth;
            this.Height = AppSettings.Instance.MainWindowHeight;
            FriendsList = new List<FriendComponent>();

            fetchFriends();
            ControlsUtils.CenteringAllControls(this);
        }

        private void fetchFriends()
        {
            int position = 50;
            FacebookObjectCollection<User> userFriends = FBAgent.LoggedInUser.Friends;

            for (int i = 0; i < userFriends.Count && i < 6; i++)
            {
                FriendComponent friendComponent = new FriendComponent(userFriends[i]);
                friendComponent.Top = position;
                FriendsList.Add(friendComponent);
                position += 20;
                this.Controls.Add(friendComponent);
            }
        }
    }
}
