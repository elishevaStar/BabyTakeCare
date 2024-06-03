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
    public partial class BranchDeatils : UserControl
    {
        Branch branch;
        BranchDB tblBranch;
        Worker w;
        public BranchDeatils(Worker w)
        {
            InitializeComponent();
            this.w = w;
            tblBranch = new BranchDB();
            dataGridViewB.DataSource = tblBranch.GetLstBranches().Where(y => y.Status == true && y.CityOfBranch().CityName== w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.BranchKode, x.AddressBr,x.TelNum }).OrderBy(x=>x.AddressBr).ToList();
            dataGridViewB.Columns[0].HeaderText = "קוד הסניף";
            dataGridViewB.Columns[1].HeaderText = "כתובת הסניף";
            dataGridViewB.Columns[2].HeaderText = "טלפון הסניף";
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            NewBranchM uBranch = new NewBranchM("הוסף", w);
            this.Parent.Controls.Add(uBranch);
            this.Parent.Controls.Remove(this);
            uBranch.Dock = DockStyle.Fill;
        }

        private void btnUpDateB_Click(object sender, EventArgs e)
        {
           NewBranchM uBranch = new NewBranchM("עדכן", w);
            this.Parent.Controls.Add(uBranch);
            this.Parent.Controls.Remove(this);
            uBranch.Dock = DockStyle.Fill;
            branch = tblBranch.GetLstBranches().FirstOrDefault(x => x.BranchKode ==Convert.ToInt32( dataGridViewB.CurrentRow.Cells[0].Value));
            uBranch.Fill(branch);
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק סניף זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
                branch = tblBranch.GetLstBranches().FirstOrDefault(x => x.BranchKode == Convert.ToInt32(dataGridViewB.CurrentRow.Cells[0].Value));
            branch.Status = false;
            tblBranch.UpDateRow(branch);
            dataGridViewB.DataSource = tblBranch.GetLstBranches().Where(y => y.Status == true && y.CityOfBranch().CityName == w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.BranchKode, x.AddressBr, x.TelNum }).OrderBy(x => x.AddressBr).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewB.DataSource=tblBranch.GetLstBranches().Where(x=>x.Status==true && x.AddressBr.StartsWith(textBox1.Text) && x.CityOfBranch().CityName == w.BranchOfWorker().CityOfBranch().CityName).Select(x => new { x.BranchKode, x.AddressBr, x.TelNum }).OrderBy(x => x.AddressBr).ToList();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }
    }
}
