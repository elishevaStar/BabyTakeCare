using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BabyTakeCare.BLL;

namespace BabyTakeCare.GUI
{
    public partial class DevelopmentBeg : UserControl
    {
        Appointment a;
        BabyDevelopmentDB tblBabyD;
        Control cParent;
        public DevelopmentBeg(Appointment a, Control cParent)
        {
            InitializeComponent();
            this.a = a;
            this.cParent = cParent;
            tblBabyD = new BabyDevelopmentDB();
            List<BabyDevelopment> lstBD = tblBabyD.GetLstBabyDevelopments().Where(x => x.VisitKode == a.VisitKode).ToList();
            if (lstBD.FirstOrDefault(x=>x.DevelopmentKode==1) != null)
            {

                txtDevelopM.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 1).Result;
                txtDevelopC.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 2).Result;
                txtWeight.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 3).Result;
                txtHigh.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 4).Result;
                txtHead.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 5).Result;
                txtFood.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 6).Result;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cParent.Visible = false;
            this.Parent.Controls.Remove(this);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberDouble(e.KeyChar);
        }

        private void txtHigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberDouble(e.KeyChar);
        }

        private void txtHead_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberDouble(e.KeyChar);
        }
    }
}
