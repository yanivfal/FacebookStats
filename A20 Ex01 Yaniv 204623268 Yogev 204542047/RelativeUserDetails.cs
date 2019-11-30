using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    class RelativeUserDetails
    {
        private User m_User;

        public User User { get { return m_User; } }
        public int Likes { get; set; }

        public RelativeUserDetails(User i_User)
        {
            m_User = i_User;
            Likes = 0;
        }
    }
}
