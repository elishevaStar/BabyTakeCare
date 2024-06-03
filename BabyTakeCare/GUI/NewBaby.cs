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
    public partial class NewBaby : UserControl
    {

        Baby baby;
        NationalDB tblNational;
        BabyDB tblBaby;
        WorkerHome frm;
        BranchDB tblBranch;
        CityDB tblCity;
        Worker w;
        DialogResult r1;
        SensitiveDB tblS;
        BabySensitiveDB tblBS;
        bool flag = false;
        bool flag2 = true;
        BabySensitive bS;
        ImmunisationTimeDB tblImmTime;
        ImmunisationTime immT;
        BabyImmunisation babyImm;
        BabyImmunisationDB tblImmBaby;
        Appointment a;
        AppointmentDB tblAp;
        Control cParent;


        public NewBaby(string str, WorkerHome frm, Worker w, Control cParent)
        {
            InitializeComponent();
            this.frm = frm;
            this.w = w;
            this.cParent = cParent;
            panel2.Visible = false;
            if (str == "עדכן")
            {
                button2.Text = "צפיה ברגישויות";
            }
            tblBS = new BabySensitiveDB();
            tblS = new SensitiveDB();
            baby = new Baby();
            tblCity = new CityDB();
            tblBranch = new BranchDB();
            btnAddBaby.Text = str;
            tblImmBaby = new BabyImmunisationDB();
            tblNational = new NationalDB();
            tblImmTime = new ImmunisationTimeDB();
            tblAp = new AppointmentDB();
            combNa.DataSource = tblNational.GetLstNationals().Select(x => x.NationalDescription).ToList();
            combNa.SelectedIndex = -1;
            combKind.SelectedIndex = -1;
            txtCity.Text = w.BranchOfWorker().CityOfBranch().CityName;
            txtCity.Enabled = false;
            txtBranch.Text = w.BranchOfWorker().AddressBr;
            txtBranch.Enabled = false;
            tblBaby = new BabyDB();
            
        }

        public void Fill(Baby baby)
        {
            this.baby = baby;
            txtPN.Text = baby.PrivateName;
            txtFN.Text = baby.FamiliyName;
            txtIdB.Text = baby.IdNumB;
            txtIdM.Text = baby.IdNumP;
            dateTimeB.Value = baby.DateOfBirth;
            txtH.Text = baby.BornHigh.ToString();
            txtW.Text = baby.BornWeight.ToString();
            txtAdd.Text = baby.Address;
            txtPhone.Text = baby.TelNum;
            combKind.SelectedItem = baby.Kind;
            combKind.Text = baby.Kind.ToString();
            combNa.SelectedItem = baby.NationalOfBaby();
            combNa.Text = baby.NationalOfBaby().ToString();
            txtPNF.Text = baby.PrivateNameFather;
            txtPNM.Text = baby.PrivateNameMother;
            txtKode.Text = baby.BabyKode.ToString();
            txtIdB.ReadOnly = true;
        }

        private void ImmPortions()
        {
            if (tblAp.GetLstAppointments().FirstOrDefault(x => x.IdNumB == baby.IdNumB) == null)
            {
                a = new Appointment();
                a.VisitKode = tblAp.GetNextKey();
                a.IdNumB = baby.IdNumB;
                a.IdNumW = w.IdNumW;
                a.Date = DateTime.Now;
                a.VisitDisKode = 3;
                tblAp.AddNew(a);
            }
            foreach (ImmunisationTime item in tblImmTime.GetLstImmunisationTimes())
            {
                if(!flag)
                {
                    babyImm = new BabyImmunisation();
                    babyImm.ImmunisationKode = item.ImmunisationKode;
                    babyImm.VisitKode = a.VisitKode;
                    babyImm.PortionNum = item.NumPortion;
                    babyImm.Status = "הבא";
                    flag = true;
                }
                else
                {
                    babyImm = new BabyImmunisation();
                    babyImm.ImmunisationKode = item.ImmunisationKode;
                    babyImm.VisitKode = a.VisitKode;
                    babyImm.PortionNum = item.NumPortion;
                    babyImm.Status = "נרשם";
                }
               
                if (item.index == 1)
                    babyImm.ExpirtyDate = baby.DateOfBirth.AddDays(item.Age);
                if (item.index == 2)
                    babyImm.ExpirtyDate = baby.DateOfBirth.AddDays(item.Age * 7);
                if (item.index == 3)
                    babyImm.ExpirtyDate = baby.DateOfBirth.AddMonths(item.Age);
                tblImmBaby.AddNew(babyImm);




            }
        }

        private void btnAddBaby_Click(object sender, EventArgs e)
        {
            if (btnAddBaby.Text == "הוסף")
            {
                baby = new Baby();
                if (CreateFields(baby))
                {
                    if (tblBaby.GetLstBabies().FirstOrDefault(x => x.Status == false && x.IdNumB == txtIdB.Text) != null)
                    {
                        r1 = MessageBox.Show("מטופל זה כבר קים במערכת אך אינו פעיל האם ברצונך להפעילו!", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        if (r1 == DialogResult.Yes)
                        {
                            baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == txtIdB.Text);
                            baby.Status = true;
                            tblBaby.UpDateRow(baby);
                        }

                    }

                    if (tblBaby.GetLstBabies().FirstOrDefault(x => x.Status == true && x.IdNumB == txtIdB.Text) != null)
                    {
                        DialogResult r1 = MessageBox.Show("מטופל זה כבר פעיל במערכת!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        txtIdB.Text = "";

                    }


                    else
                    {
                        if (r1 == DialogResult.No)
                        {
                            txtIdB.Text = "";
                        }
                        if (txtIdB.Text != "")
                        {
                            DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף מטופל זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                            if (r2 == DialogResult.Yes)
                            {
                                baby.Status = true;
                                tblBaby.AddNew(baby);
                                ImmPortions();
                                ImmBorn();

                                foreach (GUI.Sensitive item in panel1.Controls)
                                {
                                    flag = true;
                                    if (item.bS == null)
                                    {
                                        item.bS = new BabySensitive();
                                        if (item.CreateFields(item.bS))
                                        {
                                            item.bS.IdNumB = baby.IdNumB;
                                            if (tblBS.Find(item.bS.IdNumB, item.bS.SensitiveKode) != null)
                                                MessageBox.Show("ישנה רגישות כפולה, היא תתוסף על פי הערכים הראשונים!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                                            else
                                            {
                                                tblBS.AddNew(item.bS);
                                                item.bS.Status = true;
                                            }

                                        }
                                        else
                                            flag2 = false;




                                    }
                                    else
                                    {
                                        item.bS.IdNumB = baby.IdNumB;
                                        if (tblBS.Find(item.bS.IdNumB, item.bS.SensitiveKode) != null)
                                            MessageBox.Show("ישנה רגישות כפולה, היא תתוסף על פי הערכים הראשונים!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                                        else
                                        {
                                            tblBS.AddNew(item.bS);
                                            item.bS.Status = true;
                                        }

                                    }





                                }
                                if (flag2)
                                {
                                    DialogResult r3 = MessageBox.Show("האם ברצונך לסיים את הוספת מטופל זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                                    if (r3 == DialogResult.Yes)
                                    {
                                        btnAddBaby.Enabled = false;
                                        frm.panel2.Visible = true;
                                        this.Parent.Controls.Remove(this);


                                    }


                                }
                            }
                        }
                    } 
                }
            } 

            else
            {
                if (CreateFields(baby))
                {
                    DialogResult r1 = MessageBox.Show("האם ברצונך לעדכן מטופל זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r1 == DialogResult.Yes)
                    {
                                
                        tblBaby.UpDateRow(baby);
                        baby.Status = true;
                        frm.panel2.Visible = true;
                        this.Parent.Controls.Remove(this);


                    }
                }

            }
           
        }

        private void ImmBorn()
        {
            BabyImmunisation bImm = tblImmBaby.GetLstBabyImmunisations().FirstOrDefault(x=>x.ImmunisationKode==1 && x.PortionNum==1);
            DialogResult dri = MessageBox.Show("האם חוסן בית חולים?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (dri==DialogResult.Yes)
            {
                bImm.Status = "קיבל";
                tblImmBaby.UpDateRow(bImm);
               BabyImmunisation bimm = tblImmBaby.GetLstBabyImmunisations().FirstOrDefault(x => x.ImmunisationKode == bImm.ImmunisationKode && x.PortionNum == bImm.PortionNum + 1 && x.AppointmentOfBabyImmunistation().IdNumB == bImm.AppointmentOfBabyImmunistation().IdNumB);
                if (bimm != null)
                {
                    bimm.Status = "הבא";
                    tblImmBaby.UpDateRow(bimm);
                }

            }

        }

        public bool CreateFields(Baby baby)
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if(txtPN.Text=="")
                    throw new Exception("יש להכניס ערך");
                if(txtPN.Text.Length==1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                baby.PrivateName = txtPN.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPN, ex.Message);
                flagOK = false;
                
                
            }
            try
            {
                if (txtFN.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtFN.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                baby.FamiliyName = txtFN.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFN, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtIdB.Text == "")
                    throw new Exception("יש להכניס ערך");
                baby.IdNumB = txtIdB.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtIdB, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtIdM.Text == "")
                    throw new Exception("יש להכניס ערך");
                baby.IdNumP = txtIdM.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtIdM, ex.Message);
                flagOK = false;

            }
            try
            {
                int year = dateTimeB.Value.Year;
                if (DateTime.Now.Year - year > 6)
                    throw new Exception("!בגילך אין שרות בטיפת החלב");
                baby.DateOfBirth = dateTimeB.Value;
                
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dateTimeB, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtH.Text == "")
                    throw new Exception("יש להכניס ערך");
                baby.BornHigh =Convert.ToDouble( txtH.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtH, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtW.Text == "")
                    throw new Exception("יש להכניס ערך");
                baby.BornWeight = Convert.ToDouble(txtW.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtW, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtAdd.Text == "")
                    throw new Exception("יש להכניס ערך");
                baby.Address = txtAdd.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAdd, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtPhone.Text == "")
                    throw new Exception("יש להכניס ערך");
                baby.TelNum = txtPhone.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone, ex.Message);
                flagOK = false;

            }
            try
            {
                if (combKind.SelectedItem == null)
                    throw new Exception("יש להכניס ערך");
                baby.Kind = combKind.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combKind, ex.Message);
                flagOK = false;

            }
            try
            {
                if (combNa.SelectedItem ==null)
                    throw new Exception("יש להכניס ערך");
                baby.NationalKode =tblNational.GetLstNationals().FirstOrDefault(x => x.NationalDescription == combNa.SelectedItem.ToString()).NationalNum;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combNa, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtPNF.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtPNF.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                baby.PrivateNameFather = txtPNF.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPNF, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtPNM.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtPNM.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                baby.PrivateNameMother = txtPNM.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPNM, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtKode.Text == "")
                    throw new Exception("יש להכניס ערך");
                baby.BabyKode = Convert.ToInt32(txtKode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKode, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtBranch.Text == null)
                    throw new Exception("יש להכניס ערך");
                baby.BranchKode = w.BranchKode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBranch, ex.Message);
                flagOK = false;

            }
            baby.CityKode = w.BranchOfWorker().CityOfBranch().CityKode;
            return flagOK;
        }

        private void combNa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void NewBaby_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="הוספת רגישות")
            {
                GUI.Sensitive uSensitive = new GUI.Sensitive("הוספה",bS);
                panel1.Controls.Add(uSensitive);
                uSensitive.Dock = DockStyle.Top;
            }
            else
            {
                baby= tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == txtIdB.Text);
                panel2.Controls.Clear();
                SensitiveDeatils uSensitive = new SensitiveDeatils(baby);
                panel1.Visible = false;
                panel2.Controls.Add(uSensitive);
                uSensitive.Dock = DockStyle.Fill;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cParent.Visible = true;
            this.Parent.Controls.Remove(this);
        }

        private void txtPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txtFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txtIdB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtIdM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtPNF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

      

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtPNM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberDouble(e.KeyChar);
        }

        private void txtW_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberDouble(e.KeyChar);
        }

        private void txtIdM_TextChanged(object sender, EventArgs e)
        {
            if (tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumP == txtIdM.Text) != null)
            {
                baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumP == txtIdM.Text);
                txtFN.Text = baby.FamiliyName;
                txtAdd.Text = baby.Address;
                txtPhone.Text = baby.TelNum;
                combNa.SelectedItem = baby.NationalOfBaby();
                combNa.Text = baby.NationalOfBaby().ToString();
                txtPNF.Text = baby.PrivateNameFather;
                txtPNM.Text = baby.PrivateNameMother;
                txtKode.Text = baby.BabyKode.ToString();

            }
        }
    }
}
