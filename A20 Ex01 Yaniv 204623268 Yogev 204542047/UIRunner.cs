using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    class UIRunner
    {
        public static Form CurrentForm { get; set; }
    
        internal void RunUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppSettings.LoadFile();
            if (!AppSettings.Instance.RememberUser || 
                string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
            {
                CurrentForm = new LoginForm();
            }
            else
            {
                LoginResult result = FacebookService.Connect(AppSettings.Instance.LastAccessToken);
                FBAgent.LoggedInUser = result.LoggedInUser;
                CurrentForm = new MainForm();
            }

            CurrentForm.ShowDialog();
            AppSettings.Instance.SaveToFile();
        }

        internal static void OpenUploadsStatsForm()
        {
            CurrentForm = new UploadsStats();
            CurrentForm.ShowDialog();
        }

        public static void OpenMainForm()
        {
            CurrentForm = new MainForm();
            CurrentForm.ShowDialog();
        }

        public static void OpenLoginForm()
        {       
            CurrentForm = new LoginForm();
            CurrentForm.ShowDialog();
        }
        
        public static void HideCurrentForm()
        {
            CurrentForm.Hide();
        }

    }
}
