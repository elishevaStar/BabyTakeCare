
namespace BabyTakeCare.GUI
{
    partial class BabyHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyHome));
            this.lHello = new System.Windows.Forms.Label();
            this.cmbChildren = new System.Windows.Forms.ComboBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnBeg = new System.Windows.Forms.Button();
            this.btnImm = new System.Windows.Forms.Button();
            this.btnDevelop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHello
            // 
            this.lHello.AutoSize = true;
            this.lHello.BackColor = System.Drawing.Color.Transparent;
            this.lHello.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.lHello.Location = new System.Drawing.Point(717, 0);
            this.lHello.Name = "lHello";
            this.lHello.Size = new System.Drawing.Size(61, 26);
            this.lHello.TabIndex = 0;
            this.lHello.Text = "label1";
            // 
            // cmbChildren
            // 
            this.cmbChildren.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbChildren.FormattingEnabled = true;
            this.cmbChildren.Location = new System.Drawing.Point(723, 46);
            this.cmbChildren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChildren.Name = "cmbChildren";
            this.cmbChildren.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbChildren.Size = new System.Drawing.Size(121, 32);
            this.cmbChildren.TabIndex = 1;
            this.cmbChildren.Visible = false;
            this.cmbChildren.SelectedIndexChanged += new System.EventHandler(this.cmbChildren_SelectedIndexChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAbout.Location = new System.Drawing.Point(813, 107);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(160, 62);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "אודותינו";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnBeg
            // 
            this.btnBeg.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnBeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeg.Enabled = false;
            this.btnBeg.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnBeg.Location = new System.Drawing.Point(577, 107);
            this.btnBeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeg.Name = "btnBeg";
            this.btnBeg.Size = new System.Drawing.Size(160, 62);
            this.btnBeg.TabIndex = 4;
            this.btnBeg.Text = "תיק רפואי";
            this.btnBeg.UseVisualStyleBackColor = true;
            this.btnBeg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImm
            // 
            this.btnImm.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnImm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImm.Enabled = false;
            this.btnImm.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnImm.Location = new System.Drawing.Point(341, 107);
            this.btnImm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImm.Name = "btnImm";
            this.btnImm.Size = new System.Drawing.Size(160, 62);
            this.btnImm.TabIndex = 5;
            this.btnImm.Text = "פנקס חיסונים";
            this.btnImm.UseVisualStyleBackColor = true;
            this.btnImm.Click += new System.EventHandler(this.btnImm_Click);
            // 
            // btnDevelop
            // 
            this.btnDevelop.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDevelop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDevelop.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnDevelop.Location = new System.Drawing.Point(109, 107);
            this.btnDevelop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevelop.Name = "btnDevelop";
            this.btnDevelop.Size = new System.Drawing.Size(160, 62);
            this.btnDevelop.TabIndex = 6;
            this.btnDevelop.Text = "התפתחות";
            this.btnDevelop.UseVisualStyleBackColor = true;
            this.btnDevelop.Click += new System.EventHandler(this.btnDevelop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::BabyTakeCare.Properties.Resources.תמונה_סופית;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(603, 369);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 228);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::BabyTakeCare.Properties.Resources.כוכב_לדף;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(4, 473);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 124);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(435, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "*3636";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Guttman Yad-Brush", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(209, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "!לשרותכם תמיד";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnDevelop);
            this.panel3.Controls.Add(this.btnImm);
            this.panel3.Controls.Add(this.btnBeg);
            this.panel3.Controls.Add(this.btnAbout);
            this.panel3.Controls.Add(this.cmbChildren);
            this.panel3.Controls.Add(this.lHello);
            this.panel3.Location = new System.Drawing.Point(123, 37);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 615);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(4, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1179, 699);
            this.panel4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(850, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "לפרטי ילדים";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BabyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1181, 703);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BabyHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BabyHome";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lHello;
        private System.Windows.Forms.ComboBox cmbChildren;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnBeg;
        private System.Windows.Forms.Button btnImm;
        private System.Windows.Forms.Button btnDevelop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}