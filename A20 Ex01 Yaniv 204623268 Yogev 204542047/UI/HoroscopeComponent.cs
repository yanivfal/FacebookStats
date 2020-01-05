using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    public partial class HoroscopeComponent : Component
    {
        public HoroscopeComponent()
        {
            InitializeComponent();
        }

        public HoroscopeComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
