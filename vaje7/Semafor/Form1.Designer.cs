namespace Semafor
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
            this.rdeca = new System.Windows.Forms.Button();
            this.Rumena = new System.Windows.Forms.Button();
            this.Zelena = new System.Windows.Forms.Button();
            this.semafor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdeca
            // 
            this.rdeca.Location = new System.Drawing.Point(200, 131);
            this.rdeca.Name = "rdeca";
            this.rdeca.Size = new System.Drawing.Size(75, 23);
            this.rdeca.TabIndex = 0;
            this.rdeca.Text = "Rdeca";
            this.rdeca.UseVisualStyleBackColor = true;
            this.rdeca.Click += new System.EventHandler(this.rdeca_Click);
            // 
            // Rumena
            // 
            this.Rumena.Location = new System.Drawing.Point(200, 194);
            this.Rumena.Name = "Rumena";
            this.Rumena.Size = new System.Drawing.Size(75, 23);
            this.Rumena.TabIndex = 1;
            this.Rumena.Text = "Rumena";
            this.Rumena.UseVisualStyleBackColor = true;
            this.Rumena.Click += new System.EventHandler(this.Rumena_Click);
            // 
            // Zelena
            // 
            this.Zelena.Location = new System.Drawing.Point(200, 252);
            this.Zelena.Name = "Zelena";
            this.Zelena.Size = new System.Drawing.Size(75, 23);
            this.Zelena.TabIndex = 2;
            this.Zelena.Text = "Zelena";
            this.Zelena.UseVisualStyleBackColor = true;
            this.Zelena.Click += new System.EventHandler(this.button3_Click);
            // 
            // semafor
            // 
            this.semafor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.semafor.Location = new System.Drawing.Point(317, 163);
            this.semafor.Name = "semafor";
            this.semafor.Size = new System.Drawing.Size(108, 97);
            this.semafor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semafor);
            this.Controls.Add(this.Zelena);
            this.Controls.Add(this.Rumena);
            this.Controls.Add(this.rdeca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rdeca;
        private System.Windows.Forms.Button Rumena;
        private System.Windows.Forms.Button Zelena;
        private System.Windows.Forms.Label semafor;
    }
}

