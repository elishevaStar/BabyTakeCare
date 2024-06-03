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
    public partial class AboutUs : UserControl
    {
        Baby baby;
        Control cParent;
        BranchDB tblBranch;
        public AboutUs(Baby baby, Control cparent)
        {
            InitializeComponent();
            tblBranch = new BranchDB();
            dataGridViewB.DataSource = tblBranch.GetLstBranches().Where(y => y.Status == true ).Select(x => new {x.CityOfBranch().CityName, x.AddressBr, x.TelNum }).OrderBy(x => x.AddressBr).ToList();
            dataGridViewB.Columns[0].HeaderText = "עיר הסניף";
            dataGridViewB.Columns[1].HeaderText = "כתובת הסניף";
            dataGridViewB.Columns[2].HeaderText = "טלפון הסניף";
            this.baby = baby;
            textBox1.Text="BabyTakeCare   נועד להנגיש עבורכם ההורים את המידע אודות ילדיכם: פרטי הביקורים השונים,אפשרות לפניה אישית לרופא המטפל ללא צורך בהמתנה טלפונית, פרטי החיסונים השונים ומידע אודות כל שלבי ההתפתחות של הילד.תוך שימת דגש לעיצוב חיצוני נאה ומרגיע למרות כל הבדיקות שנערכו יתכנו שיבושים ותקלות אנוש אנחנו תמיד כאן בשבילכם! " ;
            cParent = cparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cParent.Visible = true;
            this.Parent.Controls.Remove(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (dataGridViewB.Visible == false)
                dataGridViewB.Visible = true;
            else
                dataGridViewB.Visible = false;


        }
    }
}
