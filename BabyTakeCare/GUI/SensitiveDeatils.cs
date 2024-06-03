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
    public partial class SensitiveDeatils : UserControl
    {
        BabySensitiveDB tblBS;
        Baby b;
        BabySensitive bS;
        bool flag = false;
        bool flag2 = true;
        GUI.Sensitive uSensitive;
        public SensitiveDeatils(Baby b)
        {
            InitializeComponent();
            this.b = b;
            button1.Visible = false;
            tblBS = new BabySensitiveDB();
            dataGridViewS.DataSource = tblBS.GetLstBabySensitives().Where(x => x.Status == true && x.IdNumB == b.IdNumB).Select(y => new { y.SensitiveOfBabySensitive().SensitiveDis, y.SensitiveLevelOfBabySensitive().LevelDis, y.SensitiveOfBabySensitive().Notes }).ToList();
            dataGridViewS.Columns[0].HeaderText = "...רגישות ל";
            dataGridViewS.Columns[1].HeaderText = "רמת הרגישות";
            dataGridViewS.Columns[2].HeaderText = "הערות";
        }

        private void btnAddSE_Click(object sender, EventArgs e)
        {
           
            uSensitive = new GUI.Sensitive("הוספה",bS);
            panel1.Visible = false;
            panel2.Controls.Add(uSensitive);
            uSensitive.Dock = DockStyle.Top;
            button1.Text = "הוסף";
            button1.Visible = true;
            
        }

        private void btnUpDateSE_Click(object sender, EventArgs e)
        {
            bS=tblBS.GetLstBabySensitives().FirstOrDefault(x=>x.SensitiveOfBabySensitive().SensitiveDis == dataGridViewS.CurrentRow.Cells[0].Value.ToString());
            uSensitive = new GUI.Sensitive("עידכון",bS);
            panel1.Visible = false;
            panel2.Controls.Add(uSensitive);
            uSensitive.Dock = DockStyle.Top;
            button1.Text = "עדכן";
            button1.Visible = true;
        }

        private void btnDeleteSE_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק רגישות זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
                bS = tblBS.GetLstBabySensitives().FirstOrDefault(x => x.SensitiveOfBabySensitive().SensitiveDis == dataGridViewS.CurrentRow.Cells[0].Value.ToString()&& x.IdNumB==b.IdNumB);
            bS.Status = false;
            tblBS.UpDateRow(bS);
            dataGridViewS.DataSource = tblBS.GetLstBabySensitives().Where(x => x.Status == true && x.IdNumB == b.IdNumB).Select(y => new { y.SensitiveOfBabySensitive().SensitiveDis, y.SensitiveLevelOfBabySensitive().LevelDis, y.SensitiveOfBabySensitive().Notes }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "הוסף")
            {
                    DialogResult r2 = MessageBox.Show("האם ברצונך להוסיף רגישויות אלו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r2 == DialogResult.Yes)
                    {
                        flag2 = true;
                        foreach (Control item in panel2.Controls)
                        {
                            if (item is GUI.Sensitive)
                            {
                                flag = true;
                                if ((item as GUI.Sensitive).bS == null)
                                {
                                    (item as GUI.Sensitive).bS = new BabySensitive();
                                    if ((item as GUI.Sensitive).CreateFields((item as GUI.Sensitive).bS))
                                    {
                                        (item as GUI.Sensitive).bS.IdNumB = b.IdNumB;
                                        if (tblBS.Find((item as GUI.Sensitive).bS.IdNumB, (item as GUI.Sensitive).bS.SensitiveKode) != null && (item as GUI.Sensitive).bS.Status == true)
                                            MessageBox.Show("ישנה רגישות כפולה, היא תתוסף על פי הערכים הראשונים!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                                        if (tblBS.Find((item as GUI.Sensitive).bS.IdNumB, (item as GUI.Sensitive).bS.SensitiveKode) != null && (item as GUI.Sensitive).bS.Status == false)
                                        {
                                            DialogResult r4 = MessageBox.Show("כבר קימת רגישות זו אך היא אינה פעילה האם ברצונך להפעילה?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                                            if (r4 == DialogResult.Yes)
                                            {
                                                bS = tblBS.Find((item as GUI.Sensitive).bS.IdNumB, (item as GUI.Sensitive).bS.SensitiveKode);
                                                bS.Status = true;
                                                tblBS.UpDateRow(bS);

                                            }
                                        }
                                        else
                                        {
                                            (item as GUI.Sensitive).bS.Status = true;
                                            tblBS.AddNew((item as GUI.Sensitive).bS);
                                        }

                                    }
                                    else
                                        flag2 = false;




                                }
                                else
                                {
                                    (item as GUI.Sensitive).bS.IdNumB = b.IdNumB;
                                    if (tblBS.Find((item as GUI.Sensitive).bS.IdNumB, (item as GUI.Sensitive).bS.SensitiveKode) != null)
                                        MessageBox.Show("ישנה רגישות כפולה, היא תתוסף על פי הערכים הראשונים!", "שים לב", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                                    else
                                    {
                                        (item as GUI.Sensitive).bS.Status = true;
                                        tblBS.AddNew((item as GUI.Sensitive).bS);
                                    }
                                }
                            }
                        }
                        if (flag2)
                        {
                            DialogResult r3 = MessageBox.Show("האם ברצונך לסיים את הוספת רגישויות אלו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                            if (r3 == DialogResult.Yes)
                            {
                                button1.Visible = false;
                                dataGridViewS.DataSource = tblBS.GetLstBabySensitives().Where(x => x.Status == true && x.IdNumB == b.IdNumB).Select(y => new { y.SensitiveOfBabySensitive().SensitiveDis, y.SensitiveLevelOfBabySensitive().LevelDis, y.SensitiveOfBabySensitive().Notes }).ToList();
                                panel1.Visible = true;

                            }


                        }
                    }
                
            }
            else
            {
                if (uSensitive.CreateFields(uSensitive.bS))
                {
                    DialogResult r1 = MessageBox.Show("האם ברצונך לעדכן רגישות זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    if (r1 == DialogResult.Yes)
                    {
                        tblBS.UpDateRow(bS);
                        bS.Status = true;
                        button1.Visible = false;
                        dataGridViewS.DataSource = tblBS.GetLstBabySensitives().Where(x => x.Status == true && x.IdNumB == b.IdNumB).Select(y => new { y.SensitiveOfBabySensitive().SensitiveDis, y.SensitiveLevelOfBabySensitive().LevelDis, y.SensitiveOfBabySensitive().Notes }).ToList();
                        panel1.Visible = true;
                    }
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

        
   
}
