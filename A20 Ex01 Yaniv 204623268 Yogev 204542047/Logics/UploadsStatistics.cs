using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics
{
    class UploadsStatistics
    {
        private static Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_LoggedInUserLikes = null;

        public static int GetLikesAmount(DayOfWeek i_Day, eDayParts i_DayPart)
        {
            if(m_LoggedInUserLikes == null)
            {
                m_LoggedInUserLikes = Utils.GetUserLikesAmountByDayAndDayPart();
            }

            Dictionary<eDayParts, int> currentDayLikes;
            int currentDayPartLikes = 0;
            /*
            if (!m_LoggedInUserLikes.TryGetValue(i_Day, out currentDayLikes))
            {
                throw new Exception("Day not found.");
            }

            if (!currentDayLikes.TryGetValue(i_DayPart, out currentDayPartLikes))
            {
                throw new Exception("Day part not found.");
            }*/

            return currentDayPartLikes;
        }
    }
}
