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
        string M_Horoscope;

        public HoroscopeForm()
        {
            InitializeComponent();
            LocateAllControls();
            FetchHoroscopeNameAndImage();
        }

        private void FetchHoroscopeNameAndImage()
        {
            string dateOfBirth = FBAgent.LoggedInUser.Birthday;
            //string zodiacName = ZodiacAgent.getZodiacName(dateOfBirth);

            labelHoroscopeTitle.Text = "You Are Lion!";
            //labelHoroscopeTitle.Text = string.Format("You Are {0}!", zodiacName);
            //pictureBoxHoroscope.Image = ZodiacAgent.getZodiacImage(dateOfBirth);
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
            if (string.IsNullOrEmpty(M_Horoscope))
            {
                Label horscopeText = new Label();
                horscopeText.Text = M_Horoscope;
                horscopeText.Top = pictureBoxHoroscope.Bottom + 30;
                horscopeText.Left = (this.Width) / 2 - (horscopeText.Width / 2);
            }           
        }
    }
}
