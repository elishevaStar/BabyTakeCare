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
    public partial class Portions : UserControl
    {
        public ImmunisationTime immTime;
        public int numP;
        Immunisation imm;
        public Portions(Immunisation imm)
        {
            InitializeComponent();
            this.imm = imm;
            
        }

        private void combAgeKind_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combAgeKind.Text == "יום")
            {
                combAge.Items.Clear();
                combAge.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });

            }
            if (combAgeKind.Text == "שבוע")
            {
                combAge.Items.Clear();
                combAge.Items.AddRange(new string[] { "1", "2", "3" });
            }
            if (combAgeKind.Text == "חודש")
            {
                combAge.Items.Clear();
                combAge.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" });
            } 
            combAge.SelectedIndex = -1;
            combAge.Enabled = true;
        }
    }
}
