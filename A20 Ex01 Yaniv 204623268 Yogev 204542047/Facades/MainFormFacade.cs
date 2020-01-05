using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System.Collections.Generic;
using System.Drawing;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Facades
{
    public class MainFormFacade
    {
        public string UserName { get; set; }
        public Image ProfilePicture { get; set; }
        public List<string> UserAlbums { get; set; }
        public string SelectedAlbum { get; set; }

        public MainFormFacade()
        {
            UserName = FBAgent.LoggedInUser.Name;
            ProfilePicture = FBAgent.LoggedInUser.ImageNormal;
            UserAlbums = FBAgent.GetAlbumsNames();
            SelectedAlbum = UserAlbums[0];
        }
    }
}
