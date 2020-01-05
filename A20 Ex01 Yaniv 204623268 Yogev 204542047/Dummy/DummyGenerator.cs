using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Dummy
{
    public class DummyGenerator
    {
        internal static FacebookObjectCollection<Event> GetDummyEvents()
        {
            Event e1 = new Event();
            fixed (string* ptr = &e1.Name) *ptr = "Dummy event 1";
           
            return null;

        }
    }
}
