using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    class LikesDistributionTabPage : TabPage
    {
        public LikesDistributionTabPage(string i_TabText) : base(i_TabText)
        {
            LikesDistributionForm likesDistForm = new LikesDistributionForm();
            likesDistForm.TopLevel = false;
            likesDistForm.Visible = true;
            likesDistForm.FormBorderStyle = FormBorderStyle.None;
            likesDistForm.Width = 500;

            this.Controls.Add(likesDistForm);
        }
    }
}
