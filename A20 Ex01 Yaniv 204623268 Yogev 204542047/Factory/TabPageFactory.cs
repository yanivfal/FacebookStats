using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.UI;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Factory
{
    public class TabPageFactory
    {
        public TabPage CreateTabPage(eTabPage i_TabPageToCreate)
        {
            TabPage tabPageToReturn = null;

            switch(i_TabPageToCreate)
            {
                case eTabPage.Events:
                    tabPageToReturn = new EventsTabPage("Events");
                    break;
                case eTabPage.Friends:
                    tabPageToReturn = new FriendsTabPage("Friends");
                    break;
                case eTabPage.Horoscope:
                    tabPageToReturn = new HoroscopeTabPage("Horoscope");
                    break;
                case eTabPage.LikesDistribution:
                    tabPageToReturn = new LikesDistributionTabPage("Likes Distribution");
                    break;
                case eTabPage.WallPhotos:
                    tabPageToReturn = new WallTabPage("Wall");
                    break;
            }

            return tabPageToReturn;
        }
    }
}
