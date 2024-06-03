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
    public partial class ImmunistationPortions : Label
    {
        public int age = 0;
        public string ageKind = "";
        public ImmunisationTime immT=null;
        public BabyImmunisation bImm=null;
        internal bool flagrange = true;
        Button btnEnd;
        public ImmunistationPortions(Button btnEnd)
        {
            InitializeComponent();
            this.btnEnd = btnEnd;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void ImmunistationPortions_Click(object sender, EventArgs e)
        {
            if (bImm != null)
            {
                if ((bImm.Status == "הבא" || bImm.Status=="מסרב") && flagrange)
                {
                    GiveImmPortion gi = new GiveImmPortion(btnEnd);
                    gi.bImm = this.bImm;
                    (this.Parent.Parent.Parent as ImmunistationNote).panel5.Visible = true;
                    (this.Parent.Parent.Parent as ImmunistationNote).panel5.Controls.Add(gi);
                    (this.Parent.Parent.Parent as ImmunistationNote).panel5.Location = new Point((sender as Label).Location.X, (sender as Label).Parent.Location.Y);
                    gi.Dock = DockStyle.Fill;
                }
            }
        }
    }
}
