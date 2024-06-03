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
using System.IO;

namespace BabyTakeCare.GUI
{
    public partial class WorkerHome : Form
    {
        BabyDB tblBaby;
        string path = "";
        Baby baby;
        Worker w;
        Appointment a;
        AppointmentDB tblAp;
        NotesDB tblNote;
        Notes note;
        DisAppointmentDB tblDisAppointment;
        bool flag = false;
        int age;
        
        public WorkerHome(Worker w)
        {
            InitializeComponent();
            panel3.Visible = false;
            this.w = w;
            tblDisAppointment = new DisAppointmentDB();
            tblNote = new NotesDB();
            note = new Notes();
            combKindTreat.DataSource = tblDisAppointment.GetLstDisAppointments().Where(y=>y.VisitDis!="חדש").Select(x => x.VisitDis).ToList();
            combKindTreat.SelectedIndex = -1;
            dataGridViewN.Visible = false;
            dataGridViewN.DataSource = tblNote.GetLstNotes().Where(y => y.IdNumW == w.IdNumW && y.Status==true).Select(x => new { שם=x.BabyOfNotes().ToString(), x.NoteSubject, x.Date,x.NoteKode}).ToList();
            dataGridViewN.Columns[0].HeaderText = "שם השולח";
            dataGridViewN.Columns[1].HeaderText = "נושא הפניה";
            dataGridViewN.Columns[2].HeaderText = "תאריך השליחה";
            dataGridViewN.Columns[3].HeaderText = "קוד השולח";
            dataGridViewN.Columns[3].Visible = false;
            tblBaby = new BabyDB();
            tblAp = new AppointmentDB();
            baby = new Baby();
            flag = true;
        }
        private int Age()
        {
            int year,month;
            year = DateTime.Today.Year - baby.DateOfBirth.Year;
            month = DateTime.Today.Month - baby.DateOfBirth.Month;
            if(year==0)
            {
                return month; 
            }
            return year*12+month;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            path = "";
            baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == txtid.Text && x.Status==true);
            if (baby != null)
            {
                lError.Text = null;
                lName.Text = baby.PrivateName + " " + baby.FamiliyName;
                lAge.Text =Age()+" "+"חודשים";
                age = Age();
                lKind.Text = baby.Kind;
                lHigh.Text ="גובה לידה"+" " + baby.BornHigh.ToString();
                lWeigh.Text ="משקל לידה"+" "+ baby.BornWeight.ToString();
                panelDeatils.Visible = Visible;
                combKindTreat.Visible = true;
                label1.Visible = true;
                btnUpDate.Visible = true;
                btnDelete.Visible = true;
                string a = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
                string b = Directory.GetParent(a).ToString();
                path += b + @"\Resources\";
                if (baby.Kind == "זכר")
                {
                    this.BackgroundImage = Image.FromFile(path + "רקעים.jpg");
                }
                else
                    this.BackgroundImage = Image.FromFile(path + "רקעים2.jpg");


            }
            else
            {
                if (txtid.Text == null) 
                {
                    lError.Text = "ערך חסר";
                    lError.Visible = Visible;
                    txtid.Text = null;
                    
                }
                if (!Validation.CheckId(txtid.Text))
                {
                    lError.Text = "מספר הזהות שהוקש שגוי";
                    lError.Visible = Visible;
                    txtid.Text = null;
                    
                }
                else
                {
                    lError.Text = "מספר הזהות אינו מופיע במערכת";
                    lError.Visible = Visible;
                    txtid.Text = null;
                    

                }
            }
        }

        private void WorkerHome_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            NewBaby uBaby = new NewBaby("הוסף",this,w,panel2);
            panel2.Visible = false;
            panel1.Controls.Add(uBaby);
            uBaby.Dock = DockStyle.Fill;
            
            
            
            
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            NewBaby uBaby = new NewBaby("עדכן",this,w,panel2);
            panel2.Visible = false;
            panel1.Controls.Add(uBaby);
            uBaby.Dock = DockStyle.Fill;
            baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == txtid.Text);
            uBaby.Fill(baby);
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק מטופל זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if(r1==DialogResult.Yes)
                baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.IdNumB == txtid.Text);
            baby.Status = false;
            tblBaby.UpDateRow(baby);
        }

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != "")
                {
                    lError.Text = null;
                    lName.Text = baby.PrivateName + " " + baby.FamiliyName;
                    lAge.Text = Age() + " " + "חודשים";
                    age = Age();
                    lKind.Text = baby.Kind;
                    lHigh.Text = "גובה לידה" + " " + baby.BornHigh.ToString();
                    lWeigh.Text = "משקל לידה" + " " + baby.BornWeight.ToString();
                    panelDeatils.Visible = Visible;
                    combKindTreat.Enabled = true;
                    btnUpDate.Visible = true;
                    btnDelete.Visible = true;

                }
               

            }
            finally { }
        }

        private void combKindTreat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (a == null)
                {
                    a = new Appointment();
                    a.VisitKode = tblAp.GetNextKey();
                    a.IdNumB = baby.IdNumB;
                    a.IdNumW = w.IdNumW;
                    a.Date = DateTime.Now;
                    a.VisitDisKode = tblDisAppointment.GetLstDisAppointments().First(x => x.VisitDis == combKindTreat.Text).VisitDisKode;
                    tblAp.AddNew(a);
                }
                if (combKindTreat.Text == "מתן חיסון")
                {
                    panel2.Visible = false;
                    ImmunistationNote immN = new ImmunistationNote(baby,a,panel2);
                    panel1.Controls.Add(immN);
                }
                if (combKindTreat.Text == "מעקב התפתחות")
                {
                    VisitDevelop uVisitD= new VisitDevelop(a,panel2,age);
                    panel2.Visible = false;
                    panel1.Controls.Add(uVisitD);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (dataGridViewN.Visible == false)
                dataGridViewN.Visible = true;
            else
                dataGridViewN.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = false;
            panel3.Visible = false;
        }

        private void dataGridViewN_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            note = tblNote.GetLstNotes().FirstOrDefault(x => x.NoteKode == Convert.ToInt32((dataGridViewN.SelectedRows[0].Cells[3].Value).ToString()));
            textBox1.Text = note.NoteDis;
            panel3.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            note.Status = false;
            tblNote.UpDateRow(note);
            dataGridViewN.DataSource = tblNote.GetLstNotes().Where(y => y.IdNumW == w.IdNumW && y.Status == true).Select(x => new { שם = x.BabyOfNotes().ToString(), x.NoteSubject, x.Date }).ToList();
            panel3.Visible = false;
            textBox1.Text = "";
            radioButton1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewN.Visible == false)
                dataGridViewN.Visible = true;
            else
                dataGridViewN.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            btnSearch.Visible = true;
            label3.Visible = true;    
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }
    }
}
