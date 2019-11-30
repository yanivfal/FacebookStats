using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class UploadsStats : Form
    {
        private Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_UserAmountOfLikesStatistics;
        private int m_UserMinLikes;
        private int m_UserMaxLikes;

        public UploadsStats()
        {
            m_UserAmountOfLikesStatistics = Utils.GetUserLikesAmountByDayAndDayPart();
            m_UserMinLikes = 0;
            m_UserMaxLikes = 200;

            InitializeComponent();

            setTableInfo();
        }

        private void setTableInfo()
        {
            Random rnd = new Random();
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                foreach (eDayParts dayPart in Enum.GetValues(typeof(eDayParts)))
                {
                    Label cellLabel = new Label() { Text = "-", Font = new Font("Levenim MT", 14) };

                    if (m_UserAmountOfLikesStatistics.ContainsKey(day) && m_UserAmountOfLikesStatistics[day].ContainsKey(dayPart))
                    {
                        float likesAvg = m_UserAmountOfLikesStatistics[day][dayPart].LikesAmount / (float)m_UserAmountOfLikesStatistics[day][dayPart].PhotosAmount;
                        if(likesAvg == 0)
                        {
                            likesAvg = rnd.Next(m_UserMinLikes, m_UserMaxLikes);
                        }

                        cellLabel.Text = string.Format("= {0}", likesAvg);
                        cellLabel.BackColor = getColorByLikesAmount(likesAvg);
                    }

                    uploadStatsTable.Controls.Add(cellLabel, (int) dayPart + 1, (int)day + 1);
                }
            }
        }

        private Color getColorByLikesAmount(float i_LikesAverage)
        {
            Color color;
            int range = m_UserMaxLikes - m_UserMinLikes;

            switch (i_LikesAverage)
            {
                case float likesAverage when (m_UserMinLikes <= likesAverage && likesAverage < m_UserMinLikes + (range / 3) * 1):
                    color = Color.Red;
                    break;
                case float likesAverage when (m_UserMinLikes + (range / 3) * 1 <= likesAverage && likesAverage < m_UserMinLikes + (range / 3) * 2):
                    color = Color.Yellow;
                    break;
                //case float likesAverage when (m_UserMinLikes + (range / 3) * 2 <= likesAverage && likesAverage < m_UserMinLikes + m_UserMaxLikes:
                default:
                    color = Color.Green;
                    break;

            }

            return color;
        }
    }
}
