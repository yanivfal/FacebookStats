using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    public partial class FriendsForm : Form
    {
        public FriendsForm()
        {
            InitializeComponent();
            fetchFriends();
        }

        private void fetchFriends()
        {
            int cols = this.friendsTable.ColumnCount;

            FacebookObjectCollection<User> userFriends = FBAgent.LoggedInUser.Friends;
            for (int i = 0; i < userFriends.Count && i < 6; i++)
            {
                User friend = userFriends[i];
                FriendComponent friendComponent = new FriendComponent(friend);
                this.friendsTable.Controls.Add(friendComponent, i/cols, i%cols);

            }
        }
    }
}
