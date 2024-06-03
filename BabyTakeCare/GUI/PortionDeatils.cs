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
    public partial class PortionDeatils : UserControl
    {
        ImmunisationTimeDB tblImmTime;
        Immunisation imm;
        ImmunisationTime immT;
        ImmunisationDB tblImm;
        Portions uPortion;
        public PortionDeatils(Immunisation imm)
        {
            InitializeComponent();
            tblImmTime = new ImmunisationTimeDB();
            tblImm = new ImmunisationDB();
            panel2.Visible = false;
            this.imm = imm;
            dataGridViewP.DataSource = tblImmTime.GetLstImmunisationTimes().Where(y => y.Status == true && y.ImmunisationKode == imm.ImmunisationKode).Select(x => new { x.NumPortion,x.AgeKind, x.Age, x.Range }).OrderBy(x => x.NumPortion).ToList();
            dataGridViewP.Columns[0].HeaderText = "מספר מנה";
            dataGridViewP.Columns[1].HeaderText = "סוג גיל נתינת המנה";
            dataGridViewP.Columns[2].HeaderText = "גיל נתינת המנה";
            dataGridViewP.Columns[3].HeaderText = "טווח עד למנה הבאה";
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            button1.Text = "הוסף";
            int num = imm.NumPoration + 1;
            uPortion = new Portions(imm);
            dataGridViewP.Visible = false;
            panel2.Visible = true;
            uPortion.txtPortionNum.Text = num.ToString();
            panel2.Controls.Add(uPortion);
            uPortion.Dock = DockStyle.Top;
        }

        private void btnUpDateP_Click(object sender, EventArgs e)
        {
            button1.Text = "עדכן";
            uPortion = new Portions(imm);
            dataGridViewP.Visible = false;
            panel2.Visible = true;
            panel2.Controls.Add(uPortion);
            uPortion.Dock = DockStyle.Top;
            immT = tblImmTime.GetLstImmunisationTimes().FirstOrDefault(x => x.NumPortion == Convert.ToInt32(dataGridViewP.CurrentRow.Cells[0].Value.ToString()));
            uPortion.txtPortionNum.Text = immT.NumPortion.ToString();
            uPortion.combAgeKind.Text= immT.AgeKind;
            uPortion.combAge.Text=immT.Age.ToString();
            uPortion.combAge.Enabled = true;
            uPortion.txtRange.Text = immT.Range;
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק מנה זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
            {
                immT = tblImmTime.GetLstImmunisationTimes().FirstOrDefault(x => x.NumPortion == Convert.ToInt32(dataGridViewP.CurrentRow.Cells[0].Value.ToString()));
                immT.ImmunisationKode = imm.ImmunisationKode;
                immT.Status = false;
                tblImmTime.UpDateRow(immT);
                button1.Enabled = false;
                dataGridViewP.DataSource = tblImmTime.GetLstImmunisationTimes().Where(y => y.Status == true && y.ImmunisationKode == imm.ImmunisationKode).Select(x => new { x.NumPortion,x.AgeKind, x.Age, x.Range }).OrderBy(x => x.NumPortion).ToList();
                imm.NumPoration--;
                tblImm.UpDateRow(imm);
            }
        }

        private void PortionDeatils_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "הוסף")
            {
                immT = new ImmunisationTime();
                if (CreateFields(immT))
                {
                        DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף מנה זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        if (r2 == DialogResult.Yes)
                        {
                            immT.Status = true;
                            immT.ImmunisationKode = imm.ImmunisationKode;
                            immT.NumPortion = Convert.ToInt32(uPortion.txtPortionNum.Text);
                            tblImmTime.AddNew(immT);
                            button1.Enabled = false;
                            dataGridViewP.DataSource = tblImmTime.GetLstImmunisationTimes().Where(y => y.Status == true && y.ImmunisationKode == imm.ImmunisationKode).Select(x => new { x.NumPortion,x.AgeKind, x.Age, x.Range }).OrderBy(x => x.NumPortion).ToList();
                            dataGridViewP.Visible = true;
                            panel2.Visible = false;
                            imm.NumPoration++;
                            tblImm.UpDateRow(imm);


                        }
                }
            }
            else
            {
                if (CreateFields(immT))
                {
                    DialogResult r1 = MessageBox.Show("האם ברצונך לעדכן מנה זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r1 == DialogResult.Yes)
                    {
                        
                        tblImmTime.UpDateRow(immT);
                        immT.Status = true;
                        button1.Enabled = false;
                        dataGridViewP.DataSource = tblImmTime.GetLstImmunisationTimes().Where(y => y.Status == true && y.ImmunisationKode == imm.ImmunisationKode).Select(x => new { x.NumPortion,x.AgeKind, x.Age, x.Range }).OrderBy(x => x.NumPortion).ToList();
                        dataGridViewP.Visible = true;
                        panel2.Visible = false;
                    }
                }

            }
        }
        public bool CreateFields(ImmunisationTime immT)
        {
            bool flagOK = true;
            uPortion.errorProvider1.Clear();
            try
            {
                if (uPortion.combAge.Text == "")
                    throw new Exception("יש להכניס ערך");
                immT.Age =Convert.ToInt32( uPortion.combAge.Text);
            }
            catch (Exception ex)
            {
               uPortion.errorProvider1.SetError(uPortion.combAge, ex.Message);
                flagOK = false;

            }
            try
            {
                if (uPortion.combAgeKind.Text == "")
                    throw new Exception("יש להכניס ערך");
                immT.AgeKind = uPortion.combAgeKind.Text;
            }
            catch (Exception ex)
            {
                uPortion.errorProvider1.SetError(uPortion.combAgeKind, ex.Message);
                flagOK = false;

            }
            try
            {
                if (uPortion.txtRange.Text == "")
                    throw new Exception("יש להכניס ערך");
                immT.Range = uPortion.txtRange.Text;
            }
            catch (Exception ex)
            {
                uPortion.errorProvider1.SetError(uPortion.txtRange, ex.Message);
                flagOK = false;

            }
            immT.ImmunisationKode = imm.ImmunisationKode;
            immT.NumPortion = Convert.ToInt32(uPortion.txtPortionNum.Text);
            return flagOK;
        }


    }
}
