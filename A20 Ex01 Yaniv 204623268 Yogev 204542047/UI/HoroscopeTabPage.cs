using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    class HoroscopeTabPage : TabPage
    {
        public HoroscopeTabPage(string i_TabText) : base(i_TabText)
        {
            HoroscopeForm horoscopeForm = new HoroscopeForm();
            horoscopeForm.TopLevel = false;
            horoscopeForm.Visible = true;
            horoscopeForm.FormBorderStyle = FormBorderStyle.None;
            horoscopeForm.Height = 500;
            horoscopeForm.Width = 500;
            this.Controls.Add(horoscopeForm);
            ControlsUtils.CenteringAllControls(this);
        }
    }
}
