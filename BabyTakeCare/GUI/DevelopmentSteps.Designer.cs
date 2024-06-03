
namespace BabyTakeCare.GUI
{
    partial class DevelopmentSteps
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUntil36Month = new System.Windows.Forms.Button();
            this.btnUntil12Month = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 663);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnUntil36Month);
            this.panel2.Controls.Add(this.btnUntil12Month);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 39);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BabyTakeCare.Properties.Resources.חזרה_לאחור;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1103, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUntil36Month
            // 
            this.btnUntil36Month.BackColor = System.Drawing.Color.White;
            this.btnUntil36Month.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUntil36Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUntil36Month.Location = new System.Drawing.Point(737, 2);
            this.btnUntil36Month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUntil36Month.Name = "btnUntil36Month";
            this.btnUntil36Month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUntil36Month.Size = new System.Drawing.Size(179, 33);
            this.btnUntil36Month.TabIndex = 1;
            this.btnUntil36Month.Text = "13-36 חודשים";
            this.btnUntil36Month.UseVisualStyleBackColor = false;
            this.btnUntil36Month.Click += new System.EventHandler(this.btnUntil36Month_Click);
            // 
            // btnUntil12Month
            // 
            this.btnUntil12Month.BackColor = System.Drawing.Color.White;
            this.btnUntil12Month.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnUntil12Month.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnUntil12Month.Font = new System.Drawing.Font("Guttman Yad-Brush", 10.8F);
            this.btnUntil12Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUntil12Month.Location = new System.Drawing.Point(921, 2);
            this.btnUntil12Month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUntil12Month.Name = "btnUntil12Month";
            this.btnUntil12Month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUntil12Month.Size = new System.Drawing.Size(179, 33);
            this.btnUntil12Month.TabIndex = 0;
            this.btnUntil12Month.Text = "עד 12 חודשים";
            this.btnUntil12Month.UseVisualStyleBackColor = false;
            this.btnUntil12Month.Click += new System.EventHandler(this.btnUntil12Month_Click);
            // 
            // DevelopmentSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabyTakeCare.Properties.Resources.רקעים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DevelopmentSteps";
            this.Size = new System.Drawing.Size(1179, 699);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUntil12Month;
        private System.Windows.Forms.Button btnUntil36Month;
        private System.Windows.Forms.Button button1;
    }
}
