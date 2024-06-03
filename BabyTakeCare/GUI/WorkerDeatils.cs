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
    public partial class WorkerDeatils : UserControl
    {
        Worker w;
        WorkerDB tblWorker;
        Worker worker;
        public WorkerDeatils(Worker w)
        {
            InitializeComponent();
            this.w = w;
            tblWorker = new WorkerDB();
            dataGridViewW.DataSource = tblWorker.GetLstWorker().Where(y => y.Status == true && y.BranchOfWorker().CityOfBranch().CityName == w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.IdNumW, x.PrivateName, x.FamiliyName, x.BeginDate, x.Salary, x.Address, x.TelNum, x.Kind, x.SubjectOfWorker().SubjectDis, x.Age, x.NationalOfWorker().NationalDescription, x.BranchOfWorker().AddressBr }).OrderBy(x=>x.FamiliyName).ToList();
            dataGridViewW.Columns[0].HeaderText = "ת.ז. עובד";
            dataGridViewW.Columns[1].HeaderText = "שם פרטי";
            dataGridViewW.Columns[2].HeaderText = "שם משפחה";
            dataGridViewW.Columns[3].HeaderText = "תחילת עבודה";
            dataGridViewW.Columns[4].HeaderText = "משכורת";
            dataGridViewW.Columns[5].HeaderText = "כתובת";
            dataGridViewW.Columns[6].HeaderText = "פלאפון";
            dataGridViewW.Columns[7].HeaderText = "מין";
            dataGridViewW.Columns[8].HeaderText = "מקצוע";
            dataGridViewW.Columns[9].HeaderText = "גיל";
            dataGridViewW.Columns[10].HeaderText ="לאום";
            dataGridViewW.Columns[11].HeaderText = "סניף";
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            NewWorkerM uWorker = new NewWorkerM("הוסף", w);
            this.Parent.Controls.Add(uWorker);
            this.Parent.Controls.Remove(this);
            uWorker.Dock = DockStyle.Fill;
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק עובד זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
                worker = tblWorker.GetLstWorker().FirstOrDefault(x => x.IdNumW == dataGridViewW.CurrentRow.Cells[0].Value.ToString());
            worker.Status = false;
            tblWorker.UpDateRow(worker);
            dataGridViewW.DataSource = tblWorker.GetLstWorker().Where(y => y.Status == true && y.BranchOfWorker().CityOfBranch().CityName == w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.IdNumW, x.PrivateName, x.FamiliyName, x.BeginDate, x.Salary, x.Address, x.TelNum, x.Kind, x.SubjectOfWorker().SubjectDis, x.Age, x.NationalOfWorker().NationalDescription, x.BranchOfWorker().AddressBr }).OrderBy(x=>x.FamiliyName).ToList();
        }

        private void btnUpDateW_Click(object sender, EventArgs e)
        {
            NewWorkerM uWorker = new NewWorkerM("עדכן", w);
            this.Parent.Controls.Add(uWorker);
            this.Parent.Controls.Remove(this);
            uWorker.Dock = DockStyle.Fill;
            worker = tblWorker.GetLstWorker().FirstOrDefault(x => x.IdNumW == dataGridViewW.CurrentRow.Cells[0].Value.ToString());
            uWorker.Fill(worker);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewW.DataSource=tblWorker.GetLstWorker().Where(x=>x.Status==true && x.IdNumW.StartsWith(textBox1.Text) && x.BranchOfWorker().CityOfBranch().CityName == w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.IdNumW, x.PrivateName, x.FamiliyName, x.BeginDate, x.Salary, x.Address, x.TelNum, x.Kind, x.SubjectOfWorker().SubjectDis, x.Age, x.NationalOfWorker().NationalDescription, x.BranchOfWorker().AddressBr }).OrderBy(x => x.FamiliyName).ToList();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);
        }
    }
}
