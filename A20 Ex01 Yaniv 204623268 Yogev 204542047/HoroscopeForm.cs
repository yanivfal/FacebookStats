using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class HoroscopeForm : Form
    {
        eZodiacs m_ZodiacName;

        public HoroscopeForm()
        {
            InitializeComponent();
            LocateAllControls();
            FetchHoroscopeNameAndImage();
        }

        private void FetchHoroscopeNameAndImage()
        {
            string dateOfBirth = FBAgent.LoggedInUser.Birthday;
            DateTime userDOB = DateTime.ParseExact(dateOfBirth, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            
            m_ZodiacName = HoroscopeAgent.GetZodiacName(userDOB);
            pictureBoxHoroscope.Image = HoroscopeAgent.GetZodiacImage(m_ZodiacName);
            labelHoroscopeTitle.Text = string.Format("You Are {0}!", m_ZodiacName.ToString());
        }

        private void LocateAllControls()
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
            
            try
            {
                initializeHoroscopeLabel();
                this.Controls.Remove(buttonHoroscopeResolve);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something occur, please try again!");
            }
            
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
    }
}
