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
    internal class FriendsTabPage : TabPage
    {
        List<FriendComponent> FriendsList;

        public FriendsTabPage(string i_TabText) : base(i_TabText)
        {
            this.Width = 500;
            this.Height = 500;
            FriendsList = new List<FriendComponent>();
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

            foreach (Control control in this.Controls)
            {
                control.Left = this.Width / 2 - (control.Width / 2);
            }
        }
    }
}
