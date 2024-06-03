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
    public partial class SideEffEctDeatils : UserControl
    {
        Immunisation imm;
        SideEffectDB tblSE;
        ImmunisationSideEffectDB tblImmSE;
        ImmunisationSideEffect immSE;
        SideEffect sE;
        SideEffectChose uSCH;
        FreqentyDB tblF;
        public SideEffEctDeatils(Immunisation imm)
        {
            InitializeComponent();
            tblImmSE = new ImmunisationSideEffectDB();
            tblSE = new SideEffectDB();
            tblF = new FreqentyDB();
            panel2.Visible = false;
            this.imm = imm;
            button1.Visible = false;
            dataGridViewS.DataSource = tblImmSE.GetLstImmunisationSideEffects().Where(y => y.Status == true && y.ImmunisationKode == imm.ImmunisationKode).Select(x => new { x.SideEffectKode, x.SideEffectOfImmunistationSideEffect().SideEffectDis, x.SideEffectOfImmunistationSideEffect().SideEffectKind, x.FreqentyOfImmunistationSideEffect().FreqentyDis }).OrderBy(x => x.SideEffectDis).ToList();
            dataGridViewS.Columns[0].HeaderText = "קוד תופעת הלוואי";
            dataGridViewS.Columns[1].HeaderText = "תאור תופעת הלוואי";
            dataGridViewS.Columns[2].HeaderText = "סוג תופעת הלוואי";
            dataGridViewS.Columns[3].HeaderText = "תדירות תופעת הלוואי";

        }

        private void btnAddSE_Click(object sender, EventArgs e)
        {
            CreateSideEffect();
            panel2.Visible = true;
        }
        private void CreateSideEffect()
        {
            button1.Text = "הוסף";
            button1.Visible = true;
            int i = 0;
            List<ImmunisationSideEffect> lst = tblImmSE.GetLstImmunisationSideEffects().Where(x => x.ImmunisationKode == imm.ImmunisationKode).ToList();
            bool flag = true;
            Control[] cArr = new Control[tblSE.Size()];

            foreach (SideEffect itemSE in tblSE.GetLstSideEffects())
            {
                foreach (ImmunisationSideEffect item in lst)
                {
                    if (item.SideEffectOfImmunistationSideEffect().SideEffectKode == itemSE.SideEffectKode)
                        flag = false;
                }
                if (flag)
                {
                    SideEffectChose uSEC = new SideEffectChose(itemSE);
                    uSEC.s = itemSE;
                    cArr[i] = uSEC;
                    i++;
                    //panel2.Controls.Add(uSEC);
                    uSEC.Dock = DockStyle.Top;

                }
                flag = true;

            }
            panel2.Controls.AddRange(cArr);

        }

        private void btnDeleteSE_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("האם ברצונך למחוק תופעת לוואי זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (r1 == DialogResult.Yes)
                immSE = tblImmSE.GetLstImmunisationSideEffects().FirstOrDefault(x => x.SideEffectKode == Convert.ToInt32(dataGridViewS.CurrentRow.Cells[0].Value.ToString()));
            immSE.Status = false;
            tblImmSE.UpDateRow(immSE);
            dataGridViewS.DataSource = tblImmSE.GetLstImmunisationSideEffects().Where(y => y.Status == true && y.ImmunisationKode == imm.ImmunisationKode).Select(x => new { x.SideEffectKode, x.SideEffectOfImmunistationSideEffect().SideEffectDis, x.SideEffectOfImmunistationSideEffect().SideEffectKind, x.FreqentyOfImmunistationSideEffect().FreqentyDis }).OrderBy(x => x.SideEffectDis).ToList();

        }

        private void btnUpDateSE_Click(object sender, EventArgs e)
        {
            sE = tblSE.GetLstSideEffects().FirstOrDefault(x => x.SideEffectKode == Convert.ToInt32(dataGridViewS.CurrentRow.Cells[0].Value.ToString()));
            immSE = tblImmSE.GetLstImmunisationSideEffects().FirstOrDefault(x => x.SideEffectKode == Convert.ToInt32(dataGridViewS.CurrentRow.Cells[0].Value.ToString()));
            uSCH = new SideEffectChose(sE);
            panel2.Visible = true;
            panel2.Controls.Add(uSCH);
            uSCH.Dock = DockStyle.Top;
            uSCH.Fill(immSE);
            button1.Text = "עדכן";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "עדכן")
            {
                DialogResult r1 = MessageBox.Show("האם ברצונך לעדכן תופעת לוואי זו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (r1 == DialogResult.Yes)
                {
                    immSE.SideEffectFrequency = tblF.GetLstFreqenty().FirstOrDefault(x => x.FreqentyDis == uSCH.comboBox1.SelectedItem.ToString()).FreqentyKode;
                    tblImmSE.UpDateRow(immSE);
                    immSE.Status = true;
                    dataGridViewS.DataSource = tblImmSE.GetLstImmunisationSideEffects().Where(y => y.Status == true && y.ImmunisationKode == imm.ImmunisationKode).Select(x => new { x.SideEffectKode, x.SideEffectOfImmunistationSideEffect().SideEffectDis, x.SideEffectOfImmunistationSideEffect().SideEffectKind, x.FreqentyOfImmunistationSideEffect().FreqentyDis }).OrderBy(x => x.SideEffectDis).ToList();
                    panel2.Visible = false;

                }
            }
            else
            {
                DialogResult r2 = MessageBox.Show("האם ברצונך לסיים את הוספת תופעות לוואי אלו?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                if (r2 == DialogResult.Yes)
                {
                    foreach (SideEffectChose item in panel2.Controls)
                    {

                        if (item.checkBox1.Checked)
                        {
                            item.immS = new ImmunisationSideEffect();
                            item.immS.ImmunisationKode = imm.ImmunisationKode;
                            item.immS.SideEffectKode = item.s.SideEffectKode;
                            item.immS.SideEffectFrequency = tblF.GetLstFreqenty().FirstOrDefault(x => x.FreqentyDis == item.comboBox1.SelectedItem.ToString()).FreqentyKode;
                            item.immS.Status = true;
                            tblImmSE.AddNew(item.immS);
                            panel2.Visible = false;


                        }
                    }
                }
            }
        }
    }    }
