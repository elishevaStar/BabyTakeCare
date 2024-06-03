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
    public partial class ManagerHome : Form
    {
        Worker w;
        public ManagerHome(Worker w)
        {
            InitializeComponent();
            this.w = w;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBabies_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Controls.Clear();
            BabyDeatils uBaby = new BabyDeatils (w);
            panel1.Controls.Add(uBaby);
            uBaby.Dock = DockStyle.Fill;
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Controls.Clear();
            WorkerDeatils uWorker = new WorkerDeatils(w);
            panel1.Controls.Add(uWorker);
            uWorker.Dock = DockStyle.Fill;
        }

        private void btnBranches_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Controls.Clear();
            BranchDeatils uBranch = new BranchDeatils(w);
            panel1.Controls.Add(uBranch);
            uBranch.Dock = DockStyle.Fill;
        }

        private void btnDevelop_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Controls.Clear();
            DevelopmentDeatils uDevelopment = new DevelopmentDeatils();
            panel1.Controls.Add(uDevelopment);
            uDevelopment.Dock = DockStyle.Fill;
        }

        private void btnimm_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Controls.Clear();
            ImmunistationDeatils uImm = new ImmunistationDeatils();
            panel1.Controls.Add(uImm);
            uImm.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel2.Visible==false)
                panel2.Visible = true;
            else
                panel2.Visible = false;

        }
    }
}
