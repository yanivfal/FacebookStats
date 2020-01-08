using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    class LikesDistributionTabPage : TabPage
    {
        private Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_UserAmountOfLikesStatistics;
        private int m_UserMinLikes;
        private int m_UserMaxLikes;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartLikeDist;
        Label labelTitle = new Label();



        public LikesDistributionTabPage(string i_TabText) : base(i_TabText)
        {
            m_UserAmountOfLikesStatistics = LikesDistributionUtils.GetUserLikesAmountByDayAndDayPart();
            m_UserMinLikes = 0;
            m_UserMaxLikes = 200;

            InitializeComponent();
            //InitializeLocationAndSize();

            //setTableInfo();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_ChartLikeDist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartLikeDist)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ChartLikeDist
            // 
            chartArea1.Name = "ChartArea1";
            this.m_ChartLikeDist.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.m_ChartLikeDist.Legends.Add(legend1);
            this.m_ChartLikeDist.Location = new System.Drawing.Point(0, 0);
            this.m_ChartLikeDist.Name = "m_ChartLikeDist";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Like amount";
            this.m_ChartLikeDist.Series.Add(series1);
            this.m_ChartLikeDist.Size = new System.Drawing.Size(300, 300);
            this.m_ChartLikeDist.TabIndex = 0;
            this.m_ChartLikeDist.Text = "chart1";
            // 
            // LikesDistributionTabPage
            // 
            this.Controls.Add(this.m_ChartLikeDist);
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartLikeDist)).EndInit();
            this.ResumeLayout(false);

        }

        //private void setTableInfo()
        //{
        //    Random rnd = new Random();
        //    foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
        //    {
        //        foreach (eDayParts dayPart in Enum.GetValues(typeof(eDayParts)))
        //        {
        //            Label cellLabel = new Label() { Text = "-", Font = new Font("Levenim MT", 14) };

        //            if (m_UserAmountOfLikesStatistics.ContainsKey(day) && m_UserAmountOfLikesStatistics[day].ContainsKey(dayPart))
        //            {
        //                float likesAvg = m_UserAmountOfLikesStatistics[day][dayPart].LikesAmount / (float)m_UserAmountOfLikesStatistics[day][dayPart].PhotosAmount;
        //                if (likesAvg == 0)
        //                {
        //                    likesAvg = rnd.Next(m_UserMinLikes, m_UserMaxLikes);
        //                }

        //                cellLabel.Text = string.Format(likesAvg.ToString());
        //                cellLabel.ForeColor = getColorByLikesAmount(likesAvg);
        //            }

        //            StatsTable.Controls.Add(cellLabel, (int)dayPart + 1, (int)day + 1);
        //        }
        //    }
        //}

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
