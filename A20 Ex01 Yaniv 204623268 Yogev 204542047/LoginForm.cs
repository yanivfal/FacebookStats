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
        LoginResult m_Result;
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
            //m_Result = FacebookService.Login("2731122040258680", "name", "albums");
            m_Result = FacebookService.Connect("EAAmz8OcMQHgBAJA7GgV4m0lu67x3XgoMdHkTtKKzUtS2FSE2aZBPI9EKQyjef2zY56P5BZCvBsHnGe8ftWZCwE90ZBw93aXNUU1nrd9VVcW9lvjO1NDNd6t9ZAoN4fjT5bzeVRDZBcFginNMpYzaHmZC9Y2eTBYyReLyFWrbZBAZAbPmoXb0aNrXMoyj2blizBJw0CGktS6ZBFkwZDZD");
            if (!string.IsNullOrEmpty(m_Result.AccessToken))
            {
                m_LoggedInUser = m_Result.LoggedInUser;
                OpenMainForm();
                setRememberMeChoise();
            }
            else
            {
                MessageBox.Show(m_Result.ErrorMessage);
            }   
        }

        private void OpenMainForm()
        {
            this.Hide();
            new MainForm(m_LoggedInUser).ShowDialog();
        }

        private void setRememberMeChoise()
        {
            if (checkBoxStayLogged.Checked)
            {
                AppSettings.Instance.RememberUser = true;
                AppSettings.Instance.LastAccessToken = m_Result.AccessToken;
            }
            else
            {
                AppSettings.Instance.RememberUser = false;
                AppSettings.Instance.LastAccessToken = null;
            }
        }
    }
}
