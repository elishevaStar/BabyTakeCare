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
    public partial class EnterForm : Form
    {
        BabyDB tblBaby;
        WorkerDB tblWorker;
        Baby b;
        Worker w;
        public EnterForm()
        {
            InitializeComponent();
            tblBaby = new BabyDB();
            tblWorker = new WorkerDB();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string s = "";
            bool flag = true, flag1 = true;
            if (txtCode.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("יש למלא את כל הנתונים הנדרשים","שגיאה",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
                flag = false;
            }
            if (flag)
            {
                if (tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumP == txtId.Text) == null)
                {
                    s = "מספר תעודת הזהות אינה קיימת במערכת ";
                }
                if (tblBaby.GetLstBabies().FirstOrDefault(y => y.BabyKode == Convert.ToInt32(txtCode.Text)) == null)
                {
                    s += "הקוד הסודי שגוי ";
                }
                if (s == "")
                {
                    b = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumP == txtId.Text);
                    BabyHome frmB = new BabyHome(b);
                    flag1 = false;
                    frmB.Show();
                    this.Hide();
                }
                if (flag1)
                {
                    s = "";
                    if (tblWorker.GetLstWorker().FirstOrDefault(x => x.IdNumW == txtId.Text) == null)
                    {
                        s = "מספר תעודת הזהות אינה קיימת במערכת ";
                        txtId.Text = "";
                    }
                    if (tblWorker.GetLstWorker().FirstOrDefault(y => y.WorkerKode == Convert.ToInt32(txtCode.Text)) == null)
                    {
                        s += "הקוד הסודי שגוי ";
                        txtCode.Text = "";
                    }
                    if (s == "")
                    {

                        if (tblWorker.GetLstWorker().FirstOrDefault(y => y.IdNumW == txtId.Text).SubjectKode == 4)
                        {
                            w = tblWorker.GetLstWorker().FirstOrDefault(x => x.WorkerKode == Convert.ToInt32(txtCode.Text));
                            ManagerHome frmM = new ManagerHome( w);
                            frmM.Show();
                            this.Hide();
                        }

                        else
                        {
                            w = tblWorker.GetLstWorker().FirstOrDefault(x => x.IdNumW == txtId.Text);
                            WorkerHome frmW = new WorkerHome(w);
                            frmW.Show();
                            this.Hide();
                        }
           
                    }
                    if (s != "")
                        MessageBox.Show(s, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    //txtCode.Text = "";
                    //txtId.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = txtCode.Text;

            if (txtCode.Visible==true)
            {
                txtCode.Visible = false;
                txtChange.Text = str;
                txtChange.Visible = true;
                txtChange.Enabled = false;
            }
            else
            {
                txtChange.Visible = false;
                txtCode.Visible = true;
            }
                
     
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }
    }
}
