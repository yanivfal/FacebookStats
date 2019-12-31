using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    public partial class EventComponent : UserControl
    {
        public EventComponent(Event i_CurrentEvent)
        {
            InitializeComponent();
            eventBindingSource.DataSource = i_CurrentEvent;
        }
    }
}
