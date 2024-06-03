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
    
    public partial class ImmunistationNote : UserControl
    {
        private ImmunisationTimeDB tblImmTime;
        BabyImmunisationDB tblBImm;
        ImmunisationDB tblImm;
        Baby b;
        public Appointment a;
        Control cParent;
        public ImmunistationNote(Baby b,Appointment a, Control cparent)
        {
            InitializeComponent();
            tblImmTime = new ImmunisationTimeDB();
            tblImm = new ImmunisationDB();
            tblBImm = new BabyImmunisationDB();
            this.b = b;
            this.a = a;
            if (a == null)
                btnEnd.Visible = false;
            cParent = cparent;
            CreateImTime();
            CreateImm();
        }

        private void CreateImm()
        {
            foreach(Immunisation item in tblImm.GetLstImmunisations())
            {
                Panel p = new Panel();
                p.Dock = DockStyle.Top;
                foreach (ImmunistationAge c in panel1.Controls)
                {
                    if(c.Text!="")//בדיקה שלא פקד ריק (הראשון)
                    {
                        ImmunistationPortions imp = new ImmunistationPortions(btnEnd);//פקד להצגת תאריך מנת החיסון לתינוק
                        imp.immT = tblImmTime.GetLstImmunisationTimes().Where(x => x.Status == true).FirstOrDefault(x => (x.ImmunisationKode == item.ImmunisationKode) && ((c.age == x.Age)) && ((c as ImmunistationAge).ageKind == x.AgeKind)) ;

                        if (imp.immT != null)
                        {
                            imp.Text = imp.immT.ToString();
                            imp.bImm = tblBImm.GetLstBabyImmunisations().Where(x => x.AppointmentOfBabyImmunistation().IdNumB == b.IdNumB).FirstOrDefault(x => x.ImmunisationKode == imp.immT.ImmunisationKode && x.PortionNum == imp.immT.NumPortion);//(x.ImmunisationKode == item.ImmunisationKode) && ((c.age == x.Age)) && ((c as ImmunistationAge).ageKind == x.AgeKind));
                            if (imp.bImm != null)
                            {
                                imp.Text = imp.bImm.ExpirtyDate.Date.ToShortDateString();
                                //if (imp.bImm.Status=="נרשם" || imp.bImm.Status == "הבא")
                                //  imp.BackColor = Color.Turquoise;
                                if (imp.bImm.Status == "הבא" && imp.bImm.ExpirtyDate.Date <= DateTime.Now.Date)
                                {
                                    imp.BackColor = Color.Silver;
                                    BabyImmunisation bimm = tblBImm.GetLstBabyImmunisations().FirstOrDefault(x => x.ImmunisationKode == imp.bImm.ImmunisationKode && x.PortionNum == imp.bImm.PortionNum - 1 && x.AppointmentOfBabyImmunistation().IdNumB == imp.bImm.AppointmentOfBabyImmunistation().IdNumB);
                                    if (bimm != null)
                                    {
                                        DateTime d = bimm.AppointmentOfBabyImmunistation().Date.AddDays(imp.bImm.ImmunstionTimeOfBabyImmunistation().AgePortionINDaysRange());
                                        if (d > DateTime.Now)
                                        {
                                            imp.errorProvider1.SetError(imp, "מנת החיסון ניתנת לפי טווח הנך יכול לקבל את מנת החיבון רק מתאריך" + " " + d);
                                            imp.flagrange = false;
                                            imp.errorProvider1.SetIconAlignment(imp, ErrorIconAlignment.TopRight);
                                            imp.errorProvider1.SetIconPadding(imp, -20);
                                        }

                                    }
                                }
                                else
                                {
                                    if (imp.bImm.Status == "קיבל")
                                    {
                                        imp.BackColor = Color.Turquoise;
                                    }
                                    else
                                        imp.BackColor = Color.Beige;
                                }
                            }
                        }
                        p.Controls.Add(imp);
                        imp.Dock = DockStyle.Right;
                        if (a == null)//אם הורה לא יתרחש אירוע בלחיצה 
                        {
                            imp.Click -= imp.ImmunistationPortions_Click;
                        }
                    }
                }
                ImmunistationName imnControl = new ImmunistationName();
                p.Controls.Add(imnControl);
                imnControl.Dock = DockStyle.Right;
                imnControl.imm = item;
                imnControl.Text = item.ImmunisationName;
                panel2.Controls.Add(p);
            }
        }

        private void CreateImTime()
        {
            List<ImmunisationTime> lst = tblImmTime.GetLstImmunisationTimes().OrderByDescending(x => x.index).OrderByDescending(x => x.Age).ToList();
            ImmunistationAge ia = null;
            ImmunisationTime itemPrev = null;
            bool flag = true;
            foreach (ImmunisationTime item in lst)
            {
                if(itemPrev!=null)//אם אתה לא המנה הראשונה
                {
                    if (itemPrev.ToString() == item.ToString())//אם הפקד הקודם שווה לאותו גיל
                        flag = false;
                } 
                if(flag)//אם עדיין אין פקד לגיל זה
                {
                    ia = new ImmunistationAge();
                    ia.Dock = DockStyle.Right;
                    ia.Text = item.ToString();
                    ia.age = item.Age;
                    ia.ageKind = item.AgeKind;
                    panel1.Controls.Add(ia);
                }
                flag = true;
                itemPrev = item;
            }
            ia = new ImmunistationAge();
            ia.Dock = DockStyle.Right;
            ia.Width += 17;
            panel1.Controls.Add(ia);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cParent.Visible = true;
            this.Parent.Controls.Remove(this);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            btnEnd.Visible = false;
            EndOfVisit uEndV = new EndOfVisit(a,cParent,panel3);
            panel2.Controls.Clear();
            panel2.Controls.Add(uEndV);
            uEndV.Dock = DockStyle.Fill;
        }
    }
}
