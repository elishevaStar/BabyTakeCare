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
    public partial class NewDevelopmentM : UserControl
    {
        DevelopmentDB tblDevelopment;
        DisDevelopmentDB tblDisDevelopment;
        Development develop;
        bool flag;
        DialogResult r1;
        public NewDevelopmentM(string str)
        {
            InitializeComponent();
            flag = true;
            tblDevelopment = new DevelopmentDB();
            tblDisDevelopment = new DisDevelopmentDB();
            combAfter.DataSource = tblDisDevelopment.GetLstDisDevelopments().Select(x => x.DevelopmentDis).ToList();
            combAfter.SelectedIndex = -1;
            button1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "הוסף")
            {
                develop = new Development();
                if (CreateFields(develop))
                {
                    if (tblDevelopment.GetLstDevelopments().FirstOrDefault(x =>x.DisDevelopmentOfDevelopment().DevelopmentDis==combAfter.Text) != null)
                    {
                        DialogResult r1 = MessageBox.Show("מעקב זה כבר פעיל במערכת!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        flag = false;
                        
                    }


                    else
                    {
                        if(flag)
                        {
                            DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף מעקב זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                            if (r2 == DialogResult.Yes)
                            {
                                develop.Status = true;
                                develop.DevelopmentKode = tblDevelopment.GetNextKey();
                                tblDevelopment.AddNew(develop);
                                button1.Enabled = false;
                                DevelopmentDeatils uDevelopment= new DevelopmentDeatils();
                                this.Parent.Controls.Add(uDevelopment);
                                uDevelopment.Dock = DockStyle.Fill;
                                this.Parent.Controls.Remove(this);
                            }
                        }
                        
                    }


                }
            }
            else
            {
                if (CreateFields(develop))
                {
                    DialogResult r1 = MessageBox.Show("האם ברצונך לעדכן מעקב זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r1 == DialogResult.Yes)
                    {
                        tblDevelopment.UpDateRow(develop);
                        develop.Status = true;
                        DevelopmentDeatils uDevelopment = new DevelopmentDeatils();
                        this.Parent.Controls.Add(uDevelopment);
                        uDevelopment.Dock = DockStyle.Fill;
                        this.Parent.Controls.Remove(this);



                    }
                }

            }
        }

        public void Fill(Development develop)
        {
            this.develop = develop;
            combAfter.SelectedItem = develop.DisDevelopmentOfDevelopment();
            combAfter.Text = develop.DisDevelopmentOfDevelopment().ToString();
            txtMin.Text = develop.DevelopmentMinAge.ToString();
            txtMax.Text = develop.DevelopmentMaxAge.ToString();
            txtDis.Text = develop.DevelopmentName;
        }
        public bool CreateFields(Development develop)
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (combAfter.SelectedItem == null)
                    throw new Exception("יש להכניס ערך");
                develop.DevelopmentKind = tblDisDevelopment.GetLstDisDevelopments().FirstOrDefault(x => x.ToString() == combAfter.SelectedItem.ToString()).DisDevelopmentKode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combAfter, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtDis.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtDis.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                develop.DevelopmentName = txtDis.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDis, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtMax.Text == "")
                    throw new Exception("יש להכניס ערך");
                develop.DevelopmentMaxAge =Convert.ToInt32(txtMax.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMax, ex.Message);
                flagOK = false;

            }
            try
            {
                if (txtMin.Text == "")
                    throw new Exception("יש להכניס ערך");
                develop.DevelopmentMinAge = Convert.ToInt32(txtMin.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMin, ex.Message);
                flagOK = false;

            }
            return flagOK;
        }

        private void btnAddKindDevelop_Click(object sender, EventArgs e)
        {
            NewDisDevelopment uDisDevelopment = new NewDisDevelopment(combAfter);
            panel1.Controls.Add(uDisDevelopment);
            uDisDevelopment.Dock = DockStyle.Fill;
        }
    }
}
