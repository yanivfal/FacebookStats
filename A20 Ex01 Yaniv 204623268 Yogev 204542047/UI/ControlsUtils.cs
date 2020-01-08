using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    public class ControlsUtils
    {
        public static void CenteringAllControls(TabPage i_TabPageToCentering, int i_TabPageWidth)
        {
            // Move all the controls to the center
            foreach (Control control in i_TabPageToCentering.Controls)
            {
                CenteringControl(control, i_TabPageWidth);
            }
        }

        public static void CenteringControl(Control i_ControlToCentering, int i_TabPageWidth)
        {
            // Move controls to the center
            i_ControlToCentering.Left = i_TabPageWidth / 2 - (i_ControlToCentering.Width / 2);
        }
    }
}
