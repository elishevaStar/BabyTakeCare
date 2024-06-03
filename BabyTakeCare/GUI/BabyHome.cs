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
using System.IO;

namespace BabyTakeCare.GUI
{
    public partial class BabyHome : Form
    {
        string path = "";
        BabyDB tblBaby;
        Baby baby;
        public BabyHome(Baby b)
        {
            InitializeComponent();
            tblBaby = new BabyDB();
            lHello.Text = " שלום" +" "+ b.PrivateNameMother + " " + b.FamiliyName;
            cmbChildren.DataSource = tblBaby.GetLstBabies().Where(x => x.IdNumP == b.IdNumP).Select(y => y.PrivateName).ToList();
            cmbChildren.SelectedIndex = -1;


        }

       
       
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            BabyBeg uBabyB = new BabyBeg(baby, panel3);
            panel4.Controls.Add(uBabyB);
            uBabyB.Dock = DockStyle.Fill;
        }

        private void btnDevelop_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            DevelopmentSteps uDS = new DevelopmentSteps(baby,panel3);
            panel4.Controls.Add(uDS);
            uDS.Dock = DockStyle.Fill;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            AboutUs uAbout = new AboutUs(baby, panel3);
            panel4.Controls.Add(uAbout);
            uAbout.Dock = DockStyle.Fill;
        }

        private void cmbChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChildren.Visible == true)
            {
                path = "";
                baby = tblBaby.GetLstBabies().FirstOrDefault(x => x.PrivateName == cmbChildren.Text);
                btnBeg.Enabled = true;
                btnImm.Enabled = true;
                string a = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
                string b = Directory.GetParent(a).ToString();
                path += b + @"\Resources\";
                if (baby.Kind == "זכר")
                {
                    this.BackgroundImage = Image.FromFile(path + "רקעים.jpg");
                    btnAbout.Enabled = true;
                    btnBeg.Enabled = true;
                    btnDevelop.Enabled = true;
                    btnImm.Enabled = true;
                }
                else
                    this.BackgroundImage = Image.FromFile(path + "רקעים2.jpg");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cmbChildren.Visible = true;
        }

        private void btnImm_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            ImmunistationNote uNote = new ImmunistationNote(baby, null, panel3);
            panel4.Controls.Add(uNote);
            uNote.Dock = DockStyle.Fill;
        }
    }
}
