using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    class Utils
    {
        internal static List<Photo> GetPhotosBetweenDates(DateTime i_DateFrom, DateTime i_DateTo)
        {
            List<Photo> photos = new List<Photo>();

            foreach (Album album in FBAgent.LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (i_DateFrom <= photo.CreatedTime && photo.CreatedTime <= i_DateTo)
                    {
                        photos.Add(photo);
                    }
                }
            }

            return photos;
        }

        internal static Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> GetUserLikesAmountByDayAndDayPart()
        {
            Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> daysLikes = new Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>>();

            foreach (Album album in FBAgent.LoggedInUser.Albums)
            //Album album = FBAgent.LoggedInUser.Albums[0];
            {
                foreach (Photo photo in album.Photos)
                {
                    DayOfWeek currentDay = photo.CreatedTime.Value.DayOfWeek;
                    eDayParts currentDayPart = getCurrentDayPart(photo.CreatedTime.Value.Hour);

                    if (!daysLikes.Keys.Contains(currentDay))
                    {
                        daysLikes[currentDay] = new Dictionary<eDayParts, PhotosGroupInfo>();
                    }
                    if (!daysLikes[currentDay].Keys.Contains(currentDayPart))
                    {
                        daysLikes[currentDay][currentDayPart] = new PhotosGroupInfo();
                    }

                    daysLikes[currentDay][currentDayPart].LikesAmount += photo.LikedBy.Count;
                    daysLikes[currentDay][currentDayPart].PhotosAmount++;
                }
            }

            return daysLikes;
        }

        private static eDayParts getCurrentDayPart(int i_Hour)
        {
            eDayParts currentDayPart;

            switch (i_Hour)
            {
                case int hour when (6 <= hour && hour < 10):
                    currentDayPart = eDayParts.Morning;
                    break;

                case int hour when (10 < hour && hour <= 16):
                    currentDayPart = eDayParts.Noon;
                    break;

                case int hour when (16 < hour && hour <= 20):
                    currentDayPart = eDayParts.Afternoon;
                    break;

                default:
                    currentDayPart = eDayParts.Evening;
                    break;
            }

            return currentDayPart;
        }
    }
}
