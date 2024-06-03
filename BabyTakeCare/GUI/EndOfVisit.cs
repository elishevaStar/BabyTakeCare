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
    public partial class EndOfVisit : UserControl
    {
        Appointment a;
        AppointmentDB tblApp;
        Control c, c3;
        public EndOfVisit(Appointment a, Control c,Control c3)
        {
            InitializeComponent();
            this.a = a;
            this.c = c;
            this.c3 = c3;
            tblApp = new AppointmentDB();
        }

        public bool CreateFields()
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (txtMotherI.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtMotherI.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                a.MotherInformation = txtMotherI.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMotherI, ex.Message);
                flagOK = false;
            }
            try
            {
                if (txtNurseI.Text == "")
                    throw new Exception("יש להכניס ערך");
                if (txtNurseI.Text.Length == 1)
                    throw new Exception("חובה להקיש יותר מאות אחת");
                a.AttendantInformation = txtNurseI.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNurseI, ex.Message);
                flagOK = false;
            }
            a.Notes = txtNotesI.Text;

            return flagOK;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (CreateFields())
            {
                DialogResult r2 = MessageBox.Show("האם ברצונך לסיים ביקור זה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (r2 == DialogResult.Yes)
                {
                    a.Status = true;
                    tblApp.UpDateRow(a);
                    btnEnd.Enabled = false;
                    c.Visible = true;
                    c3.Visible = false;
                    this.Parent.Controls.Remove(this);
                }
            }
        }
    }
}
