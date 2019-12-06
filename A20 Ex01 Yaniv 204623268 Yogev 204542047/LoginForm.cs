﻿using FacebookWrapper;
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
            bool isLoginSucceeded;
            string accessToken;

            isLoginSucceeded = FBAgent.LoginAndInit(out accessToken);
            if (isLoginSucceeded)
            {
                UIRunner.HideCurrentForm();
                UIRunner.OpenForm<MainForm>();
                setRememberMeChoise(accessToken);
            }
            else
            {
                MessageBox.Show("Something occur, please try again!");
            }

            //m_Result = FacebookService.Login("2731122040258680", "name", "albums");
            ////m_Result = FacebookService.Connect("EAAmz8OcMQHgBAGXfUC2lNN7aTYzkurCRoZA4hgNxHstJHmZAD7mQvaxlIOi3egFPJnsssVingLlokbEYpkPHgPhD3vXXoFR96nSZCJOgblroKlFEiaE0GMs73n20kh7qUMDOWK4uyprll0qCjNb1ROcreNXS6Iz0OWUmKnoxZA0dOJAZBd2njG7sRCvAf8qgJNiexXWPjRQZDZD");
            //if (!string.IsNullOrEmpty(m_Result.AccessToken))
            //{
            //    FBAgent.LoggedInUser = m_Result.LoggedInUser;
            //    UIRunner.HideCurrentForm();
            //    UIRunner.OpenForm<MainForm>();
            //    setRememberMeChoise();
            //}
            //else
            //{
            //    MessageBox.Show(m_Result.ErrorMessage);
            //}   
        }

        private void setRememberMeChoise(string i_AccessToken)
        {
            if (checkBoxStayLogged.Checked && i_AccessToken != null)
            {
                AppSettings.Instance.RememberUser = true;
                AppSettings.Instance.LastAccessToken = i_AccessToken;
            }
            else
            {
                AppSettings.Instance.RememberUser = false;
                AppSettings.Instance.LastAccessToken = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }
    }
}
