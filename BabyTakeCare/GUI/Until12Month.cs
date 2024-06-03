using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyTakeCare.GUI
{
    public partial class Until12Month : UserControl
    {
        int num=0;
        public Until12Month()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Location = button1.Location;
            panel2.Visible = true;
            num = 1;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Location = button2.Location;
            panel2.Visible = true;
            num = 2;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Location = button3.Location;
            panel2.Visible = true;
            num = 3;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Location = button4.Location;
            panel2.Visible = true;
            num = 4;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Location = button5.Location;
            panel2.Visible = true;
            num = 5;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Location = button6.Location;
            panel2.Visible = true;
            num = 6;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Location = button7.Location;
            panel2.Visible = true;
            num = 7;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Location = button8.Location;
            panel2.Visible = true;
            num = 8;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Location = button9.Location;
            panel2.Visible = true;
            num = 9;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel2.Location = button10.Location;
            panel2.Visible = true;
            num = 10;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Location = button11.Location;
            panel2.Visible = true;
            num = 11;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel2.Location = button12.Location;
            panel2.Visible = true;
            num = 12;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }
    }
}
