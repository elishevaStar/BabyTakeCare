using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BabyTakeCare.GUI
{
    public partial class DevelopInVisitD : UserControl
    {
        string path = "";
        string str;
        public DevelopInVisitD(string str)
        {
            InitializeComponent();
            string a = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            string b = Directory.GetParent(a).ToString();
            path += b + @"\Resources\";
            this.str = str;
            if(str=="התפתחות")
                this.panel1.BackgroundImage = Image.FromFile(path + "תנועתיות ומוטוריקה1.JPGg");
            if(str=="עקומות משקל")
                this.panel1.BackgroundImage = Image.FromFile(path + "שינה.JPG");
           


        }
    }
}
