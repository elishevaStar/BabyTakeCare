
namespace BabyTakeCare.GUI
{
    partial class WorkerDeatils
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewW = new System.Windows.Forms.DataGridView();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnUpDateW = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewW)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewW
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewW.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewW.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewW.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewW.GridColor = System.Drawing.Color.White;
            this.dataGridViewW.Location = new System.Drawing.Point(107, 157);
            this.dataGridViewW.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridViewW.Name = "dataGridViewW";
            this.dataGridViewW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewW.RowHeadersWidth = 51;
            this.dataGridViewW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewW.Size = new System.Drawing.Size(531, 311);
            this.dataGridViewW.TabIndex = 0;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAddWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddWorker.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAddWorker.Location = new System.Drawing.Point(478, 490);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(140, 66);
            this.btnAddWorker.TabIndex = 1;
            this.btnAddWorker.Text = "הוספה";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnUpDateW
            // 
            this.btnUpDateW.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnUpDateW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpDateW.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUpDateW.Location = new System.Drawing.Point(308, 490);
            this.btnUpDateW.Name = "btnUpDateW";
            this.btnUpDateW.Size = new System.Drawing.Size(140, 66);
            this.btnUpDateW.TabIndex = 2;
            this.btnUpDateW.Text = "עידכון";
            this.btnUpDateW.UseVisualStyleBackColor = true;
            this.btnUpDateW.Click += new System.EventHandler(this.btnUpDateW_Click);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDeleteWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteWorker.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnDeleteWorker.Location = new System.Drawing.Point(143, 490);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(140, 66);
            this.btnDeleteWorker.TabIndex = 3;
            this.btnDeleteWorker.Text = "מחיקה";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label1.Location = new System.Drawing.Point(540, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ת.ז. עובד";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 118);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // WorkerDeatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteWorker);
            this.Controls.Add(this.btnUpDateW);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.dataGridViewW);
            this.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "WorkerDeatils";
            this.Size = new System.Drawing.Size(1177, 695);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewW;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnUpDateW;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
