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
    public partial class GiveImmPortion : UserControl
    {
        public  BabyImmunisation bImm;
        BabyImmunisationDB tblBImm;
        BabyImmunisation bimm;
        Button btnEnd;
        public GiveImmPortion(Button btnEnd)
        {
            InitializeComponent();
            tblBImm = new BabyImmunisationDB();
            this.btnEnd = btnEnd;
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                btnEnd.Enabled = true;
                bImm.Status = "קיבל";
                Control c = this.Parent;
                while (!(c is ImmunistationNote))
                {
                    c = c.Parent;
                }
                bImm.VisitKode = (c as ImmunistationNote).a.VisitKode;
                tblBImm.UpDateRow(bImm);
                bimm = tblBImm.GetLstBabyImmunisations().FirstOrDefault(x => x.ImmunisationKode == bImm.ImmunisationKode && x.PortionNum == bImm.PortionNum + 1 && x.AppointmentOfBabyImmunistation().IdNumB == bImm.AppointmentOfBabyImmunistation().IdNumB);
                if (bimm != null)
                {
                    bimm.Status = "הבא";
                    tblBImm.UpDateRow(bimm);
                }
            }
            if (radioButton2.Checked)
            {
                btnEnd.Enabled = true;
                bImm.Status = "מסרב";
            }
            tblBImm.UpDateRow(bImm);
            this.Parent.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
        }
    }
}
