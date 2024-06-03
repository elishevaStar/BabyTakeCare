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
    public partial class DevelopmentDeatils : UserControl
    {
        Development develop;
        DevelopmentDB tblDevelopment;
        public DevelopmentDeatils()
        {
            InitializeComponent();
            tblDevelopment = new DevelopmentDB();
            dataGridViewD.DataSource = tblDevelopment.GetLstDevelopments().Where(y=>y.Status==true).Select(x => new { x.DevelopmentKode, x.DisDevelopmentOfDevelopment().DevelopmentDis, x.DevelopmentName, x.DevelopmentMinAge, x.DevelopmentMaxAge }).OrderBy(y=>y.DevelopmentDis).ToList();
            dataGridViewD.Columns[0].HeaderText = "קוד מעקב";
            dataGridViewD.Columns[1].HeaderText = "סוג מעקב";
            dataGridViewD.Columns[2].HeaderText = "תאור מעקב";
            dataGridViewD.Columns[3].HeaderText = "גיל מינימלי";
            dataGridViewD.Columns[4].HeaderText = "גיל מקסימלי";
        }

        private void btnAddDevelop_Click(object sender, EventArgs e)
        {
            NewDevelopmentM uDevelopment = new NewDevelopmentM("הוסף");
            this.Parent.Controls.Add(uDevelopment);
            this.Parent.Controls.Remove(this);
            uDevelopment.Dock = DockStyle.Fill;
        }

        private void btnUpDateD_Click(object sender, EventArgs e)
        {
            NewDevelopmentM uDevelopment = new NewDevelopmentM("עדכן");
            this.Parent.Controls.Add(uDevelopment);
            this.Parent.Controls.Remove(this);
            uDevelopment.Dock = DockStyle.Fill;
            develop = tblDevelopment.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKode == Convert.ToInt32(dataGridViewD.CurrentRow.Cells[0].Value.ToString()));
            uDevelopment.Fill(develop);
        }

        private void btnDeleteDevelop_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק מעקב זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
               develop = tblDevelopment.GetLstDevelopments().FirstOrDefault(x => x.DevelopmentKode == Convert.ToInt32(dataGridViewD.CurrentRow.Cells[0].Value.ToString()));
            develop.Status = false;
            tblDevelopment.UpDateRow(develop);
            dataGridViewD.DataSource = tblDevelopment.GetLstDevelopments().Where(y => y.Status == true).Select(x => new { x.DevelopmentKode, x.DisDevelopmentOfDevelopment().DevelopmentDis, x.DevelopmentName, x.DevelopmentMinAge, x.DevelopmentMaxAge }).OrderBy(y => y.DevelopmentDis).ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewD.DataSource=tblDevelopment.GetLstDevelopments().Where(x=>x.Status==true && x.DevelopmentName.StartsWith(textBox1.Text)).Select(x => new { x.DevelopmentKode, x.DisDevelopmentOfDevelopment().DevelopmentDis, x.DevelopmentName, x.DevelopmentMinAge, x.DevelopmentMaxAge }).OrderBy(y => y.DevelopmentDis).ToList();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);
        }
    }
}
