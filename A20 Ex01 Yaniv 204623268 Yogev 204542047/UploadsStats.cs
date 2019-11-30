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
        Post[] m_UserPhotos;
        private Dictionary<DayOfWeek, Dictionary<eDayParts, PhotosGroupInfo>> m_UserAmountOfLikesStatistics;

        public UploadsStats()
        {
            //m_UserPhotos = FBAgent.LoggedInUser.Posts.ToArray();
            //m_UserAmountOfLikesStatistics = Utils.GetUserLikesAmountByDayAndDayPart();
            
            InitializeComponent();

            setTableInfo();
        }

        private void setTableInfo()
        {
            Control p = this.uploadStatsTable.GetControlFromPosition(1, 1);
            p.BackColor = Color.Red;
            uploadStatsTable.Controls.Add(new Label() { Text = " sadsd", Font = new Font("Arial", 11) }, 0, 0);

            p.Text = "asd";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Post photo in m_UserPhotos)
            {
                //teTime uploadTime = photo.UpdateTime;
            }
        }

        private void uploadStatsTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
