using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Facades
{
    public class MainFormFacade
    {
        public string UserName { get; set; }
        public Image ProfilePicture { get; set; }
        public List<string> UserAlbums { get; set; }

        public MainFormFacade()
        {
            UserName = FBAgent.LoggedInUser.Name;
            ProfilePicture = FBAgent.LoggedInUser.ImageNormal;
            UserAlbums = FBAgent.GetAlbumsNames();
            //UserAlbums = new BindingSource();
            // UserAlbums.DataSource = FBAgent.GetAlbumsNames();
        }
    }
}
