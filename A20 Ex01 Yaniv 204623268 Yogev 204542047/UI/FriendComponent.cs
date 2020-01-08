using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    public partial class FriendComponent : UserControl
    {
        public FriendComponent(User i_Friend)
        {
            InitializeComponent();
            this.friendImage.Image = i_Friend.ImageNormal;
            this.friendName.Text = i_Friend.Name;
        }
    }
}
