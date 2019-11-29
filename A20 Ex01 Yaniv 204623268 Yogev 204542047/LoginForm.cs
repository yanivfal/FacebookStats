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
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class LoginForm : Form
    {
        LoginResult m_Result;

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
            m_Result = FacebookService.Connect("EAAmz8OcMQHgBAPTo7UZCfxSc6mMeYBt8gNnJzMdWIskVOpayGk8hmPJi1t01jNc3wboEB22MvUvLe2s2mGiKIOusl0WhmRn8zRT0gCd4hHK3EZCmviEcfPyE8WtRnweWFckiUZCzfmZAyQp7ZClvxvzgg9mvBVrnUZCAtwPVXiYglInZCXzOd9ZB5USqRdbsX2iTfQYboNLseAZDZD");
            if (!string.IsNullOrEmpty(m_Result.AccessToken))
            {
                FBAgent.LoggedInUser = m_Result.LoggedInUser;
                UIRunner.HideCurrentForm();
                UIRunner.OpenForm<MainForm>();
                setRememberMeChoise();
            }
            else
            {
                MessageBox.Show(m_Result.ErrorMessage);
            }   
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
