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
    public partial class NewDisDevelopment : UserControl
    {
        DisDevelopment d;
        DisDevelopmentDB tblDisDevelopment;
        ComboBox cmb;
        
        public NewDisDevelopment(ComboBox combAfter)
        {
            InitializeComponent();
            tblDisDevelopment = new DisDevelopmentDB();
            this.cmb = combAfter;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            d = new DisDevelopment();
            if (CreateFields(d))
            {
                if (tblDisDevelopment.GetLstDisDevelopments().FirstOrDefault(y => y.DevelopmentDis == txtName.Text) != null)
                {
                    DialogResult r1 = MessageBox.Show("סוג מעקב זה כבר קים במערכת", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    txtName.Text = "";

                }


                else
                {
                    if (txtName.Text != "")
                    {

                        DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף סוג מעקב זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        if (r2 == DialogResult.Yes)
                        {
                            d.DisDevelopmentKode = tblDisDevelopment.GetNextKey();
                            tblDisDevelopment.AddNew(d);
                            btnAdd.Enabled = false;
                            this.Parent.Controls.Remove(this);
                            cmb.DataSource = tblDisDevelopment.GetLstDisDevelopments().Select(x => x.DevelopmentDis).ToList();
                            cmb.SelectedIndex = -1;



                        }
                    }
                }

            }
        }

        public bool CreateFields(DisDevelopment d)
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (txtName.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtName.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                d.DevelopmentDis = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                flagOK = false;

            }

            return flagOK;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }
    }
}
