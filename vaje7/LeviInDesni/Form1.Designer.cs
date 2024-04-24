namespace LeviInDesni
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
            this.Levi = new System.Windows.Forms.Button();
            this.Desni = new System.Windows.Forms.Button();
            this.Besedilo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Levi
            // 
            this.Levi.Location = new System.Drawing.Point(247, 205);
            this.Levi.Name = "Levi";
            this.Levi.Size = new System.Drawing.Size(75, 23);
            this.Levi.TabIndex = 0;
            this.Levi.Text = "Levi";
            this.Levi.UseVisualStyleBackColor = true;
            this.Levi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Levi_MouseDown);
            this.Levi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZbrisiNapis);
            // 
            // Desni
            // 
            this.Desni.Location = new System.Drawing.Point(517, 210);
            this.Desni.Name = "Desni";
            this.Desni.Size = new System.Drawing.Size(75, 23);
            this.Desni.TabIndex = 1;
            this.Desni.Text = "Desni";
            this.Desni.UseVisualStyleBackColor = true;
            this.Desni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Desni_MouseDown);
            this.Desni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZbrisiNapis);
            // 
            // Besedilo
            // 
            this.Besedilo.AutoSize = true;
            this.Besedilo.Location = new System.Drawing.Point(405, 215);
            this.Besedilo.Name = "Besedilo";
            this.Besedilo.Size = new System.Drawing.Size(0, 13);
            this.Besedilo.TabIndex = 2;
            this.Besedilo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Besedilo);
            this.Controls.Add(this.Desni);
            this.Controls.Add(this.Levi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Levi;
        private System.Windows.Forms.Button Desni;
        private System.Windows.Forms.Label Besedilo;
    }
}

