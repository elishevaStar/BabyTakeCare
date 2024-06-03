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
    public partial class NewWorkerM : UserControl
    {
        Worker w;
        WorkerDB tblWorker;
        NationalDB tblNational;
        SubjectDB tblSubject;
        BranchDB tblBranch;
        Worker worker;
        bool flag;
        Subject s;
        DialogResult r1;
        public NewWorkerM(string str,Worker w)
        {
            InitializeComponent();
            this.w = w;
            flag = true;
            s = new Subject();
            tblWorker = new WorkerDB();
            tblBranch =  new BranchDB();
            tblNational = new NationalDB();
            tblSubject = new SubjectDB();
            combNational.DataSource = tblNational.GetLstNationals().Select(x => x.NationalDescription).ToList();
            combNational.SelectedIndex = -1;
            combSubject.DataSource = tblSubject.GetLstSubject().Select(x => x.SubjectDis).ToList();
            combSubject.SelectedIndex = -1;
            combKind.SelectedIndex = -1;
            combBranch.DataSource = tblBranch.GetLstBranches().Where(x => x.CityOfBranch().CityName == w.BranchOfWorker().CityOfBranch().CityName).ToList();
            combBranch.SelectedIndex = -1;
            button1.Text = str;


        }

        public void Fill(Worker worker)
        {
            this.worker = worker;
            txtPN.Text = worker.PrivateName;
            txtFN.Text = worker.FamiliyName;
            txtIdW.Text = worker.IdNumW;
            txtIdW.ReadOnly = true;
            dateTimeBegin.Value = worker.BeginDate;
            txtSalary.Text= worker.Salary.ToString();
            txtAddress.Text = worker.Address;
            txtPhone.Text = worker.TelNum;
            txtAge.Text = worker.Age.ToString();
            combKind.SelectedItem = worker.Kind;
            combKind.Text =worker.Kind.ToString();
            combNational.SelectedItem = worker.NationalOfWorker();
            combNational.Text = worker.NationalOfWorker().ToString();
            combBranch.SelectedItem = worker.BranchOfWorker();
            combBranch.Text =worker.BranchOfWorker().ToString();
            combSubject.SelectedItem = worker.SubjectOfWorker();
            combSubject.Text = worker.SubjectOfWorker().ToString();
            txtKode.Text = worker.WorkerKode.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "הוסף")
            {
                worker = new Worker();
                if (CreateFields(worker))
                {
                    if(tblWorker.GetLstWorker().FirstOrDefault(x=>x.Status==false && x.IdNumW == txtIdW.Text)!=null)
                    {
                        r1 = MessageBox.Show("עובד זה כבר קים במערכת אך אינו פעיל האם ברצונך להפעילו!", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        if (r1 == DialogResult.Yes)
                        {
                            worker = tblWorker.GetLstWorker().FirstOrDefault(x => x.IdNumW == txtIdW.Text);
                            worker.Status = true;
                            tblWorker.UpDateRow(worker);
                        }
                    }
                    if (tblWorker.GetLstWorker().FirstOrDefault(x=>x.Status==true && x.IdNumW == txtIdW.Text) != null)
                    {
                        DialogResult r1 = MessageBox.Show("עובד זה כבר פעיל במערכת!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                       txtIdW.Text = "";
                        
                    }


                    else
                    {
                        if (r1 == DialogResult.No)
                        {
                            txtIdW.Text = "";
                        }
                        if(txtIdW.Text!="")
                        {
                            DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף עובד זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                            if (r2 == DialogResult.Yes)
                            {
                                worker.Status = true;
                                tblWorker.AddNew(worker);
                                button1.Enabled = false;
                                WorkerDeatils uWorker = new WorkerDeatils(w);
                                this.Parent.Controls.Add(uWorker);
                                uWorker.Dock = DockStyle.Fill;
                                this.Parent.Controls.Remove(this);


                            }
                        }
                        
                    }


                }
            }
            else
            {
                if (CreateFields(worker))
                {
                    DialogResult r1 = MessageBox.Show("האם ברצונך לעדכן עובד זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r1 == DialogResult.Yes)
                    {
                        tblWorker.UpDateRow(worker);
                        worker.Status = true;
                        WorkerDeatils uWorker = new WorkerDeatils(w);
                        this.Parent.Controls.Add(uWorker);
                        uWorker.Dock = DockStyle.Fill;
                        this.Parent.Controls.Remove(this);



                    }
                }

            }

        }

        public bool CreateFields(Worker worker)
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (txtPN.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtPN.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                worker.PrivateName = txtPN.Text;
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
                worker.FamiliyName = txtFN.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFN, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtIdW.Text == "")
                    throw new Exception("יש להכניס ערך");
                worker.IdNumW = txtIdW.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtIdW, ex.Message);
                flagOK = false;

            }
            try
            {
                if (dateTimeBegin.Value > DateTime.Now)
                    throw new Exception("התאריך אינו תקין!");
                worker.BeginDate = dateTimeBegin.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtIdW, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtSalary.Text == "")
                    throw new Exception("יש להכניס ערך");
                worker.Salary = Convert.ToInt32(txtSalary.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSalary, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtAddress.Text == "")
                    throw new Exception("יש להכניס ערך");
                worker.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAddress, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtPhone.Text == "")
                    throw new Exception("יש להכניס ערך");
                worker.TelNum = txtPhone.Text;
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
                worker.Kind = combKind.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combKind, ex.Message);
                flagOK = false;

            }
            try
            {
                if (combSubject.SelectedItem == null)
                    throw new Exception("יש להכניס ערך");
                worker.SubjectKode = tblSubject.GetLstSubject().FirstOrDefault(x => x.SubjectDis == combSubject.SelectedItem.ToString()).SubjectKode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combSubject, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtAge.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (Convert.ToInt32(txtAge.Text)>67)
                    throw new Exception("!אינך יכול לעבוד יותר כשכיר");
                worker.Age = Convert.ToInt32(txtAge.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAge, ex.Message);
                flagOK = false;

            }
            try
            {
                if (combNational.SelectedItem == null)
                    throw new Exception("יש להכניס ערך");
                worker.NationalKode = tblNational.GetLstNationals().FirstOrDefault(x => x.NationalDescription == combNational.SelectedItem.ToString()).NationalNum;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combNational, ex.Message);
                flagOK = false;

            }
            try
            {
                if (combBranch.SelectedItem == null)
                    throw new Exception("יש להכניס ערך");
                worker.BranchKode= tblBranch.GetLstBranches().FirstOrDefault(x => x.ToString() == combBranch.SelectedItem.ToString()).BranchKode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combBranch, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtKode.Text == "")
                    throw new Exception("יש להכניס ערך");
                worker.WorkerKode= Convert.ToInt32(txtKode.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKode, ex.Message);
                flagOK = false;

            }
            return flagOK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = true;
            errorProvider1.Clear();
            try
            {
                if (txtKodeS.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (!Validation.IsNum(txtKodeS.Text))
                    throw new Exception("יש להכניס מספרים!");
                if (tblSubject.GetLstSubject().FirstOrDefault(x => x.SubjectKode == Convert.ToInt32(txtKodeS.Text)) != null)
                    throw new Exception("קוד זה כבר קים!");
                s.SubjectKode = Convert.ToInt32(txtKodeS.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKodeS, ex.Message);
                flag = false;
            }
            try
            {
                if (txtSubject.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtSubject.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                if (!Validation.IsHebrew(txtSubject.Text))
                    throw new Exception("יש להכניס אותיות בעברית! ");
                s.SubjectDis = txtSubject.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSubject, ex.Message);
                flag = false;
            }
            if (tblSubject.GetLstSubject().FirstOrDefault(x => x.SubjectDis == txtSubject.Text) != null)
            {
                DialogResult r1 = MessageBox.Show("מקצוע זה כבר פעיל במערכת!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                txtSubject.Text = "";
                flag = false;
            }
            if (flag)
            {
                DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף מקצוע זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (r2 == DialogResult.Yes)
                {
                    btnSave.Visible = false;
                    tblSubject.AddNew(s);
                    combSubject.DataSource = tblSubject.GetLstSubject().Select(x => x.SubjectDis).ToList();
                    combSubject.SelectedIndex = -1;
                    panel1.Visible = false;

                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void txtPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txtFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txtIdW_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }

        private void txtKodeS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberDouble(e.KeyChar);
        }
    }
}
