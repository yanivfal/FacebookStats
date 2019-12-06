using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    internal class RelativeUserDetails
    {
        private User m_User;

        internal User User { get { return m_User; } }
        internal int Likes { get; set; }

        internal RelativeUserDetails(User i_User)
        {
            m_User = i_User;
            Likes = 0;
        }
    }
}
