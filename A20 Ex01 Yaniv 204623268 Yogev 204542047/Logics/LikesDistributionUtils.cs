using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    class LikesDistributionUtils
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

        internal static List<RelativeUserDetails> GetUsersLikesInPhotos(List<Photo> i_Photos)
        {
            List<RelativeUserDetails> relativeUserLikes = new List<RelativeUserDetails>();
            Dictionary<string, RelativeUserDetails> relativeUsersDetails = new Dictionary<string, RelativeUserDetails>();

            foreach (Photo photo in i_Photos)
            {
                for(int i=0; i<5 && i < FBAgent.LoggedInUser.Friends.Count; i++)
                {
                    User user = FBAgent.LoggedInUser.Friends[i];
                //LikeBy - depcrated, we show the friends instead
                //foreach (User user in photo.LikedBy)
                //{
                    if (!relativeUsersDetails.ContainsKey(user.Id))
                    {
                        relativeUsersDetails[user.Id] = new RelativeUserDetails(user);
                    }

                    relativeUsersDetails[user.Id].Likes++;
                }
            }

            foreach (KeyValuePair<string, RelativeUserDetails> relatedUser in relativeUsersDetails)
            { 
                relativeUserLikes.Add(relatedUser.Value);
            }

            relativeUserLikes.Sort((i_User1, i_User2) => (i_User1.Likes).CompareTo(i_User2.Likes));

            return relativeUserLikes;
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
