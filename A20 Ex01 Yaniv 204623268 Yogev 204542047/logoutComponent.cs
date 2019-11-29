using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class logoutComponent : UserControl
    {
        public logoutComponent()
        {
            InitializeComponent();
        }

        private void logoutComponent_Load(object sender, EventArgs e)
        {
            logout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            AppSettings.Instance.RememberUser = false;
            AppSettings.Instance.LastAccessToken = null;
            AppSettings.Instance.SaveToFile();
        }
    }
}
