
namespace BabyTakeCare.GUI
{
    partial class BabyDeatils
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabyDeatils));
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.btnAddBaby = new System.Windows.Forms.Button();
            this.btnUpDateBaby = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNewS = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewB.GridColor = System.Drawing.Color.White;
            this.dataGridViewB.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewB.RowHeadersWidth = 51;
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewB.Size = new System.Drawing.Size(531, 311);
            this.dataGridViewB.TabIndex = 0;
            // 
            // btnAddBaby
            // 
            this.btnAddBaby.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAddBaby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddBaby.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnAddBaby.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddBaby.Location = new System.Drawing.Point(374, 335);
            this.btnAddBaby.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAddBaby.Name = "btnAddBaby";
            this.btnAddBaby.Size = new System.Drawing.Size(140, 66);
            this.btnAddBaby.TabIndex = 1;
            this.btnAddBaby.Text = "הוספה";
            this.btnAddBaby.UseVisualStyleBackColor = true;
            this.btnAddBaby.Click += new System.EventHandler(this.btnAddBaby_Click);
            // 
            // btnUpDateBaby
            // 
            this.btnUpDateBaby.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnUpDateBaby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpDateBaby.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUpDateBaby.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpDateBaby.Location = new System.Drawing.Point(201, 335);
            this.btnUpDateBaby.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnUpDateBaby.Name = "btnUpDateBaby";
            this.btnUpDateBaby.Size = new System.Drawing.Size(140, 66);
            this.btnUpDateBaby.TabIndex = 2;
            this.btnUpDateBaby.Text = "עידכון";
            this.btnUpDateBaby.UseVisualStyleBackColor = true;
            this.btnUpDateBaby.Click += new System.EventHandler(this.btnUpDateBaby_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(25, 334);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 66);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 111);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label1.Location = new System.Drawing.Point(531, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "ת.ז. תינוק";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(2, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "רגישויות";
            this.toolTip1.SetToolTip(this.button1, "צפיה ברגישיות של התינוק");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(111, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 474);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpDateBaby);
            this.panel2.Controls.Add(this.btnAddBaby);
            this.panel2.Controls.Add(this.dataGridViewB);
            this.panel2.Location = new System.Drawing.Point(110, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 408);
            this.panel2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(2, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "הוספת סוג רגישות";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNewS
            // 
            this.txtNewS.Location = new System.Drawing.Point(3, 478);
            this.txtNewS.Name = "txtNewS";
            this.txtNewS.Size = new System.Drawing.Size(101, 24);
            this.txtNewS.TabIndex = 10;
            this.txtNewS.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(13, 512);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "שמור";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(16, 287);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "אודות";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BabyDeatils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNewS);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "BabyDeatils";
            this.Size = new System.Drawing.Size(1177, 695);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.Button btnAddBaby;
        private System.Windows.Forms.Button btnUpDateBaby;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNewS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button4;
    }
}
