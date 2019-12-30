using System;
using System.Windows.Forms;
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
            bool isLoginSucceeded = false;
            string accessToken = null;

            try
            {
                isLoginSucceeded = FBAgent.LoginAndInit(out accessToken);
                if (isLoginSucceeded)
                {
                    isLoginSucceeded = true;
                    UIRunner.HideCurrentForm();
                    UIRunner.OpenForm<MainForm>();
                    setRememberMeChoise(accessToken);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something occur, please try again!");
            }
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

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }
    }
}
