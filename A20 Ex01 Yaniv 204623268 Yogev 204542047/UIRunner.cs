using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    class UIRunner
    {
        internal void RunUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppSettings.LoadFile();
            if (!AppSettings.Instance.RememberUser || 
                string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
            {
                new LoginForm().ShowDialog();
            }
            else
            {
                LoginResult result = FacebookService.Connect(AppSettings.Instance.LastAccessToken);
                new MainForm(result.LoggedInUser).ShowDialog();
            }

            AppSettings.Instance.SaveToFile();
        }
    }
}
