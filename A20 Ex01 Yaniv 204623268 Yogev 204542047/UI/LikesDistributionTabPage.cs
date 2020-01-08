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
    internal class LikesDistributionTabPage : TabPage
    {
        private Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_UserAmountOfLikesStatistics;
        private int m_UserMinLikes;
        private int m_UserMaxLikes;
        TableLayoutPanel StatsTable;


        public LikesDistributionTabPage(string i_TabText) : base(i_TabText)
        {
            m_UserAmountOfLikesStatistics = LikesDistributionUtils.GetUserLikesAmountByDayAndDayPart();
            m_UserMinLikes = 0;
            m_UserMaxLikes = 200;

            InitializeComponent();

            setTableInfo();

            Width = AppSettings.Instance.MainWindowWidth;
            Height = AppSettings.Instance.MainWindowHeight;

        }

        private void InitializeComponent()
        {
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
            StatsTable = new System.Windows.Forms.TableLayoutPanel();

            StatsTable.SuspendLayout();
            SuspendLayout();
            // 
            // StatsTable
            // 
            StatsTable.ColumnCount = 5;
            StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.09581F));
            StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.90419F));
            StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            StatsTable.Controls.Add(labelEvening, 4, 0);
            StatsTable.Controls.Add(labelAfterNoon, 3, 0);
            StatsTable.Controls.Add(labelNoon, 2, 0);
            StatsTable.Controls.Add(labelSundat, 0, 1);
            StatsTable.Controls.Add(labelMonday, 0, 2);
            StatsTable.Controls.Add(labelTuesday, 0, 3);
            StatsTable.Controls.Add(labelWednesday, 0, 4);
            StatsTable.Controls.Add(labelThursday, 0, 5);
            StatsTable.Controls.Add(labelFriday, 0, 6);
            StatsTable.Controls.Add(labelSaturday, 0, 7);
            StatsTable.Controls.Add(labelMorning, 1, 0);
            StatsTable.Location = new System.Drawing.Point(57, 223);
            StatsTable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            StatsTable.Name = "StatsTable";
            StatsTable.RowCount = 8;
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.1746F));
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.8254F));
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            StatsTable.Size = new System.Drawing.Size(1634, 972);
            StatsTable.TabIndex = 0;
            // 
            // labelEvening
            // 
            labelEvening.AutoSize = true;
            labelEvening.Enabled = false;
            labelEvening.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEvening.Location = new System.Drawing.Point(1393, 0);
            labelEvening.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelEvening.Name = "labelEvening";
            labelEvening.Size = new System.Drawing.Size(193, 60);
            labelEvening.TabIndex = 6;
            labelEvening.Text = "Evening";
            labelEvening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAfterNoon
            // 
            labelAfterNoon.AutoSize = true;
            labelAfterNoon.Enabled = false;
            labelAfterNoon.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAfterNoon.Location = new System.Drawing.Point(1009, 0);
            labelAfterNoon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelAfterNoon.Name = "labelAfterNoon";
            labelAfterNoon.Size = new System.Drawing.Size(233, 60);
            labelAfterNoon.TabIndex = 5;
            labelAfterNoon.Text = "Afternoon";
            labelAfterNoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNoon
            // 
            labelNoon.AutoSize = true;
            labelNoon.Enabled = false;
            labelNoon.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNoon.Location = new System.Drawing.Point(726, 0);
            labelNoon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelNoon.Name = "labelNoon";
            labelNoon.Size = new System.Drawing.Size(140, 60);
            labelNoon.TabIndex = 4;
            labelNoon.Text = "Noon";
            labelNoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSundat
            // 
            labelSundat.AutoSize = true;
            labelSundat.Enabled = false;
            labelSundat.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSundat.Location = new System.Drawing.Point(5, 137);
            labelSundat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelSundat.Name = "labelSundat";
            labelSundat.Size = new System.Drawing.Size(184, 60);
            labelSundat.TabIndex = 7;
            labelSundat.Text = "Sunday";
            labelSundat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonday
            // 
            labelMonday.AutoSize = true;
            labelMonday.Enabled = false;
            labelMonday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelMonday.Location = new System.Drawing.Point(5, 258);
            labelMonday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new System.Drawing.Size(203, 60);
            labelMonday.TabIndex = 8;
            labelMonday.Text = "Monday";
            labelMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTuesday
            // 
            labelTuesday.AutoSize = true;
            labelTuesday.Enabled = false;
            labelTuesday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTuesday.Location = new System.Drawing.Point(5, 379);
            labelTuesday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelTuesday.Name = "labelTuesday";
            labelTuesday.Size = new System.Drawing.Size(200, 60);
            labelTuesday.TabIndex = 9;
            labelTuesday.Text = "Tuesday";
            labelTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWednesday
            // 
            labelWednesday.AutoSize = true;
            labelWednesday.Enabled = false;
            labelWednesday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelWednesday.Location = new System.Drawing.Point(5, 495);
            labelWednesday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelWednesday.Name = "labelWednesday";
            labelWednesday.Size = new System.Drawing.Size(279, 60);
            labelWednesday.TabIndex = 10;
            labelWednesday.Text = "Wednesday";
            labelWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThursday
            // 
            labelThursday.AutoSize = true;
            labelThursday.Enabled = false;
            labelThursday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelThursday.Location = new System.Drawing.Point(5, 616);
            labelThursday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelThursday.Name = "labelThursday";
            labelThursday.Size = new System.Drawing.Size(212, 60);
            labelThursday.TabIndex = 11;
            labelThursday.Text = "Thursday";
            labelThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFriday
            // 
            labelFriday.AutoSize = true;
            labelFriday.Enabled = false;
            labelFriday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFriday.Location = new System.Drawing.Point(5, 745);
            labelFriday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelFriday.Name = "labelFriday";
            labelFriday.Size = new System.Drawing.Size(155, 60);
            labelFriday.TabIndex = 12;
            labelFriday.Text = "Friday";
            labelFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSaturday
            // 
            labelSaturday.AutoSize = true;
            labelSaturday.Enabled = false;
            labelSaturday.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSaturday.Location = new System.Drawing.Point(5, 867);
            labelSaturday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelSaturday.Name = "labelSaturday";
            labelSaturday.Size = new System.Drawing.Size(214, 60);
            labelSaturday.TabIndex = 13;
            labelSaturday.Text = "Saturday";
            labelSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMorning
            // 
            labelMorning.AutoSize = true;
            labelMorning.Enabled = false;
            labelMorning.Font = new System.Drawing.Font("Levenim MT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelMorning.Location = new System.Drawing.Point(381, 0);
            labelMorning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelMorning.Name = "labelMorning";
            labelMorning.Size = new System.Drawing.Size(199, 60);
            labelMorning.TabIndex = 3;
            labelMorning.Text = "Morning";
            labelMorning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelTitle.Location = new System.Drawing.Point(162, 31);
            labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(1351, 45);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "This feature calculate the average amount of likes depends on the upload time";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHigh
            // 
            labelHigh.AutoSize = true;
            labelHigh.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelHigh.ForeColor = System.Drawing.Color.Green;
            labelHigh.Location = new System.Drawing.Point(530, 108);
            labelHigh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelHigh.Name = "labelHigh";
            labelHigh.Size = new System.Drawing.Size(93, 46);
            labelHigh.TabIndex = 2;
            labelHigh.Text = "High";
            labelHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label1.ForeColor = System.Drawing.Color.DarkOrange;
            label1.Location = new System.Drawing.Point(862, 108);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 46);
            label1.TabIndex = 3;
            label1.Text = "Medium";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label2.ForeColor = System.Drawing.Color.Firebrick;
            label2.Location = new System.Drawing.Point(1204, 108);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 46);
            label2.TabIndex = 4;
            label2.Text = "Low";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadsStats
            // 
            //AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            //AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //ClientSize = new System.Drawing.Size(1739, 1214);
            Panel f = new Panel();
            f.Name = "Check";
            f.Controls.Add(label2);
            f.Controls.Add(label1);
            f.Controls.Add(labelHigh);
            f.Controls.Add(labelTitle);
            f.Controls.Add(StatsTable);
            

            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            //Name = "UploadsStats";
            //StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //Text = "UploadsStats";
            //StatsTable.ResumeLayout(false);
            // StatsTable.PerformLayout();
            //ResumeLayout(false);
            //PerformLayout();

            f.Width = AppSettings.Instance.MainWindowWidth;
            f.Height = AppSettings.Instance.MainWindowHeight;

            Controls.Add(f);

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
