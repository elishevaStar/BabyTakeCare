
namespace BabyTakeCare.GUI
{
    partial class NewImm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewImm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPortion = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnGoOn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnElse = new System.Windows.Forms.Button();
            this.combHow = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGoOnTwo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(323, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 692);
            this.panel2.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(455, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 63;
            this.label1.Text = "שם חיסון";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(455, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 64;
            this.label2.Text = "מס\' מנות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(455, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 65;
            this.label3.Text = "אופן הנתינה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(455, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "זמן השפעה";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 121);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(141, 22);
            this.txtName.TabIndex = 68;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPortion
            // 
            this.txtPortion.Location = new System.Drawing.Point(285, 170);
            this.txtPortion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPortion.MaxLength = 1;
            this.txtPortion.Name = "txtPortion";
            this.txtPortion.Size = new System.Drawing.Size(141, 22);
            this.txtPortion.TabIndex = 69;
            this.txtPortion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortion_KeyPress);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(285, 274);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTime.Name = "txtTime";
            this.txtTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTime.Size = new System.Drawing.Size(141, 22);
            this.txtTime.TabIndex = 72;
            // 
            // btnGoOn
            // 
            this.btnGoOn.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnGoOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoOn.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnGoOn.ForeColor = System.Drawing.Color.Maroon;
            this.btnGoOn.Location = new System.Drawing.Point(43, 402);
            this.btnGoOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoOn.Name = "btnGoOn";
            this.btnGoOn.Size = new System.Drawing.Size(160, 62);
            this.btnGoOn.TabIndex = 73;
            this.btnGoOn.Text = " ";
            this.btnGoOn.UseVisualStyleBackColor = true;
            this.btnGoOn.Click += new System.EventHandler(this.btnGoOn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnElse);
            this.panel1.Controls.Add(this.combHow);
            this.panel1.Controls.Add(this.btnGoOn);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.txtPortion);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(171, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 487);
            this.panel1.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(112, 257);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 100);
            this.panel3.TabIndex = 78;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(28, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 39);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 70;
            // 
            // btnElse
            // 
            this.btnElse.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnElse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElse.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnElse.ForeColor = System.Drawing.Color.Maroon;
            this.btnElse.Location = new System.Drawing.Point(213, 222);
            this.btnElse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElse.Name = "btnElse";
            this.btnElse.Size = new System.Drawing.Size(65, 30);
            this.btnElse.TabIndex = 77;
            this.btnElse.Text = "אחר";
            this.btnElse.UseVisualStyleBackColor = true;
            this.btnElse.Click += new System.EventHandler(this.btnElse_Click);
            // 
            // combHow
            // 
            this.combHow.FormattingEnabled = true;
            this.combHow.Items.AddRange(new object[] {
            "הזרקה לשריר הירך",
            "בתמיסה דרך הפה",
            "דרך הפה ב-2 טיפות",
            "הזרקה תת עורית"});
            this.combHow.Location = new System.Drawing.Point(285, 226);
            this.combHow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combHow.Name = "combHow";
            this.combHow.Size = new System.Drawing.Size(141, 24);
            this.combHow.TabIndex = 74;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnGoOnTwo
            // 
            this.btnGoOnTwo.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnGoOnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoOnTwo.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnGoOnTwo.ForeColor = System.Drawing.Color.Maroon;
            this.btnGoOnTwo.Location = new System.Drawing.Point(21, 618);
            this.btnGoOnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoOnTwo.Name = "btnGoOnTwo";
            this.btnGoOnTwo.Size = new System.Drawing.Size(139, 62);
            this.btnGoOnTwo.TabIndex = 76;
            this.btnGoOnTwo.Text = "המשך";
            this.btnGoOnTwo.UseVisualStyleBackColor = true;
            this.btnGoOnTwo.Click += new System.EventHandler(this.btnGoOnTwo_Click);
            // 
            // NewImm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btnGoOnTwo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewImm";
            this.Size = new System.Drawing.Size(1177, 695);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPortion;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnGoOn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnGoOnTwo;
        private System.Windows.Forms.ComboBox combHow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnElse;
    }
}
