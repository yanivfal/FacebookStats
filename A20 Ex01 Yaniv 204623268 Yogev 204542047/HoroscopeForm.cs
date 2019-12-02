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
            
            eZodiacs zodiacName = HoroscopeAgent.GetZodiac(userDOB);

            //labelHoroscopeTitle.Text = "You Are Lion!";
            labelHoroscopeTitle.Text = string.Format("You Are {0}!", zodiacName.ToString());
            pictureBoxHoroscope.Image = HoroscopeAgent.GetZodiacImage(zodiacName);
        }

        private void LocateAllControls()
        {
            // Move all the controls to the center
            this.labelHoroscopeTitle.Left = (this.Width) / 2 - (labelHoroscopeTitle.Width / 2);

        }
    }
}
