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
        public UploadsStats(User i_LoggedInUser)
        {
            m_UserPhotos = i_LoggedInUser.Posts.ToArray();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Post photo in m_UserPhotos)
            {
                //teTime uploadTime = photo.UpdateTime;
            }
        }
    }
}
