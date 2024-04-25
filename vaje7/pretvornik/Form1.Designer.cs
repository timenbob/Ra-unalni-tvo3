namespace pretvornik
{
    partial class Form1
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
            this.vpis_cm = new System.Windows.Forms.TextBox();
            this.vpis_ft = new System.Windows.Forms.TextBox();
            this.vpis_inch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vpis_cm
            // 
            this.vpis_cm.Location = new System.Drawing.Point(45, 152);
            this.vpis_cm.Name = "vpis_cm";
            this.vpis_cm.Size = new System.Drawing.Size(105, 20);
            this.vpis_cm.TabIndex = 0;
            // 
            // vpis_ft
            // 
            this.vpis_ft.Location = new System.Drawing.Point(396, 152);
            this.vpis_ft.Name = "vpis_ft";
            this.vpis_ft.Size = new System.Drawing.Size(100, 20);
            this.vpis_ft.TabIndex = 1;
            // 
            // vpis_inch
            // 
            this.vpis_inch.Location = new System.Drawing.Point(587, 152);
            this.vpis_inch.Name = "vpis_inch";
            this.vpis_inch.Size = new System.Drawing.Size(100, 20);
            this.vpis_inch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(85, 108);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(21, 13);
            this.cm.TabIndex = 4;
            this.cm.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "inch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vpis_inch);
            this.Controls.Add(this.vpis_ft);
            this.Controls.Add(this.vpis_cm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vpis_cm;
        private System.Windows.Forms.TextBox vpis_ft;
        private System.Windows.Forms.TextBox vpis_inch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

