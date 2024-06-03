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
    public partial class NewImm : UserControl
    {
        Immunisation imm;
        ImmunisationDB tblImm;
        ImmunisationTime immTime;
        ImmunisationTimeDB tblImmTime;
        SideEffect s;
        SideEffectDB tblSE;
        FreqentyDB tblF;
        BabyDB tblB;
        ImmunisationSideEffectDB tblImmSE;
        AppointmentDB tblA;
        string str;
        DialogResult r1;
        bool flagC;
        public NewImm(string str)
        {
            InitializeComponent();
            btnGoOn.Text = str;
            flagC = true;
            panel3.Visible= true;
            panel3.Visible = false;
            tblA = new AppointmentDB();
            combHow.SelectedIndex = -1;
            tblImm = new ImmunisationDB();
            tblB = new BabyDB();
            tblImmTime = new ImmunisationTimeDB();
            tblF = new FreqentyDB();
            tblSE = new SideEffectDB();
            tblImmSE = new ImmunisationSideEffectDB();
            panel2.Visible = false;
            btnGoOnTwo.Visible = false;

        }

        private void btnGoOn_Click(object sender, EventArgs e)
        {
            if (btnGoOn.Text == "המשך")
            {
                imm = new Immunisation();
                if (CreateFields(imm))
                {
                    if (tblImm.GetLstImmunisations().FirstOrDefault(x => x.ImmunisationName==txtName.Text) != null)
                    {
                        DialogResult r4 = MessageBox.Show("חיסון זה כבר פעיל במערכת", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        txtName.Text = "";
                    }


                    else
                    {
                   
                        if (txtName.Text != "")
                        {
                            DialogResult r2 = MessageBox.Show("האם ברצונך להמשיך בהוספת חיסון זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                            if (r2 == DialogResult.Yes)
                            {

                                imm.Status = true;
                                imm.ImmunisationKode = tblImm.GetNextKey();
                                tblImm.AddNew(imm);
                                btnGoOn.Enabled = false;
                                int num = Convert.ToInt32(txtPortion.Text);
                                for (int i = 0; i < num; i++)
                                {
                                    Portions uPortions = new Portions(imm);
                                    panel1.Visible = false;
                                    panel2.Visible = true;
                                    btnGoOnTwo.Visible = true;
                                    panel2.Controls.Add(uPortions);
                                    uPortions.Dock = DockStyle.Top;
                                    uPortions.numP = num - i;
                                    uPortions.txtPortionNum.Text = uPortions.numP.ToString();

                                }


                            }
                        }

                    }


                }
            }
            else
            {
                if (CreateFields(imm))
                {
                    DialogResult r3 = MessageBox.Show("האם ברצונך לעדכן חיסון זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r3 == DialogResult.Yes)
                    {
                        tblImm.UpDateRow(imm);
                        imm.Status = true;
                        ImmunistationDeatils uImm = new ImmunistationDeatils();
                        this.Parent.Controls.Add(uImm);
                        uImm.Dock = DockStyle.Fill;
                        this.Parent.Controls.Remove(this);



                    }
                }
            }


        }
        public void Fill(Immunisation imm)
        {
            this.imm = imm;
            txtName.Text = imm.ImmunisationName;
            txtPortion.Text = imm.NumPoration.ToString();
            combHow.SelectedItem = imm.Way;
            //combHow.Text = imm.Way.ToString();
            txtTime.Text = imm.TimeEffect;
        }

        public bool CreateFields(Immunisation imm)
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (txtName.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtName.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                imm.ImmunisationName = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                flagOK = false;

            }
            try
            {
                if (combHow.Text == "")
                    throw new Exception("יש להכניס ערך");
                imm.Way = combHow.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combHow, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtPortion.Text == "")
                    throw new Exception("יש להכניס ערך");
                imm.NumPoration = Convert.ToInt32(txtPortion.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPortion, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtTime.Text == "")
                    throw new Exception("יש להכניס ערך");
                imm.TimeEffect = txtTime.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTime, ex.Message);
                flagOK = false;

            }

            return flagOK;
        }
        public bool CreateFields(ImmunisationTime immTime)
        {
            bool flagOK = true;
            errorProvider1.Clear();
            foreach (Portions item in panel2.Controls)
            {
                item.immTime = new ImmunisationTime();
                try
                {
                    if (item.combAge.Text == "")
                        throw new Exception("יש להכניס ערך");
                    item.immTime.Age = Convert.ToInt32(item.combAge.Text);
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(item.combAge, ex.Message);
                    flagOK = false;

                }
                try
                {
                    if (item.combAgeKind.Text == "")
                        throw new Exception("יש להכניס ערך");
                    item.immTime.AgeKind = item.combAgeKind.Text;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(item.combAgeKind, ex.Message);
                    flagOK = false;

                }

                try
                {
                    if (item.txtRange.Text == "")
                        throw new Exception("יש להכניס ערך");
                    item.immTime.Range = item.txtRange.Text;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(item.txtRange, ex.Message);
                    flagOK = false;

                }
                item.immTime.NumPortion = item.numP;
                item.immTime.ImmunisationKode = imm.ImmunisationKode;

            }
            return flagOK;

        }

        private void btnGoOnTwo_Click(object sender, EventArgs e)
        {
            if (btnGoOnTwo.Text == "המשך")
            {
                if (CreateFields(immTime))
                {
                    DialogResult r2 = MessageBox.Show("האם ברצונך להמשיך בהוספת חיסון זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r2 == DialogResult.Yes)
                    {
                        BabyImmunisation imB;
                        string State = "הבא";
                        int codeVisis = 0;
                        foreach (Portions item in panel2.Controls)
                        {
                            item.immTime.Status = true;
                            tblImmTime.AddNew(item.immTime);
                            foreach (Baby baby in tblB.GetLstBabies())
                            {
                                imB = new BabyImmunisation();
                                imB.VisitKode = tblA.GetLstAppointments().Where(x => x.IdNumB == baby.IdNumB).Min(x => x.VisitKode);
                                imB.PortionNum = item.immTime.NumPortion;
                                imB.ImmunisationKode = item.immTime.ImmunisationKode;
                                imB.Status = State;
                                if(State=="הבא")
                                State = "נרשם";
                            }
                            btnGoOnTwo.Enabled = false;

                        }
                        panel2.Controls.Clear();
                        btnGoOnTwo.Text = "סיום";
                        CreateSideEffect();

                    }

                }
            }
            else
            {
                DialogResult r2 = MessageBox.Show("האם ברצונך לסיים את הוספת חיסון זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                
                if (r2 == DialogResult.Yes)
                {
                    foreach (SideEffectChose item in panel2.Controls)
                    {

                        if (item.checkBox1.Checked)
                        {
                            item.immS = new ImmunisationSideEffect();
                            item.immS.ImmunisationKode = imm.ImmunisationKode;
                            item.immS.SideEffectKode = item.s.SideEffectKode;
                            item.immS.SideEffectFrequency = tblF.GetLstFreqenty().FirstOrDefault(x => x.FreqentyDis == item.comboBox1.SelectedItem.ToString()).FreqentyKode;
                            item.immS.Status = true;
                       
                            tblImmSE.AddNew(item.immS);
                 

                        }
                    }
                    Control c = this;
                    c.Controls.Remove(panel2);
                    c.Controls.Remove(btnGoOnTwo);
                    ImmunistationDeatils uImm = new ImmunistationDeatils();
                    c.Controls.Add(uImm);
                }
            }
        }
   
        private void CreateSideEffect()
        {
            Control[] cArr = new Control[tblSE.Size()];
            int i = 0;
            foreach (SideEffect item in tblSE.GetLstSideEffects())
            {
                SideEffectChose uSEC = new SideEffectChose(item);
                uSEC.s = item;
                cArr[i] = uSEC;
                i++;
                uSEC.Dock = DockStyle.Top;
            }
            panel2.Controls.AddRange(cArr);

 
        }

        private void btnElse_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CreateFields())
            {
                combHow.Items.Add(textBox1.Text);
                panel3.Visible = false;
            }
        }

        public bool CreateFields()
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (textBox1.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                if (combHow.Items.Contains(textBox1.Text))
                    throw new Exception("אופן זה כבר קים במערכת");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                flagOK = false;
            }
            return flagOK;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txtPortion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }
    }
}
