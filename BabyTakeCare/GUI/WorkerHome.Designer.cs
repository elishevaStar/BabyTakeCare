
namespace BabyTakeCare.GUI
{
    partial class WorkerHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerHome));
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lHigh = new System.Windows.Forms.Label();
            this.lWeigh = new System.Windows.Forms.Label();
            this.lKind = new System.Windows.Forms.Label();
            this.panelDeatils = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combKindTreat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewN = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.panelDeatils.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewN)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(716, 121);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.MaxLength = 9;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(155, 22);
            this.txtid.TabIndex = 0;
            this.txtid.Visible = false;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::BabyTakeCare.Properties.Resources.חיפוש;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnSearch.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSearch.Location = new System.Drawing.Point(683, 117);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.BackColor = System.Drawing.Color.Transparent;
            this.lName.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.lName.ForeColor = System.Drawing.Color.Maroon;
            this.lName.Location = new System.Drawing.Point(11, 10);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(61, 26);
            this.lName.TabIndex = 2;
            this.lName.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(879, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "ת.ז. תינוק";
            this.label3.Visible = false;
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.BackColor = System.Drawing.Color.Transparent;
            this.lAge.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.lAge.ForeColor = System.Drawing.Color.Maroon;
            this.lAge.Location = new System.Drawing.Point(19, 55);
            this.lAge.Name = "lAge";
            this.lAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lAge.Size = new System.Drawing.Size(61, 26);
            this.lAge.TabIndex = 6;
            this.lAge.Text = "label1";
            // 
            // lHigh
            // 
            this.lHigh.AutoSize = true;
            this.lHigh.BackColor = System.Drawing.Color.Transparent;
            this.lHigh.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.lHigh.ForeColor = System.Drawing.Color.Maroon;
            this.lHigh.Location = new System.Drawing.Point(19, 186);
            this.lHigh.Name = "lHigh";
            this.lHigh.Size = new System.Drawing.Size(61, 26);
            this.lHigh.TabIndex = 7;
            this.lHigh.Text = "label1";
            // 
            // lWeigh
            // 
            this.lWeigh.AutoSize = true;
            this.lWeigh.BackColor = System.Drawing.Color.Transparent;
            this.lWeigh.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.lWeigh.ForeColor = System.Drawing.Color.Maroon;
            this.lWeigh.Location = new System.Drawing.Point(19, 145);
            this.lWeigh.Name = "lWeigh";
            this.lWeigh.Size = new System.Drawing.Size(61, 26);
            this.lWeigh.TabIndex = 8;
            this.lWeigh.Text = "label1";
            // 
            // lKind
            // 
            this.lKind.AutoSize = true;
            this.lKind.BackColor = System.Drawing.Color.Transparent;
            this.lKind.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.lKind.ForeColor = System.Drawing.Color.Maroon;
            this.lKind.Location = new System.Drawing.Point(19, 100);
            this.lKind.Name = "lKind";
            this.lKind.Size = new System.Drawing.Size(61, 26);
            this.lKind.TabIndex = 9;
            this.lKind.Text = "label1";
            // 
            // panelDeatils
            // 
            this.panelDeatils.BackColor = System.Drawing.Color.Transparent;
            this.panelDeatils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDeatils.Controls.Add(this.lName);
            this.panelDeatils.Controls.Add(this.lHigh);
            this.panelDeatils.Controls.Add(this.lWeigh);
            this.panelDeatils.Controls.Add(this.lKind);
            this.panelDeatils.Controls.Add(this.lAge);
            this.panelDeatils.Enabled = false;
            this.panelDeatils.Location = new System.Drawing.Point(683, 206);
            this.panelDeatils.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDeatils.Name = "panelDeatils";
            this.panelDeatils.Size = new System.Drawing.Size(219, 221);
            this.panelDeatils.TabIndex = 10;
            this.panelDeatils.Visible = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCustomer.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddCustomer.Location = new System.Drawing.Point(531, 10);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(160, 69);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "הוספת מטופל ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.BackColor = System.Drawing.Color.Transparent;
            this.lError.Font = new System.Drawing.Font("Guttman Yad-Brush", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lError.Location = new System.Drawing.Point(721, 146);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(47, 21);
            this.lError.TabIndex = 12;
            this.lError.Text = "label1";
            this.lError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(35, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "סוג הטיפול הנדרש";
            this.label1.Visible = false;
            // 
            // combKindTreat
            // 
            this.combKindTreat.Font = new System.Drawing.Font("Guttman Yad-Brush", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.combKindTreat.ForeColor = System.Drawing.Color.Maroon;
            this.combKindTreat.FormattingEnabled = true;
            this.combKindTreat.Location = new System.Drawing.Point(40, 434);
            this.combKindTreat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combKindTreat.Name = "combKindTreat";
            this.combKindTreat.Size = new System.Drawing.Size(160, 29);
            this.combKindTreat.TabIndex = 14;
            this.combKindTreat.Visible = false;
            this.combKindTreat.SelectedIndexChanged += new System.EventHandler(this.combKindTreat_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 703);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridViewN);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpDate);
            this.panel2.Controls.Add(this.combKindTreat);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lError);
            this.panel2.Controls.Add(this.btnAddCustomer);
            this.panel2.Controls.Add(this.panelDeatils);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Location = new System.Drawing.Point(107, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 596);
            this.panel2.TabIndex = 15;
            this.panel2.VisibleChanged += new System.EventHandler(this.panel2_VisibleChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(721, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 69);
            this.button2.TabIndex = 24;
            this.button2.Text = "חיפוש מטופל קים";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(343, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 69);
            this.button1.TabIndex = 23;
            this.button1.Text = "צפיה בפניות שנשלחו";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(267, 301);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 278);
            this.panel3.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(12, 226);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "סגור";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.radioButton1.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton1.Location = new System.Drawing.Point(49, 185);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(141, 30);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "סמן כנקרא";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(191, 166);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridViewN
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewN.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Guttman Yad-Brush", 7.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewN.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewN.GridColor = System.Drawing.Color.White;
            this.dataGridViewN.Location = new System.Drawing.Point(18, 85);
            this.dataGridViewN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewN.Name = "dataGridViewN";
            this.dataGridViewN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewN.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewN.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dataGridViewN.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewN.Size = new System.Drawing.Size(472, 210);
            this.dataGridViewN.TabIndex = 21;
            this.dataGridViewN.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewN_RowHeaderMouseDoubleClick);
            this.dataGridViewN.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewN_RowHeaderMouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(601, 501);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 62);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "מחיקת מטופל";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.BackgroundImage = global::BabyTakeCare.Properties.Resources.כפתור_מחודש_צבוע;
            this.btnUpDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpDate.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpDate.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpDate.Location = new System.Drawing.Point(790, 501);
            this.btnUpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(160, 62);
            this.btnUpDate.TabIndex = 17;
            this.btnUpDate.Text = "עדכון מטופל";
            this.btnUpDate.UseVisualStyleBackColor = true;
            this.btnUpDate.Visible = false;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // WorkerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1181, 703);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WorkerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerHome";
            this.Load += new System.EventHandler(this.WorkerHome_Load);
            this.panelDeatils.ResumeLayout(false);
            this.panelDeatils.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lHigh;
        private System.Windows.Forms.Label lWeigh;
        private System.Windows.Forms.Label lKind;
        private System.Windows.Forms.Panel panelDeatils;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combKindTreat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpDate;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}