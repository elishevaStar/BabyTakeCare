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
    public partial class DevelopmentSteps : UserControl
    {
        Baby baby;
        Control cParent;
        public DevelopmentSteps(Baby baby,Control cparent)
        {
            InitializeComponent();
            this.baby = baby;
            cParent = cparent;

        }


        private void btnUntil12Month_Click(object sender, EventArgs e)
        {
            btnUntil12Month.BackColor = Color.Turquoise;
            btnUntil36Month.BackColor = Color.White;
            Until12Month uUntil12Month = new Until12Month();
            panel2.BackColor=Color.AliceBlue;
            panel1.Controls.Clear();
            panel1.Controls.Add(uUntil12Month);
            uUntil12Month.Dock = DockStyle.Fill;
        }

        private void btnUntil36Month_Click(object sender, EventArgs e)
        {
            btnUntil12Month.BackColor = Color.White;
            btnUntil36Month.BackColor = Color.Turquoise;
            Until36Month uUntil36Month = new Until36Month();
            panel2.BackColor = Color.AliceBlue;
            panel1.Controls.Clear();
            panel1.Controls.Add(uUntil36Month);
            uUntil36Month.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cParent.Visible = true;
            this.Parent.Controls.Remove(this);
            
        }
    }
}
