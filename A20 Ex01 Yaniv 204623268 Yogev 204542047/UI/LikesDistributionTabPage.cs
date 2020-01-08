using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    class LikesDistributionTabPage : TabPage
    {
        private Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_UserAmountOfLikesStatistics;
        private int m_UserMinLikes;
        private int m_UserMaxLikes;

        TableLayoutPanel StatsTable;
        Label labelEvening = new System.Windows.Forms.Label();
        Label labelAfterNoon = new System.Windows.Forms.Label();
        Label labelNoon = new System.Windows.Forms.Label();
        Label labelSundat = new System.Windows.Forms.Label();
        Label labelMonday = new System.Windows.Forms.Label();
        Label labelTuesday = new System.Windows.Forms.Label();
        Label labelWednesday = new System.Windows.Forms.Label();
        Label labelThursday = new System.Windows.Forms.Label();
        Label labelFriday = new System.Windows.Forms.Label();
        Label labelSaturday = new System.Windows.Forms.Label();
        Label labelMorning = new System.Windows.Forms.Label();
        Label labelTitle = new System.Windows.Forms.Label();
        Label labelHigh = new System.Windows.Forms.Label();
        Label label1 = new System.Windows.Forms.Label();
        Label label2 = new System.Windows.Forms.Label();


        public LikesDistributionTabPage(string i_TabText) : base(i_TabText)
        {
            m_UserAmountOfLikesStatistics = LikesDistributionUtils.GetUserLikesAmountByDayAndDayPart();
            m_UserMinLikes = 0;
            m_UserMaxLikes = 200;

            InitializeComponent();
            InitializeLocationAndSize();

            setTableInfo();
        }

        private void InitializeComponent()
        {
            this.StatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.labelEvening = new System.Windows.Forms.Label();
            this.labelAfterNoon = new System.Windows.Forms.Label();
            this.labelNoon = new System.Windows.Forms.Label();
            this.labelSundat = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.labelMorning = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatsTable
            // 
            this.StatsTable.ColumnCount = 5;
            this.StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.09581F));
            this.StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.90419F));
            this.StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.StatsTable.Controls.Add(this.labelEvening, 4, 0);
            this.StatsTable.Controls.Add(this.labelAfterNoon, 3, 0);
            this.StatsTable.Controls.Add(this.labelNoon, 2, 0);
            this.StatsTable.Controls.Add(this.labelSundat, 0, 1);
            this.StatsTable.Controls.Add(this.labelMonday, 0, 2);
            this.StatsTable.Controls.Add(this.labelTuesday, 0, 3);
            this.StatsTable.Controls.Add(this.labelWednesday, 0, 4);
            this.StatsTable.Controls.Add(this.labelThursday, 0, 5);
            this.StatsTable.Controls.Add(this.labelFriday, 0, 6);
            this.StatsTable.Controls.Add(this.labelSaturday, 0, 7);
            this.StatsTable.Controls.Add(this.labelMorning, 1, 0);
            this.StatsTable.Location = new System.Drawing.Point(57, 223);
            this.StatsTable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StatsTable.Name = "StatsTable";
            this.StatsTable.RowCount = 8;
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.1746F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.8254F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.StatsTable.Size = new System.Drawing.Size(1634, 972);
            this.StatsTable.TabIndex = 0;
            // 
            // labelEvening
            // 
            this.labelEvening.AutoSize = true;
            this.labelEvening.Enabled = false;
            this.labelEvening.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvening.Location = new System.Drawing.Point(1393, 0);
            this.labelEvening.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEvening.Name = "labelEvening";
            this.labelEvening.Size = new System.Drawing.Size(193, 60);
            this.labelEvening.TabIndex = 6;
            this.labelEvening.Text = "Evening";
            this.labelEvening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAfterNoon
            // 
            this.labelAfterNoon.AutoSize = true;
            this.labelAfterNoon.Enabled = false;
            this.labelAfterNoon.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfterNoon.Location = new System.Drawing.Point(1009, 0);
            this.labelAfterNoon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAfterNoon.Name = "labelAfterNoon";
            this.labelAfterNoon.Size = new System.Drawing.Size(233, 60);
            this.labelAfterNoon.TabIndex = 5;
            this.labelAfterNoon.Text = "Afternoon";
            this.labelAfterNoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNoon
            // 
            this.labelNoon.AutoSize = true;
            this.labelNoon.Enabled = false;
            this.labelNoon.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoon.Location = new System.Drawing.Point(726, 0);
            this.labelNoon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNoon.Name = "labelNoon";
            this.labelNoon.Size = new System.Drawing.Size(140, 60);
            this.labelNoon.TabIndex = 4;
            this.labelNoon.Text = "Noon";
            this.labelNoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSundat
            // 
            this.labelSundat.AutoSize = true;
            this.labelSundat.Enabled = false;
            this.labelSundat.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSundat.Location = new System.Drawing.Point(5, 137);
            this.labelSundat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSundat.Name = "labelSundat";
            this.labelSundat.Size = new System.Drawing.Size(184, 60);
            this.labelSundat.TabIndex = 7;
            this.labelSundat.Text = "Sunday";
            this.labelSundat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Enabled = false;
            this.labelMonday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonday.Location = new System.Drawing.Point(5, 258);
            this.labelMonday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(203, 60);
            this.labelMonday.TabIndex = 8;
            this.labelMonday.Text = "Monday";
            this.labelMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Enabled = false;
            this.labelTuesday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuesday.Location = new System.Drawing.Point(5, 379);
            this.labelTuesday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(200, 60);
            this.labelTuesday.TabIndex = 9;
            this.labelTuesday.Text = "Tuesday";
            this.labelTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Enabled = false;
            this.labelWednesday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWednesday.Location = new System.Drawing.Point(5, 495);
            this.labelWednesday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(279, 60);
            this.labelWednesday.TabIndex = 10;
            this.labelWednesday.Text = "Wednesday";
            this.labelWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.Enabled = false;
            this.labelThursday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThursday.Location = new System.Drawing.Point(5, 616);
            this.labelThursday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(212, 60);
            this.labelThursday.TabIndex = 11;
            this.labelThursday.Text = "Thursday";
            this.labelThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Enabled = false;
            this.labelFriday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriday.Location = new System.Drawing.Point(5, 745);
            this.labelFriday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(155, 60);
            this.labelFriday.TabIndex = 12;
            this.labelFriday.Text = "Friday";
            this.labelFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSaturday
            // 
            this.labelSaturday.AutoSize = true;
            this.labelSaturday.Enabled = false;
            this.labelSaturday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaturday.Location = new System.Drawing.Point(5, 867);
            this.labelSaturday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(214, 60);
            this.labelSaturday.TabIndex = 13;
            this.labelSaturday.Text = "Saturday";
            this.labelSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMorning
            // 
            this.labelMorning.AutoSize = true;
            this.labelMorning.Enabled = false;
            this.labelMorning.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMorning.Location = new System.Drawing.Point(381, 0);
            this.labelMorning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMorning.Name = "labelMorning";
            this.labelMorning.Size = new System.Drawing.Size(199, 60);
            this.labelMorning.TabIndex = 3;
            this.labelMorning.Text = "Morning";
            this.labelMorning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle.Location = new System.Drawing.Point(162, 31);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1351, 45);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "This feature calculate the average amount of likes depends on the upload time";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHigh.ForeColor = System.Drawing.Color.Green;
            this.labelHigh.Location = new System.Drawing.Point(530, 108);
            this.labelHigh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(93, 46);
            this.labelHigh.TabIndex = 2;
            this.labelHigh.Text = "High";
            this.labelHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(862, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medium";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(1204, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Low";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadsStats
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(1739, 1214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.StatsTable);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            //this.Name = "UploadsStats";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //this.Text = "UploadsStats";
            //this.StatsTable.ResumeLayout(false);
           // this.StatsTable.PerformLayout();
            //this.ResumeLayout(false);
            //this.PerformLayout();

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
                        if (likesAvg == 0)
                        {
                            likesAvg = rnd.Next(m_UserMinLikes, m_UserMaxLikes);
                        }

                        cellLabel.Text = string.Format(likesAvg.ToString());
                        cellLabel.ForeColor = getColorByLikesAmount(likesAvg);
                    }

                    StatsTable.Controls.Add(cellLabel, (int)dayPart + 1, (int)day + 1);
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
