using FacebookWrapper;
using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class LoginForm : Form
    {
        User m_LoggedInUser;
        internal User LoggedInUser { get; }


        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void loginAndInit()
        {
            
            //LoginResult result = FacebookService.Login("2731122040258680", "name", "albums");
            LoginResult result = FacebookService.Connect("EAAmz8OcMQHgBAAMynLZAQGRj8qK3dqPBebntpHQxvuuuRp4MFB5BvTTUuQk5SFd3TaBKjZArNcEThzoJ1IT2l2pBwJB5WEDWwmjc4oI4ZB0jvDPM3LaFlU0mMWTRgD3rHK2317JUkpi2vihPGeMsaVKfG5rEvX0C5xzNZACZAugZDZD");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                new MainForm(m_LoggedInUser).Show();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
