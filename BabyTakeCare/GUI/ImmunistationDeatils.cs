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
    public partial class ImmunistationDeatils : UserControl
    {
        Immunisation imm;
        ImmunisationDB tblImm;
        public ImmunistationDeatils()
        {
            InitializeComponent();
            panel3.Visible = false;
            tblImm = new ImmunisationDB();
            dataGridViewI.DataSource = tblImm.GetLstImmunisations().Where(y => y.Status == true).Select(x => new {x.ImmunisationKode, x.ImmunisationName, x.NumPoration,x.Way,x.TimeEffect}).OrderBy(y=>y.ImmunisationKode).ToList();
            dataGridViewI.Columns[0].HeaderText = "קוד חיסון";
            dataGridViewI.Columns[1].HeaderText = "שם החסון";
            dataGridViewI.Columns[2].HeaderText = "מס' מנות החיסון";
            dataGridViewI.Columns[3].HeaderText = "דרך נתינת החיסון";
            dataGridViewI.Columns[4].HeaderText = "זמן השפעת החיסון";

        }

        private void btnAddI_Click(object sender, EventArgs e)
        {
            NewImm uImm = new NewImm("המשך");
            this.Parent.Controls.Add(uImm);
            this.Parent.Controls.Remove(this);
            uImm.Dock = DockStyle.Fill;
        }

        private void btnSE_Click(object sender, EventArgs e)
        {
            imm = tblImm.GetLstImmunisations().FirstOrDefault(x => x.ImmunisationKode == Convert.ToInt32(dataGridViewI.CurrentRow.Cells[0].Value.ToString()));
            panel1.Controls.Clear();
            SideEffEctDeatils uSE = new SideEffEctDeatils(imm);
            panel2.Visible = false;
            panel1.Controls.Add(uSE);
            uSE.Dock = DockStyle.Fill;
        }

        private void btnUpDateI_Click(object sender, EventArgs e)
        {
            imm= tblImm.GetLstImmunisations().FirstOrDefault(x => x.ImmunisationKode == Convert.ToInt32(dataGridViewI.CurrentRow.Cells[0].Value.ToString()));
            NewImm uImm = new NewImm("עדכן");
            this.Parent.Controls.Add(uImm);
            this.Parent.Controls.Remove(this);
            uImm.Dock = DockStyle.Fill;
            uImm.Fill(imm);

        }

        private void btnPortion_Click(object sender, EventArgs e)
        {
            imm = tblImm.GetLstImmunisations().FirstOrDefault(x => x.ImmunisationKode == Convert.ToInt32(dataGridViewI.CurrentRow.Cells[0].Value.ToString()));
            panel1.Controls.Clear();
            PortionDeatils uPortion = new PortionDeatils(imm);
            panel2.Visible = false;
            panel1.Controls.Add(uPortion);
            uPortion.Dock = DockStyle.Fill;
        }

        private void btnDeleteI_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק חיסון זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
               imm = tblImm.GetLstImmunisations().FirstOrDefault(x => x.ImmunisationKode == Convert.ToInt32(dataGridViewI.CurrentRow.Cells[0].Value.ToString()));
            imm.Status = false;
            tblImm.UpDateRow(imm);
            dataGridViewI.DataSource = tblImm.GetLstImmunisations().Where(y => y.Status == true).Select(x => new { x.ImmunisationKode, x.ImmunisationName, x.NumPoration, x.Way, x.TimeEffect }).OrderBy(y => y.ImmunisationKode).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
                panel3.Visible = true;
            else
                panel3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewI.DataSource=tblImm.GetLstImmunisations().Where(x=>x.Status==true && x.ImmunisationName.StartsWith(textBox1.Text)).Select(x => new { x.ImmunisationKode, x.ImmunisationName, x.NumPoration, x.Way, x.TimeEffect }).OrderBy(y => y.ImmunisationKode).ToList();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }
    }
}
