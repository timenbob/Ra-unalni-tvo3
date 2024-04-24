namespace AU_boli
{
    partial class GIOkno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            KLICK = new Button();
            izpis_sporocilo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Pauza2000 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // KLICK
            // 
            KLICK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KLICK.Location = new Point(332, 226);
            KLICK.Name = "KLICK";
            KLICK.Size = new Size(131, 72);
            KLICK.TabIndex = 0;
            KLICK.Text = "KLICK";
            KLICK.UseVisualStyleBackColor = true;
            KLICK.Click += KLICK_Click;
            // 
            // izpis_sporocilo
            // 
            izpis_sporocilo.AutoSize = true;
            izpis_sporocilo.Location = new Point(179, 113);
            izpis_sporocilo.Name = "izpis_sporocilo";
            izpis_sporocilo.Size = new Size(12, 15);
            izpis_sporocilo.TabIndex = 1;
            izpis_sporocilo.Text = "_";
            izpis_sporocilo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Pauza2000
            // 
            Pauza2000.Enabled = true;
            Pauza2000.Interval = 1000;
            Pauza2000.Tick += Pauza2000_Tick;
            // 
            // GIOkno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(836, 502);
            Controls.Add(izpis_sporocilo);
            Controls.Add(KLICK);
            Name = "GIOkno";
            Text = "AU_boli";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button KLICK;
        private Label izpis_sporocilo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Pauza2000;
    }
}
