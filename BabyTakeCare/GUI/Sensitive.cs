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
    public partial class Sensitive : UserControl
    {
        SensitiveLevelDB tblSL;
        SensitiveDB tblS;
        public BabySensitive bS;
        string str;
       

        public Sensitive(string str,BabySensitive bS)
        {
            InitializeComponent();
            tblSL = new SensitiveLevelDB();
            tblS = new SensitiveDB();
            this.str = str;
            this.bS = bS;
            if (str == "עידכון")
            {
                button2.Visible = false;
                combS.SelectedItem = bS.SensitiveOfBabySensitive();
                combS.DataSource = tblS.GetLstSensitives().ToList();
                combSL.SelectedItem = bS.SensitiveLevelOfBabySensitive();
                combSL.DataSource = tblSL.GetLstSensitiveLevels().ToList();
                textBox1.Text = bS.SensitiveOfBabySensitive().Notes;

            }
            else
            {
                combSL.DataSource = tblSL.GetLstSensitiveLevels().ToList();
                combSL.SelectedIndex = -1;
                combS.DataSource = tblS.GetLstSensitives().ToList();
                combS.SelectedIndex = -1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sensitive_Load(object sender, EventArgs e)
        {

        }
        public bool CreateFields(BabySensitive bS)
        {
            bool flagOK = true;
            errorProvider1.Clear();
            try
            {
                if (combS.SelectedItem == null)
                    throw new Exception("יש להכניס ערך");
                bS.SensitiveKode = tblS.GetLstSensitives().FirstOrDefault(x => x.ToString() == combS.SelectedItem.ToString()).SensitiveKode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combS, ex.Message);
                flagOK = false;

            }
            try
            {
                if (combSL.SelectedItem == null)
                    throw new Exception("יש להכניס ערך");
                bS.LevelKode = tblSL.GetLstSensitiveLevels().FirstOrDefault(x => x.ToString() == combSL.SelectedItem.ToString()).LevelKode;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(combSL, ex.Message);
                flagOK = false;
            }
            return flagOK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BabySensitive bS = new BabySensitive();
            if (CreateFields(bS))
            {
                GUI.Sensitive uSensitive = new GUI.Sensitive("הוספה",bS);
                this.Parent.Controls.Add(uSensitive);
                uSensitive.Dock = DockStyle.Bottom;
            }
        }
    }
}
