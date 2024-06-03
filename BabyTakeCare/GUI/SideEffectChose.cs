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

namespace BabyTakeCare.BLL
{
    public partial class SideEffectChose : UserControl
    {
        public SideEffect s;
        public ImmunisationSideEffect immS;
        FreqentyDB tblFreqenty;
        ImmunisationSideEffect immSE;
        
        public SideEffectChose(SideEffect item)
        {
            InitializeComponent();
            checkBox1.Text = item.SideEffectDis;
            tblFreqenty = new FreqentyDB();
            comboBox1.DataSource = tblFreqenty.GetLstFreqenty().Select(x => x.FreqentyDis).ToList();
            comboBox1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                comboBox1.Enabled = true;
            else
                comboBox1.Enabled = false;
        }
        public void Fill(ImmunisationSideEffect immSE)
        {
            this.immS = immSE;
            comboBox1.Enabled = true;
            comboBox1.SelectedItem = immSE.FreqentyOfImmunistationSideEffect();
            comboBox1.Text = immSE.FreqentyOfImmunistationSideEffect().ToString();
            checkBox1.Checked = true;
            checkBox1.Enabled = false;
        }
    }
}
