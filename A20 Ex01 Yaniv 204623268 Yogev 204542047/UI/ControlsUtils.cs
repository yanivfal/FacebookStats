using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    public class ControlsUtils
    {
        public static void CenteringAllControls(TabPage i_TabPageToCentering)
        {
            // Move all the controls to the center
            foreach (Control control in i_TabPageToCentering.Controls)
            {
                CenteringControl(control);
            }
        }

        public static void CenteringControl(Control i_ControlToCentering)
        {
            // Move controls to the center
            i_ControlToCentering.Left = AppSettings.Instance.MainWindowWidth / 2 - (i_ControlToCentering.Width / 2);
        }
    }
}
