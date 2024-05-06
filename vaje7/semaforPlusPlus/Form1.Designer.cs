namespace semaforPlusPlus
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
            this.semafor = new System.Windows.Forms.Label();
            this.Zelena = new System.Windows.Forms.Button();
            this.Rumena = new System.Windows.Forms.Button();
            this.rdeca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // semafor
            // 
            this.semafor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.semafor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.semafor.Location = new System.Drawing.Point(348, 147);
            this.semafor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semafor.Name = "semafor";
            this.semafor.Size = new System.Drawing.Size(144, 119);
            this.semafor.TabIndex = 9;
            this.semafor.Text = "0";
            this.semafor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Zelena
            // 
            this.Zelena.Location = new System.Drawing.Point(192, 256);
            this.Zelena.Margin = new System.Windows.Forms.Padding(4);
            this.Zelena.Name = "Zelena";
            this.Zelena.Size = new System.Drawing.Size(100, 28);
            this.Zelena.TabIndex = 8;
            this.Zelena.Text = "Zelena";
            this.Zelena.UseVisualStyleBackColor = true;
            this.Zelena.Click += new System.EventHandler(this.Zelena_Click);
            // 
            // Rumena
            // 
            this.Rumena.Location = new System.Drawing.Point(192, 185);
            this.Rumena.Margin = new System.Windows.Forms.Padding(4);
            this.Rumena.Name = "Rumena";
            this.Rumena.Size = new System.Drawing.Size(100, 28);
            this.Rumena.TabIndex = 7;
            this.Rumena.Text = "Rumena";
            this.Rumena.UseVisualStyleBackColor = true;
            this.Rumena.Click += new System.EventHandler(this.Rumena_Click);
            // 
            // rdeca
            // 
            this.rdeca.Location = new System.Drawing.Point(192, 107);
            this.rdeca.Margin = new System.Windows.Forms.Padding(4);
            this.rdeca.Name = "rdeca";
            this.rdeca.Size = new System.Drawing.Size(100, 28);
            this.rdeca.TabIndex = 6;
            this.rdeca.Text = "Rdeca";
            this.rdeca.UseVisualStyleBackColor = true;
            this.rdeca.Click += new System.EventHandler(this.rdeca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semafor);
            this.Controls.Add(this.Zelena);
            this.Controls.Add(this.Rumena);
            this.Controls.Add(this.rdeca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label semafor;
        private System.Windows.Forms.Button Zelena;
        private System.Windows.Forms.Button Rumena;
        private System.Windows.Forms.Button rdeca;
    }
}

