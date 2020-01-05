using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Factory
{
    internal interface ITabPage
    {
        TabPage CreateTabPage();
    }
}
