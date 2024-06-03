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
    public partial class Monthes : UserControl
    {
        int num = 0;
        DevelopmentStepsDB tblDS;
        BLL.DevelopmentSteps dS;
        string path = "";
        public Monthes(int num)
        {
            InitializeComponent();
            tblDS = new DevelopmentStepsDB();
            this.num = num;
            dS = tblDS.GetLstDevelopSteps().FirstOrDefault(x=>x.Age==num);
            string a = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            string b = Directory.GetParent(a).ToString();
            path += b + @"\Resources\";
            if (num == 1)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת1.JPG");
            if (num == 2)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק2.JPG");
            if (num == 3)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק3.JPG");
            if (num == 4)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק4.JPG");
            if (num == 5)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק5.JPG");
            if (num == 6)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק6.JPG");
            if (num == 7)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק7.JPG");
            if (num == 8)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק8.JPG");
            if (num == 9)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק9.JPG");
            if (num == 10)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת10.JPG");
            if (num == 11)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת11.JPG");
            if (num == 12)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק12.JPG");
            if (num == 13)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת13.JPG");
            if (num == 16)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת16.JPG");
            if (num == 19)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק19.JPG");
            if (num == 22)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק22.JPG");
            if (num == 25)
                panel1.BackgroundImage = Image.FromFile(path + "תינוק25א.JPG");
            if (num == 28)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת28.JPG");
            if (num == 31)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת31.JPG");
            if (num == 34)
                panel1.BackgroundImage = Image.FromFile(path + "תינוקת34.JPG");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dS.StepDevelop != "")
                textBox1.Text = dS.StepDevelop;
            else
                textBox1.Text = "!איו נתונים במערכת אודות התפתחות זו";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dS.StepFive != "")
                textBox1.Text = dS.StepFive;
            else
                textBox1.Text = "!אין נתונים במערכת אודות התפתחות זו";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dS.StepSleep != "")
                textBox1.Text = dS.StepSleep;
            else
                textBox1.Text = "!אין נתונים במערכת אודות תהליכים אלו";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dS.StepFood != "")
                textBox1.Text = dS.StepFood;
            else
                textBox1.Text = "!אין נתונים במערכת אודות התפתחות זו";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dS.StepCommunicate != "")
                textBox1.Text = dS.StepCommunicate;
            else
                textBox1.Text = "!אין נתונים במערכת אודות התפתחות זו";
        }

        
    }
}
