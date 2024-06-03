
namespace BabyTakeCare.GUI
{
    partial class EndOfVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndOfVisit));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNurseI = new System.Windows.Forms.TextBox();
            this.txtMotherI = new System.Windows.Forms.TextBox();
            this.txtNotesI = new System.Windows.Forms.TextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(881, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "סיכום ביקור";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(779, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "אינפורמציה של המטפל";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(803, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "אינפורמציה של האם";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(934, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "הערות";
            // 
            // txtNurseI
            // 
            this.txtNurseI.Location = new System.Drawing.Point(687, 163);
            this.txtNurseI.Multiline = true;
            this.txtNurseI.Name = "txtNurseI";
            this.txtNurseI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNurseI.Size = new System.Drawing.Size(318, 72);
            this.txtNurseI.TabIndex = 37;
            // 
            // txtMotherI
            // 
            this.txtMotherI.Location = new System.Drawing.Point(687, 332);
            this.txtMotherI.Multiline = true;
            this.txtMotherI.Name = "txtMotherI";
            this.txtMotherI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotherI.Size = new System.Drawing.Size(318, 72);
            this.txtMotherI.TabIndex = 38;
            // 
            // txtNotesI
            // 
            this.txtNotesI.Location = new System.Drawing.Point(687, 483);
            this.txtNotesI.Multiline = true;
            this.txtNotesI.Name = "txtNotesI";
            this.txtNotesI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotesI.Size = new System.Drawing.Size(318, 72);
            this.txtNotesI.TabIndex = 39;
            // 
            // btnEnd
            // 
            this.btnEnd.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnd.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnd.ForeColor = System.Drawing.Color.Maroon;
            this.btnEnd.Location = new System.Drawing.Point(40, 512);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(160, 69);
            this.btnEnd.TabIndex = 40;
            this.btnEnd.Text = "סיום";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BabyTakeCare.Properties.Resources.IMG_1858;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(40, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 251);
            this.panel1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(107, 322);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(261, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "שמחנו לעמוד לשרותכם!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // EndOfVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.מעקב;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtNotesI);
            this.Controls.Add(this.txtMotherI);
            this.Controls.Add(this.txtNurseI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "EndOfVisit";
            this.Size = new System.Drawing.Size(1043, 606);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNurseI;
        private System.Windows.Forms.TextBox txtMotherI;
        private System.Windows.Forms.TextBox txtNotesI;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
