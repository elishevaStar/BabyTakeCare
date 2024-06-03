
namespace BabyTakeCare.GUI
{
    partial class PortionDeatils
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
            this.btnUpDateP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.dataGridViewP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpDateP
            // 
            this.btnUpDateP.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnUpDateP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpDateP.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUpDateP.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpDateP.Location = new System.Drawing.Point(129, 288);
            this.btnUpDateP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpDateP.Name = "btnUpDateP";
            this.btnUpDateP.Size = new System.Drawing.Size(105, 54);
            this.btnUpDateP.TabIndex = 5;
            this.btnUpDateP.Text = "עידכון";
            this.btnUpDateP.UseVisualStyleBackColor = true;
            this.btnUpDateP.Click += new System.EventHandler(this.btnUpDateP_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDeleteP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteP.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnDeleteP.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteP.Location = new System.Drawing.Point(5, 288);
            this.btnDeleteP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(105, 54);
            this.btnDeleteP.TabIndex = 4;
            this.btnDeleteP.Text = "מחיקה";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAddP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddP.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAddP.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddP.Location = new System.Drawing.Point(252, 288);
            this.btnAddP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(105, 54);
            this.btnAddP.TabIndex = 6;
            this.btnAddP.Text = "הוספה";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // dataGridViewP
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewP.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewP.GridColor = System.Drawing.Color.White;
            this.dataGridViewP.Location = new System.Drawing.Point(5, 24);
            this.dataGridViewP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewP.Name = "dataGridViewP";
            this.dataGridViewP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewP.RowHeadersWidth = 51;
            this.dataGridViewP.RowTemplate.Height = 24;
            this.dataGridViewP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewP.Size = new System.Drawing.Size(352, 251);
            this.dataGridViewP.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnUpDateP);
            this.panel1.Controls.Add(this.btnAddP);
            this.panel1.Controls.Add(this.btnDeleteP);
            this.panel1.Controls.Add(this.dataGridViewP);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 358);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 266);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(12, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PortionDeatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.מעקב;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PortionDeatils";
            this.Size = new System.Drawing.Size(367, 385);
            this.Load += new System.EventHandler(this.PortionDeatils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpDateP;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.DataGridView dataGridViewP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}
