using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    internal class LikesDistributionTabPage : TabPage
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartLikeDist;
        private Label m_LabelTitle;

        //In case of real data
        //private Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_UserAmountOfLikesStatistics;
        //private int m_UserMinLikes;
        //private int m_UserMaxLikes;

        public LikesDistributionTabPage(string i_TabText) : base(i_TabText)
        {  
            initializeComponent();
            initializeLocation();
            addCulomnToChart();

            //In case of real data
            //m_UserAmountOfLikesStatistics = LikesDistributionUtils.GetUserLikesAmountByDayAndDayPart();
            //m_UserMinLikes = 0;
            //m_UserMaxLikes = 200;
            //setTableInfo();
        }

        private void initializeLocation()
        {
            this.m_LabelTitle.Top = this.Top + 20;
            this.m_ChartLikeDist.Top = m_LabelTitle.Bottom + 20;
            ControlsUtils.CenteringAllControls(this);
        }

        private void addCulomnToChart()
        {
            //Dummy
            int [] MorningValueArr = new int[] { 10, 20, 30, 30, 40, 50 , 80 };
            int[] NoonValueArr = new int[] { 40, 50, 70, 30, 80, 90, 20 };
            int[] EveningValueArr = new int[] { 120, 100, 80, 90, 150, 188, 130 };

            //Array.Sort(arr);

            m_ChartLikeDist.Series[0].Points.DataBindY(MorningValueArr);
            m_ChartLikeDist.Series[1].Points.DataBindY(NoonValueArr);
            m_ChartLikeDist.Series[2].Points.DataBindY(EveningValueArr);
            m_ChartLikeDist.ChartAreas[0].AxisX.CustomLabels.Add(0.5, 1.5, "Sunday");
            m_ChartLikeDist.ChartAreas[0].AxisX.CustomLabels.Add(1.5, 2.5, "Monday");
            m_ChartLikeDist.ChartAreas[0].AxisX.CustomLabels.Add(2.5, 3.5, "Tuesday");
            m_ChartLikeDist.ChartAreas[0].AxisX.CustomLabels.Add(3.5, 4.5, "Wednesday");
            m_ChartLikeDist.ChartAreas[0].AxisX.CustomLabels.Add(4.5, 5.5, "Thursday");
            m_ChartLikeDist.ChartAreas[0].AxisX.CustomLabels.Add(5.5, 6.5, "Friday");
            m_ChartLikeDist.ChartAreas[0].AxisX.CustomLabels.Add(6.5, 7.5, "Saturday");
        }

        private void initializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_ChartLikeDist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_LabelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartLikeDist)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ChartLikeDist
            // 
            this.m_ChartLikeDist.BackColor = SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.m_ChartLikeDist.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.m_ChartLikeDist.Legends.Add(legend2);
            this.m_ChartLikeDist.Location = new Point(0, 0);
            this.m_ChartLikeDist.Name = "m_ChartLikeDist";
            series4.ChartArea = "ChartArea1";
            series4.Color = Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Morning";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Noon";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Evening";
            this.m_ChartLikeDist.Series.Add(series4);
            this.m_ChartLikeDist.Series.Add(series5);
            this.m_ChartLikeDist.Series.Add(series6);
            this.m_ChartLikeDist.Size = new Size(400, 400);
            this.m_ChartLikeDist.TabIndex = 0;
            this.m_ChartLikeDist.Text = "Like Distribution";
            // 
            // m_LabelTitle
            // 
            this.m_LabelTitle.AutoSize = true;
            this.m_LabelTitle.Font = new Font("Levenim MT", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelTitle.Location = new Point(0, 0);
            this.m_LabelTitle.Name = "m_LabelTitle";
            this.m_LabelTitle.Size = new Size(100, 23);
            this.m_LabelTitle.TabIndex = 0;
            this.m_LabelTitle.Text = "This feature calculate the average amount of likes depends on the upload time";
            // 
            // LikesDistributionTabPage
            // 
            this.Controls.Add(this.m_ChartLikeDist);
            this.Controls.Add(this.m_LabelTitle);
            this.Size = new Size(0, 0);
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

        //private Color getColorByLikesAmount(float i_LikesAverage)
        //{
        //    Color color;
        //    int range = m_UserMaxLikes - m_UserMinLikes;

        //    switch (i_LikesAverage)
        //    {
        //        case float likesAverage when (m_UserMinLikes <= likesAverage && likesAverage < m_UserMinLikes + (range / 3) * 1):
        //            color = Color.Firebrick;
        //            break;
        //        case float likesAverage when (m_UserMinLikes + (range / 3) * 1 <= likesAverage && likesAverage < m_UserMinLikes + (range / 3) * 2):
        //            color = Color.DarkOrange;
        //            break;
        //        //case float likesAverage when (m_UserMinLikes + (range / 3) * 2 <= likesAverage && likesAverage < m_UserMinLikes + m_UserMaxLikes:
        //        default:
        //            color = Color.Green;
        //            break;

        //    }

        //    return color;
        //}
    }
}
