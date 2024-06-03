
namespace BabyTakeCare.GUI
{
    partial class NewBabyM
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.combKind = new System.Windows.Forms.ComboBox();
            this.combNa = new System.Windows.Forms.ComboBox();
            this.dateTimeB = new System.Windows.Forms.DateTimePicker();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPNM = new System.Windows.Forms.TextBox();
            this.txtPNF = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.txtIdB = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.combBranch = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // combKind
            // 
            this.combKind.FormattingEnabled = true;
            this.combKind.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.combKind.Location = new System.Drawing.Point(525, 441);
            this.combKind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combKind.Name = "combKind";
            this.combKind.Size = new System.Drawing.Size(156, 24);
            this.combKind.TabIndex = 89;
            // 
            // combNa
            // 
            this.combNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.combNa.FormattingEnabled = true;
            this.combNa.Location = new System.Drawing.Point(525, 484);
            this.combNa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combNa.Name = "combNa";
            this.combNa.Size = new System.Drawing.Size(156, 24);
            this.combNa.TabIndex = 88;
            // 
            // dateTimeB
            // 
            this.dateTimeB.CustomFormat = " ";
            this.dateTimeB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeB.Location = new System.Drawing.Point(525, 204);
            this.dateTimeB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeB.Name = "dateTimeB";
            this.dateTimeB.Size = new System.Drawing.Size(156, 22);
            this.dateTimeB.TabIndex = 87;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(525, 604);
            this.txtKode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKode.MaxLength = 6;
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(156, 22);
            this.txtKode.TabIndex = 86;
            this.txtKode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKode_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(715, 601);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 26);
            this.label14.TabIndex = 85;
            this.label14.Text = "קוד אישי";
            // 
            // txtPNM
            // 
            this.txtPNM.Location = new System.Drawing.Point(525, 567);
            this.txtPNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPNM.Name = "txtPNM";
            this.txtPNM.Size = new System.Drawing.Size(156, 22);
            this.txtPNM.TabIndex = 84;
            this.txtPNM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPNM_KeyPress);
            // 
            // txtPNF
            // 
            this.txtPNF.Location = new System.Drawing.Point(525, 526);
            this.txtPNF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPNF.Name = "txtPNF";
            this.txtPNF.Size = new System.Drawing.Size(156, 22);
            this.txtPNF.TabIndex = 83;
            this.txtPNF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPNF_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(525, 399);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 22);
            this.txtPhone.TabIndex = 82;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(525, 322);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(156, 22);
            this.txtAdd.TabIndex = 81;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(525, 284);
            this.txtW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(156, 22);
            this.txtW.TabIndex = 80;
            this.txtW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtW_KeyPress);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(525, 244);
            this.txtH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(156, 22);
            this.txtH.TabIndex = 79;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // txtIdM
            // 
            this.txtIdM.Location = new System.Drawing.Point(525, 166);
            this.txtIdM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdM.MaxLength = 9;
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(156, 22);
            this.txtIdM.TabIndex = 78;
            this.txtIdM.TextChanged += new System.EventHandler(this.txtIdM_TextChanged);
            this.txtIdM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdM_KeyPress);
            // 
            // txtIdB
            // 
            this.txtIdB.Location = new System.Drawing.Point(525, 126);
            this.txtIdB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdB.MaxLength = 9;
            this.txtIdB.Name = "txtIdB";
            this.txtIdB.Size = new System.Drawing.Size(156, 22);
            this.txtIdB.TabIndex = 77;
            this.txtIdB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdB_KeyPress);
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(525, 89);
            this.txtFN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(156, 22);
            this.txtFN.TabIndex = 76;
            this.txtFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFN_KeyPress);
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(525, 55);
            this.txtPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(156, 22);
            this.txtPN.TabIndex = 75;
            this.txtPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPN_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(717, 567);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 26);
            this.label13.TabIndex = 74;
            this.label13.Text = "שם האם";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(717, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 73;
            this.label12.Text = "שם האב";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(715, 486);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 26);
            this.label11.TabIndex = 72;
            this.label11.Text = "לאום התינוק";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(715, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 71;
            this.label10.Text = "מין התינוק";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(715, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 26);
            this.label9.TabIndex = 70;
            this.label9.Text = "פלאפון";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(715, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 26);
            this.label8.TabIndex = 69;
            this.label8.Text = "כתובת";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(715, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 26);
            this.label7.TabIndex = 68;
            this.label7.Text = "משקל לידה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(715, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 67;
            this.label6.Text = "גובה לידה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(715, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 66;
            this.label5.Text = "תאריך לידה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(715, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 65;
            this.label4.Text = "ת.ז. אם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(715, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 64;
            this.label3.Text = "ת.ז. תינוק";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(715, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "שם משפחה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(717, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 62;
            this.label1.Text = "שם פרטי";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(121, 593);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 62);
            this.button1.TabIndex = 90;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(715, 638);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 26);
            this.label15.TabIndex = 91;
            this.label15.Text = "סניף";
            // 
            // combBranch
            // 
            this.combBranch.FormattingEnabled = true;
            this.combBranch.Location = new System.Drawing.Point(525, 640);
            this.combBranch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combBranch.Name = "combBranch";
            this.combBranch.Size = new System.Drawing.Size(156, 24);
            this.combBranch.TabIndex = 92;
            this.combBranch.SelectedIndexChanged += new System.EventHandler(this.combBranch_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(715, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 26);
            this.label16.TabIndex = 93;
            this.label16.Text = "עיר";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(179, 319);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 62);
            this.button2.TabIndex = 95;
            this.button2.Text = "הוספת רגישות";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(83, 386);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 192);
            this.panel1.TabIndex = 96;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(525, 361);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(156, 22);
            this.txtCity.TabIndex = 101;
            // 
            // NewBabyM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.combBranch);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combKind);
            this.Controls.Add(this.combNa);
            this.Controls.Add(this.dateTimeB);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPNM);
            this.Controls.Add(this.txtPNF);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtIdM);
            this.Controls.Add(this.txtIdB);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewBabyM";
            this.Size = new System.Drawing.Size(1177, 695);
            this.Load += new System.EventHandler(this.NewBabyM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combKind;
        private System.Windows.Forms.ComboBox combNa;
        private System.Windows.Forms.DateTimePicker dateTimeB;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPNM;
        private System.Windows.Forms.TextBox txtPNF;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.TextBox txtIdB;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox combBranch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCity;
    }
}
