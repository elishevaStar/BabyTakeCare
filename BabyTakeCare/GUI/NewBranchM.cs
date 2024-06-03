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
    public partial class NewBranchM : UserControl
    {
        Worker w;
        Branch branch;
        BranchDB tblBranch;
        DialogResult r1;
        CityDB tblCity;
        bool flag;
        public NewBranchM(string str, Worker w)
        {
            InitializeComponent();
            tblCity = new CityDB();
            flag = true;
            this.w = w;
            button1.Text = str;
            tblBranch = new BranchDB();
            txtCity.Text = w.BranchOfWorker().CityOfBranch().CityName;
            txtCity.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "הוסף")
            {
                branch = new Branch();
                if (CreateFields(branch))
                {
                    if (tblBranch.GetLstBranches().FirstOrDefault(x => x.CityOfBranch().CityName==txtCity.Text && x.AddressBr==txtStreet.Text) != null)
                    {
                        DialogResult r1 = MessageBox.Show("סניף זה כבר פעיל במערכת!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        flag = false;
                    }
                    else
                    {
                        if(flag)
                        {
                            DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף סניף זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                            if (r2 == DialogResult.Yes)
                            {
                                branch.Status = true;
                                branch.BranchKode = tblBranch.GetNextKey();
                                branch.City = w.BranchOfWorker().CityOfBranch().CityKode;
                                tblBranch.AddNew(branch);
                                button1.Enabled = false;
                                BranchDeatils uBranch = new BranchDeatils(w);
                                this.Parent.Controls.Add(uBranch);
                                uBranch.Dock = DockStyle.Fill;
                                this.Parent.Controls.Remove(this);


                            }
                        }
                        
                    }


                }
            }
            else
            {
                if (CreateFields(branch))
                {
                    DialogResult r1 = MessageBox.Show("האם ברצונך לעדכן סניף זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r1 == DialogResult.Yes)
                    {
                        tblBranch.UpDateRow(branch);
                        branch.Status = true;
                        BranchDeatils uBranch = new BranchDeatils(w);
                        this.Parent.Controls.Add(uBranch);
                        uBranch.Dock = DockStyle.Fill;
                        this.Parent.Controls.Remove(this);



                    }
                }

            }
        }

        public void Fill(Branch branch)
        {
            this.branch = branch;
            txtPhone.Text = branch.TelNum;
            txtStreet.Text= branch.AddressBr; 
        }

        public bool CreateFields(Branch branch)
        {

            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (txtPhone.Text == "")
                    throw new Exception("יש להכניס ערך");
               branch.TelNum = txtPhone.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtStreet.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtStreet.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                branch.AddressBr = txtStreet.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtStreet, ex.Message);
                flagOK = false;


            }



            return flagOK;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberPhone(e.KeyChar);
        }

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

       
    }
}
