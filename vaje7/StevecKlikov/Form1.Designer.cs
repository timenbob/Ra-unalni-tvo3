namespace StevecKlikov
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
            this.stevecKlikov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stevecKlikov
            // 
            this.stevecKlikov.AutoSize = true;
            this.stevecKlikov.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stevecKlikov.Location = new System.Drawing.Point(348, 194);
            this.stevecKlikov.Name = "stevecKlikov";
            this.stevecKlikov.Size = new System.Drawing.Size(139, 26);
            this.stevecKlikov.TabIndex = 0;
            this.stevecKlikov.Text = "Števec Klikov";
            this.stevecKlikov.Click += new System.EventHandler(this.Form1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stevecKlikov);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stevecKlikov;
    }
}

