
namespace BabyTakeCare.GUI
{
    partial class DevelopmentDeatils
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewD = new System.Windows.Forms.DataGridView();
            this.btnAddDevelop = new System.Windows.Forms.Button();
            this.btnUpDateD = new System.Windows.Forms.Button();
            this.btnDeleteDevelop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewD
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewD.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewD.GridColor = System.Drawing.Color.White;
            this.dataGridViewD.Location = new System.Drawing.Point(107, 157);
            this.dataGridViewD.Name = "dataGridViewD";
            this.dataGridViewD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewD.RowHeadersWidth = 51;
            this.dataGridViewD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewD.Size = new System.Drawing.Size(531, 311);
            this.dataGridViewD.TabIndex = 0;
            // 
            // btnAddDevelop
            // 
            this.btnAddDevelop.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAddDevelop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDevelop.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAddDevelop.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddDevelop.Location = new System.Drawing.Point(478, 490);
            this.btnAddDevelop.Name = "btnAddDevelop";
            this.btnAddDevelop.Size = new System.Drawing.Size(140, 71);
            this.btnAddDevelop.TabIndex = 1;
            this.btnAddDevelop.Text = "הוספה";
            this.btnAddDevelop.UseVisualStyleBackColor = true;
            this.btnAddDevelop.Click += new System.EventHandler(this.btnAddDevelop_Click);
            // 
            // btnUpDateD
            // 
            this.btnUpDateD.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnUpDateD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpDateD.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUpDateD.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpDateD.Location = new System.Drawing.Point(306, 490);
            this.btnUpDateD.Name = "btnUpDateD";
            this.btnUpDateD.Size = new System.Drawing.Size(140, 71);
            this.btnUpDateD.TabIndex = 2;
            this.btnUpDateD.Text = "עידכון";
            this.btnUpDateD.UseVisualStyleBackColor = true;
            this.btnUpDateD.Click += new System.EventHandler(this.btnUpDateD_Click);
            // 
            // btnDeleteDevelop
            // 
            this.btnDeleteDevelop.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDeleteDevelop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteDevelop.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnDeleteDevelop.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteDevelop.Location = new System.Drawing.Point(140, 490);
            this.btnDeleteDevelop.Name = "btnDeleteDevelop";
            this.btnDeleteDevelop.Size = new System.Drawing.Size(140, 71);
            this.btnDeleteDevelop.TabIndex = 3;
            this.btnDeleteDevelop.Text = "מחיקה";
            this.btnDeleteDevelop.UseVisualStyleBackColor = true;
            this.btnDeleteDevelop.Click += new System.EventHandler(this.btnDeleteDevelop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label1.Location = new System.Drawing.Point(479, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "תאור התפתחות";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // DevelopmentDeatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteDevelop);
            this.Controls.Add(this.btnUpDateD);
            this.Controls.Add(this.btnAddDevelop);
            this.Controls.Add(this.dataGridViewD);
            this.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "DevelopmentDeatils";
            this.Size = new System.Drawing.Size(1177, 695);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewD;
        private System.Windows.Forms.Button btnAddDevelop;
        private System.Windows.Forms.Button btnUpDateD;
        private System.Windows.Forms.Button btnDeleteDevelop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
