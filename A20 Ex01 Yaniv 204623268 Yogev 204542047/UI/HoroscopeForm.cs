using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class HoroscopeForm : Form
    {
        eZodiacs m_ZodiacName;

        public HoroscopeForm()
        {
            initializeComponent();
            locateAllControls();
            fetchHoroscopeNameAndImage();
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
            this.labelHoroscopeTitle.Left = (this.Width) / 2 - (labelHoroscopeTitle.Width / 2);
        }

        private void buttonHoroscopeResolve_Click(object sender, EventArgs e)
        {
            fetchHoroscope();
        }

        private void fetchHoroscope()
        {    
            this.pictureBoxHoroscope.Size = new Size(100, 100);
            pictureBoxHoroscope.Left = (this.Width) / 2 - (pictureBoxHoroscope.Width / 2);
            this.Controls.Remove(buttonHoroscopeResolve);
            initializeHoroscopeLabel();
        }

        private void initializeHoroscopeLabel()
        {
            Label horscopeText = new Label();

            horscopeText.Font = new Font("Levenim MT", 10);
            horscopeText.Height = 300;
            horscopeText.Width = this.Width - 50;
            horscopeText.Text = HoroscopeAgent.GetHoroscope(m_ZodiacName);
            horscopeText.Top = pictureBoxHoroscope.Bottom + 10;
            horscopeText.Left = (this.Width) / 2 - (horscopeText.Width / 2);
            this.Controls.Add(horscopeText);
        }

        private void backComponent1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HoroscopeForm
            // 
            this.ClientSize = new System.Drawing.Size(2021, 844);
            this.Name = "HoroscopeForm";
            this.Load += new System.EventHandler(this.HoroscopeForm_Load);
            this.ResumeLayout(false);

        }

        private void HoroscopeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
