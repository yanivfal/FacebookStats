using A20_Ex01_Yaniv_204623268_Yogev_204542047.Facades;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Factory;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    internal partial class MainForm : Form
    {
        private MainFormFacade m_Facade;

        public MainForm()
        {
            m_Facade = new MainFormFacade();
            InitializeComponent();
            initializeWindowSettings(); 
        }

        private void fetchUserData()
        {
            mainFormFacadeBindingSource.DataSource = m_Facade;
        }

        private void fetchAlbumsComboBox()
        {
            userAlbumsBindingSource.DataSource = m_Facade.UserAlbums;
        }

        private void comboBoxAlbums_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TabPageFactory.CreateWallTabPage(tabWall, comboBoxAlbums.SelectedItem.ToString());
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                fetchUserData();
                new Thread(new ThreadStart(initializeWallTabPage)).Start();
                new Thread(new ThreadStart(initializeFreindsListTabPage)).Start();

                initializeHoroscopeTabPage();
                initializeLikesDistributionTabPage();
                initializeEventsTabPage();
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
        }

        private void initializeWallTabPage()
        {
            fetchAlbumsComboBox();
            TabPageFactory.CreateWallTabPage(tabWall, comboBoxAlbums.Items[0].ToString());
        }

        private void initializeLikesDistributionTabPage()
        {
            TabPageFactory.CreateLikesDistTabPage(ref tabLikesDist);
        }

        private void initializeHoroscopeTabPage()
        {
            TabPageFactory.CreateHoroscopeTabPage(ref tabHoroscope);
        }

        private void initializeFreindsListTabPage()
        {    
            TabPageFactory.CreateFreindsListTabPage(tabFreindList);
        }

        private void initializeEventsTabPage()
        {
            TabPageFactory.CreateEventsTabPage(ref tabEvents);
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
