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
    public partial class BabyDeatils : UserControl
    {
        BabyDB tblBaby;
        Baby baby;
        Worker w;
        BLL.Sensitive sensitive;
        SensitiveDB tblS;
        bool flag;
        
        public BabyDeatils(Worker w)
        {
            InitializeComponent();
            tblBaby = new BabyDB();
            tblS = new SensitiveDB();
            sensitive = new BLL.Sensitive();
            this.w = w;
            flag = true;
            dataGridViewB.DataSource = tblBaby.GetLstBabies().Where(y=>y.Status==true && y.CityOfBaby().CityName==w.BranchOfWorker().CityOfBranch().CityName).Select(x=>new {x.IdNumP,x.IdNumB,x.PrivateName,x.FamiliyName,x.BornHigh,x.BornWeight,x.CityOfBaby().CityName,x.Address,x.TelNum,x.Kind,x.NationalOfBaby().NationalDescription,x.PrivateNameFather,x.PrivateNameMother,x.DateOfBirth,x.BranchOfBaby().AddressBr }).OrderBy(x=>x.FamiliyName).ToList();
            dataGridViewB.Columns[0].HeaderText = "ת.ז אם.";
            dataGridViewB.Columns[1].HeaderText = "ת.ז תינוק.";
            dataGridViewB.Columns[2].HeaderText = "שם פרטי";
            dataGridViewB.Columns[3].HeaderText = "שם משפחה";
            dataGridViewB.Columns[4].HeaderText = "גובה לידה";
            dataGridViewB.Columns[5].HeaderText = "משקל לידה";
            dataGridViewB.Columns[6].HeaderText = "עיר";
            dataGridViewB.Columns[7].HeaderText = "כתובת";
            dataGridViewB.Columns[8].HeaderText = "מס' פלאפון";
            dataGridViewB.Columns[9].HeaderText = "מין";
            dataGridViewB.Columns[10].HeaderText = "לאום";
            dataGridViewB.Columns[11].HeaderText = "שם האב";
            dataGridViewB.Columns[12].HeaderText = "שם האם";
            dataGridViewB.Columns[13].HeaderText = "תאריך לידה";
            dataGridViewB.Columns[14].HeaderText = "סניף";
        }

        private void btnAddBaby_Click(object sender, EventArgs e)
        {
            NewBabyM uBaby = new NewBabyM("הוסף",w);
            this.Parent.Controls.Add(uBaby);
            this.Parent.Controls.Remove(this);
            uBaby.Dock = DockStyle.Fill;


        }

        private void btnUpDateBaby_Click(object sender, EventArgs e)
        {
            NewBabyM uBaby = new NewBabyM("עדכן",w);
            this.Parent.Controls.Add(uBaby);
            this.Parent.Controls.Remove(this);
            uBaby.Dock = DockStyle.Fill;
            baby= tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == dataGridViewB.CurrentRow.Cells[1].Value.ToString());
            uBaby.Fill(baby);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק מטופל זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
                baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == dataGridViewB.CurrentRow.Cells[1].Value.ToString());
            baby.Status = false;
            tblBaby.UpDateRow(baby);
            dataGridViewB.DataSource = tblBaby.GetLstBabies().Where(y => y.Status == true && y.CityOfBaby().CityName == w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.IdNumP, x.IdNumB, x.PrivateName, x.FamiliyName, x.BornHigh, x.BornWeight, x.CityOfBaby().CityName, x.Address, x.TelNum, x.Kind, x.NationalOfBaby().NationalDescription, x.PrivateNameFather, x.PrivateNameMother, x.DateOfBirth, x.BranchOfBaby().AddressBr }).OrderBy(x => x.FamiliyName).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewB.DataSource = tblBaby.GetLstBabies().Where(x => x.IdNumB.StartsWith(textBox1.Text)&&x.Status==true && x.CityOfBaby().CityName == w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.IdNumP, x.IdNumB, x.PrivateName, x.FamiliyName, x.BornHigh, x.BornWeight, x.CityOfBaby().CityName, x.Address, x.TelNum, x.Kind, x.NationalOfBaby().NationalDescription, x.PrivateNameFather, x.PrivateNameMother, x.DateOfBirth, x.BranchOfBaby().AddressBr }).OrderBy(x => x.FamiliyName).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == dataGridViewB.CurrentRow.Cells[1].Value.ToString());
            panel1.Controls.Clear();
            panel2.Visible = false;
            SensitiveDeatils uSensitive = new SensitiveDeatils(baby);
            panel1.Controls.Add(uSensitive);
            uSensitive.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNewS.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = true;
            errorProvider1.Clear();
            try
            {
                if (txtNewS.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtNewS.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                sensitive.SensitiveDis = txtNewS.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNewS, ex.Message);
                flag = false;
            }
            if (tblS.GetLstSensitives().FirstOrDefault(x => x.SensitiveDis == txtNewS.Text) != null)
            {
                DialogResult r1 = MessageBox.Show("רגישות זו כבר פעילה במערכת!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                txtNewS.Text = "";
                flag = false;
            }
            if (flag)
            {
                DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף רגישות זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (r2 == DialogResult.Yes)
                {
                    button3.Visible = false;
                    sensitive.SensitiveKode = tblS.GetNextKey();
                    tblS.AddNew(sensitive);
                    txtNewS.Visible = false;
                    txtNewS.Text = "";

                }
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }

    }
}
