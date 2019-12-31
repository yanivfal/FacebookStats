using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.UI;
using FacebookWrapper;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    internal class UIRunner
    {
        internal static Form CurrentForm { get; set; }
    
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
                LoginResult result = FBAgent.Connect(AppSettings.Instance.LastAccessToken);
                CurrentForm = new MainForm();
                //CurrentForm = new FriendsForm();
            }

            CurrentForm.ShowDialog();
            AppSettings.Instance.SaveToFile();
        }

        internal static void OpenForm<T>() where T : new()
        {
            CurrentForm = new T() as Form;
            CurrentForm.ShowDialog();
        }

        public static void HideCurrentForm()
        {
            CurrentForm.Hide();
        }
    }
}
