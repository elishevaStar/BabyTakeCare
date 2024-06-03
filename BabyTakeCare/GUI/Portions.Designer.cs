
namespace BabyTakeCare.GUI
{
    partial class Portions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortionNum = new System.Windows.Forms.TextBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.combAgeKind = new System.Windows.Forms.ComboBox();
            this.combAge = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(236, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "מס\' מנה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(236, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 65;
            this.label2.Text = "גיל נתינת המנה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(236, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 66;
            this.label3.Text = "טווח עד למנה הבאה";
            // 
            // txtPortionNum
            // 
            this.txtPortionNum.Enabled = false;
            this.txtPortionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPortionNum.Location = new System.Drawing.Point(72, 32);
            this.txtPortionNum.Name = "txtPortionNum";
            this.txtPortionNum.Size = new System.Drawing.Size(141, 22);
            this.txtPortionNum.TabIndex = 69;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(72, 145);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(141, 22);
            this.txtRange.TabIndex = 71;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // combAgeKind
            // 
            this.combAgeKind.FormattingEnabled = true;
            this.combAgeKind.Items.AddRange(new object[] {
            "יום",
            "שבוע",
            "חודש"});
            this.combAgeKind.Location = new System.Drawing.Point(136, 87);
            this.combAgeKind.Name = "combAgeKind";
            this.combAgeKind.Size = new System.Drawing.Size(77, 24);
            this.combAgeKind.TabIndex = 72;
            this.combAgeKind.SelectedIndexChanged += new System.EventHandler(this.combAgeKind_SelectedIndexChanged);
            // 
            // combAge
            // 
            this.combAge.Enabled = false;
            this.combAge.FormattingEnabled = true;
            this.combAge.Location = new System.Drawing.Point(72, 87);
            this.combAge.Name = "combAge";
            this.combAge.Size = new System.Drawing.Size(43, 24);
            this.combAge.TabIndex = 73;
            // 
            // Portions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.מעקב;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.combAge);
            this.Controls.Add(this.combAgeKind);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.txtPortionNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Portions";
            this.Size = new System.Drawing.Size(471, 188);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPortionNum;
        public System.Windows.Forms.TextBox txtRange;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ComboBox combAge;
        public System.Windows.Forms.ComboBox combAgeKind;
    }
}
