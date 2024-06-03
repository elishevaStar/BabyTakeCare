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
    public partial class BabyBeg : UserControl
    {
        Baby baby;
        string path = "";
        Control cParent;
        AppointmentDB tblApp;
        Appointment a;
        WorkerDB tblWorker;
        NotesDB tblNote;
        bool flagOK;
        Notes note;
        public BabyBeg(Baby baby, Control cparent)
        {
            InitializeComponent();
            this.baby = baby;
            panel1.Visible = false;
            flagOK = true;
            panel2.Visible = false;
            tblApp = new AppointmentDB();
            tblNote = new NotesDB();
            tblWorker = new WorkerDB();
            comboBox1.DataSource = tblWorker.GetLstWorker().Where(x => x.BranchOfWorker().BranchKode==baby.BranchKode && x.SubjectKode!=4 && x.Status==true).Select(y=>y.ToString()).ToList();
            comboBox1.SelectedIndex = -1;
            dataGridViewB.DataSource = tblApp.GetLstAppointments().Where(y => y.IdNumB == baby.IdNumB).Select(x => new {שם = x.WorkerOfAppointment().ToString(), x.DisAppointmentOfAppointment().VisitDis, x.Date, x.AttendantInformation, x.MotherInformation, x.Notes,x.VisitKode }).OrderBy(x=>x.Date).ToList();
            dataGridViewB.Columns[0].HeaderText = "שם הרופא המטפל";
            dataGridViewB.Columns[1].HeaderText = "סוג הביקור";
            dataGridViewB.Columns[2].HeaderText = "תאריך הביקור";
            dataGridViewB.Columns[3].HeaderText = "מידע של המטפל";
            dataGridViewB.Columns[4].HeaderText = "מידע של האם";
            dataGridViewB.Columns[5].HeaderText = "הערות";
            dataGridViewB.Columns[6].HeaderText = "קוד ביקור";
            dataGridViewB.Columns[6].Visible = false;
            string a = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            string b = Directory.GetParent(a).ToString();
            path += b + @"\Resources\";
            if (baby.Kind == "זכר")
            {
                this.BackgroundImage = Image.FromFile(path + " רקעים.jpg");
            }
            else
                this.BackgroundImage = Image.FromFile(path + "רקעים2.jpg");
            cParent = cparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cParent.Visible = true;
            this.Parent.Controls.Remove(this);
        }

        private void btnAddBaby_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
                panel1.Visible = true;
            else
                panel1.Visible =false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            note = new Notes();
            if (CreateFields(note))
            {
               tblNote.AddNew(note);
               panel1.Visible = false;
               txtSubject.Text = "";
               txtDis.Text = "";
               comboBox1.SelectedIndex = -1;
                MessageBox.Show("פניתך נשלחה בהצלחה!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }
        public bool CreateFields(Notes n)
        {

            flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (txtSubject.Text == "")
                    throw new Exception("יש להזין את נושא הפניה!");
                note.NoteSubject = txtSubject.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSubject, ex.Message);
                flagOK = false;
            }
            try
            {
                if (txtDis.Text == "")
                    throw new Exception("יש להזין את תאור הפניה!");
                note.NoteDis = txtDis.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDis, ex.Message);
                flagOK = false;
            }
            try
            {
                if (comboBox1.Text == "")
                    throw new Exception("יש לבחור את מקבל הפניה!");
                note.IdNumW = tblWorker.GetLstWorker().FirstOrDefault(x =>  x.ToString() == comboBox1.Text).IdNumW;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox1, ex.Message);
                flagOK = false;
            }
            note.IdNumB = baby.IdNumB;
            note.NoteKode = tblNote.GetNextKey();
            note.Date = DateTime.Now;
            note.Status = true;
            return flagOK;

        }

        private void dataGridViewB_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            a = tblApp.GetLstAppointments().FirstOrDefault(x => x.VisitKode ==Convert.ToInt32( dataGridViewB.SelectedRows[0].Cells[6].Value) /*&& x.DisAppointmentOfAppointment().VisitDis == dataGridViewB.SelectedRows[0].Cells[1].Value.ToString()*/);
            if((dataGridViewB.SelectedRows[0].Cells[1].Value).ToString()=="מעקב התפתחות")
            {
                DevelopmentBeg uDBeg = new DevelopmentBeg(a,panel2);
                panel2.Visible = true;
                panel2.Controls.Add(uDBeg);
                uDBeg.Dock = DockStyle.Fill;
            }
        }
    }
}
