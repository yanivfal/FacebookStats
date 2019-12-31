using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    public partial class FriendComponent : UserControl
    {
        public FriendComponent(User friend)
        {
            InitializeComponent();
            this.friendImage.Image = friend.ImageNormal;
            this.friendName.Text = friend.Name;
        }
    }
}
