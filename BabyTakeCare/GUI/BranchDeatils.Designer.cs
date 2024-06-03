
namespace BabyTakeCare.GUI
{
    partial class BranchDeatils
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
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.btnUpDateB = new System.Windows.Forms.Button();
            this.btnDeleteBranch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewB
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewB.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewB.GridColor = System.Drawing.Color.White;
            this.dataGridViewB.Location = new System.Drawing.Point(226, 160);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewB.RowHeadersWidth = 51;
            this.dataGridViewB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewB.Size = new System.Drawing.Size(350, 279);
            this.dataGridViewB.TabIndex = 0;
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAddBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddBranch.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAddBranch.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddBranch.Location = new System.Drawing.Point(496, 469);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(140, 66);
            this.btnAddBranch.TabIndex = 1;
            this.btnAddBranch.Text = "הוספה";
            this.btnAddBranch.UseVisualStyleBackColor = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // btnUpDateB
            // 
            this.btnUpDateB.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnUpDateB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpDateB.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUpDateB.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpDateB.Location = new System.Drawing.Point(330, 469);
            this.btnUpDateB.Name = "btnUpDateB";
            this.btnUpDateB.Size = new System.Drawing.Size(140, 66);
            this.btnUpDateB.TabIndex = 2;
            this.btnUpDateB.Text = "עידכון";
            this.btnUpDateB.UseVisualStyleBackColor = true;
            this.btnUpDateB.Click += new System.EventHandler(this.btnUpDateB_Click);
            // 
            // btnDeleteBranch
            // 
            this.btnDeleteBranch.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDeleteBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteBranch.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnDeleteBranch.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteBranch.Location = new System.Drawing.Point(170, 469);
            this.btnDeleteBranch.Name = "btnDeleteBranch";
            this.btnDeleteBranch.Size = new System.Drawing.Size(140, 66);
            this.btnDeleteBranch.TabIndex = 3;
            this.btnDeleteBranch.Text = "מחיקה";
            this.btnDeleteBranch.UseVisualStyleBackColor = true;
            this.btnDeleteBranch.Click += new System.EventHandler(this.btnDeleteBranch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(529, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "רחוב סניף";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BranchDeatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteBranch);
            this.Controls.Add(this.btnUpDateB);
            this.Controls.Add(this.btnAddBranch);
            this.Controls.Add(this.dataGridViewB);
            this.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "BranchDeatils";
            this.Size = new System.Drawing.Size(1177, 695);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.Button btnUpDateB;
        private System.Windows.Forms.Button btnDeleteBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
