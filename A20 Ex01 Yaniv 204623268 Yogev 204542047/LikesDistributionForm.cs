using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class LikesDistributionForm : Form
    {
        private Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_UserAmountOfLikesStatistics;
        private int m_UserMinLikes;
        private int m_UserMaxLikes;

        public LikesDistributionForm()
        {
            m_UserAmountOfLikesStatistics = LikesDistributionUtils.GetUserLikesAmountByDayAndDayPart();
            m_UserMinLikes = 0;
            m_UserMaxLikes = 200;

            InitializeComponent();
            InitializeLocationAndSize();

            setTableInfo();
        }

        private void InitializeLocationAndSize()
        {
            this.Width = StatsTable.Width + 50;
            this.Height = StatsTable.Height + 200;
            labelTitle.Left = (this.Width) / 2 - (labelTitle.Width / 2);
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

                        cellLabel.Text = string.Format(likesAvg.ToString());
                        cellLabel.ForeColor = getColorByLikesAmount(likesAvg);
                    }

                    StatsTable.Controls.Add(cellLabel, (int) dayPart + 1, (int)day + 1);
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
                    color = Color.Firebrick;
                    break;
                case float likesAverage when (m_UserMinLikes + (range / 3) * 1 <= likesAverage && likesAverage < m_UserMinLikes + (range / 3) * 2):
                    color = Color.DarkOrange;
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
