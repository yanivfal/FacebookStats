using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    class HoroscopeTabPage : TabPage
    {
        eZodiacs m_ZodiacName;
        Label labelHoroscopeTitle;
        Button buttonHoroscopeResolve;
        PictureBox pictureBoxHoroscope;

        public HoroscopeTabPage(string i_TabText) : base(i_TabText)
        {
            initializeComponent();
            locateAllControls();
            fetchHoroscopeNameAndImage();       
        }

        private void initializeComponent()
        {
            //
            //this
            //
            this.Width = AppSettings.Instance.MainWindowWidth;
            this.Height = AppSettings.Instance.MainWindowHeight;
            this.labelHoroscopeTitle = new Label();
            this.buttonHoroscopeResolve = new Button();
            this.pictureBoxHoroscope = new PictureBox();      
            // 
            // labelHoroscopeTitle
            // 
            this.labelHoroscopeTitle.AutoSize = true;
            this.labelHoroscopeTitle.Font = new System.Drawing.Font("Levenim MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHoroscopeTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHoroscopeTitle.Name = "labelHoroscopeTitle";
            this.labelHoroscopeTitle.Text = "Horoscope Zone";
            // 
            // buttonHoroscopeResolve
            // 
            this.buttonHoroscopeResolve.Font = new Font("Levenim MT", 8F, FontStyle.Bold,GraphicsUnit.Point, ((byte)(177)));
            this.buttonHoroscopeResolve.Location = new Point(411, 643);
            this.buttonHoroscopeResolve.Margin = new Padding(5);
            this.buttonHoroscopeResolve.Name = "buttonHoroscopeResolve";
            this.buttonHoroscopeResolve.Size = new Size(537, 46);
            this.buttonHoroscopeResolve.Location = new Point(510, 48);
            this.buttonHoroscopeResolve.Text = "Click here to get your horoscope";
            this.buttonHoroscopeResolve.UseVisualStyleBackColor = true;
            this.buttonHoroscopeResolve.Click += new EventHandler(this.buttonHoroscopeResolve_Click);
            // 
            // pictureBoxHoroscope
            // 
            this.pictureBoxHoroscope.Image = Properties.Resources.horoscopesLogo;
            this.pictureBoxHoroscope.Margin = new Padding(5);
            this.pictureBoxHoroscope.Name = "pictureBoxHoroscope";
            this.pictureBoxHoroscope.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = SystemColors.Control;

            this.Controls.Add(this.buttonHoroscopeResolve);
            this.Controls.Add(this.labelHoroscopeTitle);
            this.Controls.Add(this.pictureBoxHoroscope);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Text = "Horoscope";

        }

        private void fetchHoroscopeNameAndImage()
        {
            string dateOfBirth = FBAgent.LoggedInUser.Birthday;
            DateTime userDOB = DateTime.ParseExact(dateOfBirth, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            m_ZodiacName = HoroscopeAgent.GetZodiacName(userDOB);
            pictureBoxHoroscope.Image = HoroscopeAgent.GetZodiacImage(m_ZodiacName);
            labelHoroscopeTitle.Text = string.Format("You Are {0}!", m_ZodiacName.ToString());
        }

        private void locateAllControls()
        {
            // Move all the controls to the center
            this.labelHoroscopeTitle.Top = this.Top + 20;
            this.pictureBoxHoroscope.Top = labelHoroscopeTitle.Bottom + 30;
            this.buttonHoroscopeResolve.Top = pictureBoxHoroscope.Bottom + 30;

            ControlsUtils.CenteringAllControls(this);
        }

        private void buttonHoroscopeResolve_Click(object sender, EventArgs e)
        {
            fetchHoroscope();
        }

        private void fetchHoroscope()
        {
            this.pictureBoxHoroscope.Size = new Size(100, 100);
            ControlsUtils.CenteringControl(pictureBoxHoroscope);
            this.Controls.Remove(buttonHoroscopeResolve);
            initializeHoroscopeLabel();
        }

        private void initializeHoroscopeLabel()
        {
            Label horscopeText = new Label();

            horscopeText.Font = new Font("Levenim MT", 10);
            horscopeText.Height = 300;
            horscopeText.Width = AppSettings.Instance.MainWindowWidth - 50;
            horscopeText.Text = HoroscopeAgent.GetHoroscope(m_ZodiacName);
            horscopeText.Top = pictureBoxHoroscope.Bottom + 10;
            ControlsUtils.CenteringControl(horscopeText);
            this.Controls.Add(horscopeText);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
