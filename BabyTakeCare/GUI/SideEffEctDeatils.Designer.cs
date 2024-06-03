
namespace BabyTakeCare.GUI
{
    partial class SideEffEctDeatils
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.btnUpDateSE = new System.Windows.Forms.Button();
            this.btnDeleteSE = new System.Windows.Forms.Button();
            this.btnAddSE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewS
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewS.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewS.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewS.GridColor = System.Drawing.Color.White;
            this.dataGridViewS.Location = new System.Drawing.Point(5, 9);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewS.RowHeadersWidth = 51;
            this.dataGridViewS.RowTemplate.Height = 24;
            this.dataGridViewS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewS.Size = new System.Drawing.Size(469, 309);
            this.dataGridViewS.TabIndex = 0;
            // 
            // btnUpDateSE
            // 
            this.btnUpDateSE.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnUpDateSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpDateSE.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUpDateSE.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpDateSE.Location = new System.Drawing.Point(171, 339);
            this.btnUpDateSE.Name = "btnUpDateSE";
            this.btnUpDateSE.Size = new System.Drawing.Size(140, 66);
            this.btnUpDateSE.TabIndex = 3;
            this.btnUpDateSE.Text = "עידכון";
            this.btnUpDateSE.UseVisualStyleBackColor = true;
            this.btnUpDateSE.Click += new System.EventHandler(this.btnUpDateSE_Click);
            // 
            // btnDeleteSE
            // 
            this.btnDeleteSE.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDeleteSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteSE.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnDeleteSE.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteSE.Location = new System.Drawing.Point(5, 339);
            this.btnDeleteSE.Name = "btnDeleteSE";
            this.btnDeleteSE.Size = new System.Drawing.Size(140, 66);
            this.btnDeleteSE.TabIndex = 4;
            this.btnDeleteSE.Text = "מחיקה";
            this.btnDeleteSE.UseVisualStyleBackColor = true;
            this.btnDeleteSE.Click += new System.EventHandler(this.btnDeleteSE_Click);
            // 
            // btnAddSE
            // 
            this.btnAddSE.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAddSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSE.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAddSE.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddSE.Location = new System.Drawing.Point(336, 339);
            this.btnAddSE.Name = "btnAddSE";
            this.btnAddSE.Size = new System.Drawing.Size(140, 66);
            this.btnAddSE.TabIndex = 5;
            this.btnAddSE.Text = "הוספה";
            this.btnAddSE.UseVisualStyleBackColor = true;
            this.btnAddSE.Click += new System.EventHandler(this.btnAddSE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAddSE);
            this.panel1.Controls.Add(this.dataGridViewS);
            this.panel1.Controls.Add(this.btnDeleteSE);
            this.panel1.Controls.Add(this.btnUpDateSE);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 430);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-3, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 474);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(47, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 69);
            this.button1.TabIndex = 121;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SideEffEctDeatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.מעקב;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            this.Name = "SideEffEctDeatils";
            this.Size = new System.Drawing.Size(489, 474);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewS;
        private System.Windows.Forms.Button btnUpDateSE;
        private System.Windows.Forms.Button btnDeleteSE;
        private System.Windows.Forms.Button btnAddSE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}
