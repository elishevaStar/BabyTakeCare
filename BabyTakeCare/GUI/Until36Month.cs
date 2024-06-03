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
    public partial class Until36Month : UserControl
    {
        int num = 0;
        public Until36Month()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Location = button1.Location;
            panel4.Visible = true;
            num = 13;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Location = button2.Location;
            panel4.Visible = true;
            num = 16;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Location = button3.Location;
            panel4.Visible = true;
            num = 19;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Location = button4.Location;
            panel4.Visible = true;
            num = 22;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Location = button5.Location;
            panel4.Visible = true;
            num = 25;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Location = button6.Location;
            panel4.Visible = true;
            num = 28;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Location = button7.Location;
            panel4.Visible = true;
            num = 31;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Location = button8.Location;
            panel4.Visible = true;
            num = 34;
            Monthes uMonthes = new Monthes(num);
            panel1.Controls.Clear();
            panel1.Controls.Add(uMonthes);
            uMonthes.Dock = DockStyle.Fill;
        }
    }
}
