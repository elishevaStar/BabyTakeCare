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
    public partial class VisitDevelop : UserControl
    {
        string str;
        BabyDevelopmentDB tblBD;
        BabyDevelopment bD;
        Appointment a;
        Appointment appointment;
        AppointmentDB tblAPP;
        Control cParent;
        DevelopmentDB tblD;
        int age;
        public VisitDevelop(Appointment a, Control cParent,int age)
        {
            InitializeComponent();
            this.a = a;
            this.age = age;
            this.cParent = cParent;
            tblBD = new BabyDevelopmentDB();
            tblAPP = new AppointmentDB();
            tblD = new DevelopmentDB();
            List<Appointment> lsta=  tblAPP.GetLstAppointments().Where(x=>x.IdNumB==a.IdNumB).OrderBy(x => x.VisitKode).ToList();
            appointment = lsta[lsta.Count - 2];
            Fill(appointment);
            

           
       

        }
        public void Fill(Appointment appointment)
        {
            this.appointment = appointment;
            List<BabyDevelopment> lstBD=tblBD.GetLstBabyDevelopments().Where(x => x.VisitKode == appointment.VisitKode).ToList();
            if (lstBD.Count > 0)
            {
                if (lstBD.FirstOrDefault(x => x.DevelopmentKode == 1) != null)
                    txtDM.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 1).Result;
                if (lstBD.FirstOrDefault(x => x.DevelopmentKode == 2) != null)
                    txtDC.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 2).Result;
                if (lstBD.FirstOrDefault(x => x.DevelopmentKode == 3) != null)
                    txtW.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 3).Result;
                if (lstBD.FirstOrDefault(x => x.DevelopmentKode == 4) != null)
                    txtH.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 4).Result;
                if (lstBD.FirstOrDefault(x => x.DevelopmentKode == 5) != null)
                    txtHe.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 5).Result;
                if (lstBD.FirstOrDefault(x => x.DevelopmentKode == 6) != null)
                    txtF.Text = lstBD.FirstOrDefault(x => x.DevelopmentKode == 6).Result;
            }




        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (CreateFields())
            {
                DialogResult r2 = MessageBox.Show("האם ברצונך לשמור מעקב זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (r2 == DialogResult.Yes)
                {
                    for(int i=1;i<7;i++)
                    {
                        bD = new BabyDevelopment();
                        bD.Date = DateTime.Now;
                        Control c = NameTxt(i-1);
                        bD.DevelopmentKode = Convert.ToInt32(c.Tag);
                        bD.Result = c.Text;
                        bD.VisitKode = a.VisitKode;
                        tblBD.AddNew(bD);
                    }
                    btnSaveAll.Enabled = false;
                    btnEnd.Enabled = true;
                    btnEnd.Visible = true;
                }
            }
        }

        public Control NameTxt(int i)
        {
                Control[] days = new Control[] { txtDevelopM,txtDevelopC, txtWeight, txtHigh,txtHead,txtFood };
                return days[i];
        }

        public bool CreateFields()//הכל מלא
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (txtWeight.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (!Validation.IsNumDouble(txtWeight.Text))
                    throw new Exception("יש להכניס מספרים!");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtWeight, ex.Message);
                flagOK = false;
            }
            try
            {
                if (txtHigh.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (!Validation.IsNumDouble(txtHigh.Text))
                    throw new Exception("יש להכניס מספרים!");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtHigh, ex.Message);
                flagOK = false;
            }
            try
            {
                if (txtHead.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (!Validation.IsNumDouble(txtHead.Text))
                    throw new Exception("יש להכניס מספרים!");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtHead, ex.Message);
                flagOK = false;
            }
            try
            {
                if (txtFood.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtFood.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFood, ex.Message);
                flagOK = false;
            }
            try
            {
                if (txtDevelopM.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtDevelopM.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDevelopM, ex.Message);
                flagOK = false;
            }
            try
            {
                if (txtDevelopC.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtDevelopC.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDevelopC, ex.Message);
                flagOK = false;
            }

            return flagOK;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cParent.Visible = true;
            this.Parent.Controls.Remove(this);
        }

        private void VisitDevelop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 3 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age)!=null)
                txtWeightN.Text = tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 3 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age).DevelopmentName;
            txtWeightN.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 4 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age)!=null)
                txtHighN.Text = tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 4 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age).DevelopmentName;

            txtHighN.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 5 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age)!=null)
                txtHeadN.Text = tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 5 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age).DevelopmentName;
            txtHeadN.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 6 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age) != null)
                txtFoodN.Text = tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 6 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age).DevelopmentName;
            txtFoodN.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 1 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age)!=null)
                txtDevelopMN.Text = tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 1 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age).DevelopmentName;
            txtDevelopMN.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 2 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age)!=null)
                txtDevelopCN.Text = tblD.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKind == 2 && x.DevelopmentMinAge <= age && x.DevelopmentMaxAge >= age).DevelopmentName;
            txtDevelopCN.Visible = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            EndOfVisit uEndV = new EndOfVisit(a, cParent, this);
            panel1.Controls.Clear();
            panel1.Controls.Add(uEndV);
            uEndV.Dock = DockStyle.Fill;
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
