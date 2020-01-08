using A20_Ex01_Yaniv_204623268_Yogev_204542047.Facades;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Factory;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    internal partial class MainForm : Form
    {
        private MainFormFacade m_Facade;
        private TabPageFactory m_TabPageFactory;

        public MainForm()
        {
            m_Facade = new MainFormFacade();
            m_TabPageFactory = new TabPageFactory();
            InitializeComponent();
            initializeWindowSettings();
        }

        private void initializeTabPage(eTabPage i_TabPage)
        {
            TabPage tabPage = m_TabPageFactory.CreateTabPage(i_TabPage);
            tabsNavigator.Invoke(new Action(() => tabsNavigator.Controls.Add(tabPage)));
        }


        private void fetchUserData()
        {
            mainFormFacadeBindingSource.DataSource = m_Facade;
        }

        private void fetchAlbumsComboBox()
        {
            userAlbumsBindingSource.DataSource = m_Facade.UserAlbums;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                fetchUserData();
                new Thread(new ThreadStart(new Action(() => initializeTabPage(eTabPage.WallPhotos)))).Start();
                //new Thread(new ThreadStart(new Action(() => initializeTabPage(eTabPage.Horoscope)))).Start();
                //new Thread(new ThreadStart(new Action(() => initializeTabPage(eTabPage.Events)))).Start();
                //initializeTabPage(eTabPage.LikesDistribution);
                //initializeTabPage(eTabPage.Horoscope);
                //new Thread(new ThreadStart(new Action(() => initializeTabPage(eTabPage.LikesDistribution)))).Start();
                //new Thread(new ThreadStart(new Action(() => initializeTabPage(eTabPage.Friends)))).Start();
                int width = this.Width;
                int Height = this.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void initializeWindowSettings()
        {
            // Set the window size
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int width = screen.Width / 2 + 20;
            int height = screen.Height - 20;
            this.Size = new Size(width, height);

            // Logo button location
            logoutButton.Left = this.Right - logoutButton.Width - 50;
            logoutLabel.Left = this.Right - logoutButton.Width - 50;

            // Top cover size
            topCover.Width = this.Width - 20;

            //Navigator tabControl location
            this.tabsNavigator.Top = this.topCover.Bottom;
            this.tabsNavigator.Width = this.Width;

            AppSettings.Instance.MainWindowWidth = this.Width;
            AppSettings.Instance.MainWindowHeight = this.Height;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AppSettings.Instance.RememberUser = false;
            AppSettings.Instance.LastAccessToken = null;
            AppSettings.Instance.SaveToFile();
            UIRunner.HideCurrentForm();
            UIRunner.OpenForm<LoginForm>();
        }
    }
}
