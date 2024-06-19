using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grafika
{
    public partial class Form1 : Form
    {   //RDECI je 1
        // osnovi podatki igralcev
        int SteviloZidov_1 = 0;
        int SteviloZidov_2 = 0;
        string ime1 = "ime1";
        string ime2 = "ime2";
        int steviloZasedenihPolij_1 = 0;
        int steviloZasedenihPolij_2 = 0;
        int steviloZasedenihPolijZaZmago = 0;
        int steviloZmag_1 = 0;
        int steviloZmag_2 = 0;
        int steviloZmagZaZmago = 0;
        //
        // podatki za samo igro

        private Button[,] mreza;

        bool KateriEkran = false;
        int visina = 10;
        int sirina = 10;


        Color naVrsti = Color.Red;

        //
        //podatki za igro
        private Label Ime1;
        private Label Ime2;
        private Label stPolij;
        private Label stZmag;
        private Label stZidov;

        private Label stPolij1;
        private Label stPolij2;
        private Label stZmag1;
        private Label stZmag2;
        private Label stZidov1;
        private Label stZidov2;

        private Button reset;
        private Button konec;


        //
        //zacetni ekran stvari
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        //


        public Form1()
        {
            InitializeComponent();
        }

        public void ZacetniEkran()
        {
            // 
            // button1
            // 
            if (button1 == null) { button1 = new System.Windows.Forms.Button(); Controls.Add(button1); }

            button1.Location = new System.Drawing.Point(509, 280);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "začni igro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);

            // 
            // label1
            // 
            if (label1 == null) { label1 = new System.Windows.Forms.Label(); Controls.Add(label1); }

            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(65, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 16);
            label1.TabIndex = 1;
            label1.Text = "Višina polja:";

            // 
            // label2
            // 
            if (label2 == null) { label2 = new System.Windows.Forms.Label(); Controls.Add(label2); }

            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(68, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 16);
            label2.TabIndex = 2;
            label2.Text = "Širina polja:";

            // 
            // label3
            // 
            if (label3 == null) { label3 = new System.Windows.Forms.Label(); Controls.Add(label3); }

            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(404, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 16);
            label3.TabIndex = 3;
            label3.Text = "Ime igralec1:";

            // 
            // label4
            // 
            if (label4 == null) { label4 = new System.Windows.Forms.Label(); Controls.Add(label4); }

            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(407, 102);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 16);
            label4.TabIndex = 4;
            label4.Text = "ime igralec2:";

            // 
            // textBox1
            // 
            if (textBox1 == null) { textBox1 = new System.Windows.Forms.TextBox(); Controls.Add(textBox1); }

            textBox1.Location = new System.Drawing.Point(164, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 22);
            textBox1.TabIndex = 5;

            // 
            // textBox2
            // 
            if (textBox2 == null) { textBox2 = new System.Windows.Forms.TextBox(); Controls.Add(textBox2); }

            textBox2.Location = new System.Drawing.Point(164, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 22);
            textBox2.TabIndex = 6;

            // 
            // textBox3
            // 
            if (textBox3 == null) { textBox3 = new System.Windows.Forms.TextBox(); Controls.Add(textBox3); }

            textBox3.Location = new System.Drawing.Point(509, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 22);
            textBox3.TabIndex = 7;

            // 
            // textBox4
            // 
            if (textBox4 == null) { textBox4 = new System.Windows.Forms.TextBox(); Controls.Add(textBox4); }

            textBox4.Location = new System.Drawing.Point(509, 102);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 22);
            textBox4.TabIndex = 8;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int maxi = Math.Max(this.Width, this.Height);
            //this.Width = maxi;
            //this.Height = maxi;

            ZacetniEkran();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KateriEkran = true;
            // Access the text boxes and read their values
            string sirinaText = textBox1.Text;
            string visinaText = textBox2.Text;
            string ime1Text = textBox3.Text;
            string ime2Text = textBox4.Text;

            int dimS;
            if (int.TryParse(sirinaText, out dimS))
            {
                sirina = dimS;
            }

            int dimV;
            if (int.TryParse(visinaText, out dimV))
            {
                visina = dimV;
            }

            if (ime1Text != "")
            {
                ime1 = ime1Text;
            }
            if (ime2Text != "")
            {
                ime2 = ime2Text;
            }

            textBox4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            button1.Visible = false;

            steviloZasedenihPolijZaZmago = sirina * visina / 2;
            steviloZmagZaZmago = Math.Min(visina, sirina) - 1;
            SteviloZidov_1 = Math.Min(visina, sirina)-1;
            SteviloZidov_2 = Math.Min(visina, sirina) - 1;

            MessageBox.Show($"Širina polja: {sirina}, Višina polja: {visina}, Ime igralec1: {ime1}, Ime igralec2: {ime2}");
           
            UstvariPolje();
            int velikostPolja = this.ClientSize.Height;
            int sirinaGumba = velikostPolja / sirina;

            this.Width = sirinaGumba * visina + 500;

        }

        // sledenje podatkom
        private void SledenjePodatkov()
        {
            // Adjust columnWidth to bring columns closer together
            int sirinaPolja = mreza[0,0].Width * visina + 5;
            int padding = 20;

            // Positioning offsets
            int columnWidth = 200; // Reduced width of each column to bring them closer
            int labelHeight = 25;  // Height of each label for vertical spacing

            // Column 1 X position (static labels)
            int col1X = sirinaPolja;
            // Column 2 X position (Player 1 labels)
            int col2X = col1X + columnWidth;
            // Column 3 X position (Player 2 labels)
            int col3X = col2X + columnWidth-100;

            // Creating or updating labels for player names
            if (Ime1 == null)
            {
                Ime1 = new Label();
                Ime1.AutoSize = true;
                this.Controls.Add(Ime1);
            }
            Ime1.Location = new Point(col2X, padding);
            Ime1.Text = ime1;

            if (Ime2 == null)
            {
                Ime2 = new Label();
                Ime2.AutoSize = true;
                this.Controls.Add(Ime2);
            }
            Ime2.Location = new Point(col3X, padding);
            Ime2.Text = ime2;

            // Creating or updating labels for static text
            if (stPolij == null)
            {
                stPolij = new Label();
                stPolij.AutoSize = true;
                this.Controls.Add(stPolij);
            }
            stPolij.Location = new Point(col1X, Ime1.Bottom + padding);
            stPolij.Text = $"stevilo zauzetih polij / {steviloZasedenihPolijZaZmago}";

            if (stZmag == null)
            {
                stZmag = new Label();
                stZmag.AutoSize = true;
                this.Controls.Add(stZmag);
            }
            stZmag.Location = new Point(col1X, stPolij.Bottom + padding);
            stZmag.Text = $"stevilo zmag / {steviloZmagZaZmago}";

            if (stZidov == null)
            {
                stZidov = new Label();
                stZidov.AutoSize = true;
                this.Controls.Add(stZidov);
            }
            stZidov.Location = new Point(col1X, stZmag.Bottom + padding);
            stZidov.Text = "stevilo preostalih zidov";

            // Creating or updating labels for player 1's dynamic data
            if (stPolij1 == null)
            {
                stPolij1 = new Label();
                stPolij1.AutoSize = true;
                this.Controls.Add(stPolij1);
            }
            stPolij1.Location = new Point(col2X, stPolij.Top);
            stPolij1.Text = "" + steviloZasedenihPolij_1;

            if (stZmag1 == null)
            {
                stZmag1 = new Label();
                stZmag1.AutoSize = true;
                this.Controls.Add(stZmag1);
            }
            stZmag1.Location = new Point(col2X, stZmag.Top);
            stZmag1.Text = "" + steviloZmag_1;

            if (stZidov1 == null)
            {
                stZidov1 = new Label();
                stZidov1.AutoSize = true;
                this.Controls.Add(stZidov1);
            }
            stZidov1.Location = new Point(col2X, stZidov.Top);
            stZidov1.Text = "" + SteviloZidov_1;

            // Creating or updating labels for player 2's dynamic data
            if (stPolij2 == null)
            {
                stPolij2 = new Label();
                stPolij2.AutoSize = true;
                this.Controls.Add(stPolij2);
            }
            stPolij2.Location = new Point(col3X, stPolij.Top);
            stPolij2.Text = "" + steviloZasedenihPolij_2;

            if (stZmag2 == null)
            {
                stZmag2 = new Label();
                stZmag2.AutoSize = true;
                this.Controls.Add(stZmag2);
            }
            stZmag2.Location = new Point(col3X, stZmag.Top);
            stZmag2.Text = "" + steviloZmag_2;

            if (stZidov2 == null)
            {
                stZidov2 = new Label();
                stZidov2.AutoSize = true;
                this.Controls.Add(stZidov2);
            }
            stZidov2.Location = new Point(col3X, stZidov.Top);
            stZidov2.Text = "" + SteviloZidov_2;

            //gumba


            if (reset == null) 
            {
                reset = new Button();
                reset.Click += new EventHandler(reset_Click);
                reset.Text = "ponovno";
                this.Controls.Add(reset);
            }
            reset.Location = new Point(col3X, stZidov.Bottom + 3*padding);

            if (konec == null) 
            {
                konec = new Button();
                konec.Click += new EventHandler(konec_Click);
                konec.Text = "konec";
                this.Controls.Add(konec);
            }
            konec.Location = new Point(col2X, stZidov.Bottom + 3*padding);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Reset player statistics
            steviloZasedenihPolij_1 = 0;
            steviloZasedenihPolij_2 = 0;
            steviloZmag_1 = 0;
            steviloZmag_2 = 0;
            SteviloZidov_1 = Math.Min(visina, sirina) - 1;
            SteviloZidov_2 = Math.Min(visina, sirina) - 1;
            naVrsti = Color.Red;

            // Reset the grid
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    if (mreza[i, j] != null)
                    {
                        mreza[i, j].BackColor = Color.White;
                        mreza[i, j].Enabled = true; // Re-enable the button
                    }
                }
            }

            Ime1.ForeColor = Color.Purple;
            Ime2.ForeColor = Color.Black;

            // Update the UI with reset values
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            if (stPolij1 != null) stPolij1.Text = steviloZasedenihPolij_1.ToString();
            if (stPolij2 != null) stPolij2.Text = steviloZasedenihPolij_2.ToString();
            if (stZmag1 != null) stZmag1.Text = steviloZmag_1.ToString();
            if (stZmag2 != null) stZmag2.Text = steviloZmag_2.ToString();
            if (stZidov1 != null) stZidov1.Text = SteviloZidov_1.ToString();
            if (stZidov2 != null) stZidov2.Text = SteviloZidov_2.ToString();
        }

        private void konec_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;

            // Confirm if the user wants to end the game
            DialogResult result = MessageBox.Show(
                "Are you sure you want to end the game?",
                "End Game",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Optional: Save game state or statistics
                //SaveGameState();

                // Optional: Display final statistics or message
               //ShowFinalStatistics();

                // Close the game window or application
                this.Close(); // Close the form

                // Alternatively, exit the entire application
                // Application.Exit();
            }
            else
            {
                // User chose not to end the game
                // You can provide feedback or simply do nothing
                MessageBox.Show("Game continues!", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UstvariPolje()
        {
            if (mreza == null)
            {
                mreza = new Button[visina, sirina];
            }


            int velikostPolja = this.ClientSize.Height;
            int sirinaGumba1 = velikostPolja / sirina;
            int sirinaGumba2 = (this.ClientSize.Width-500) / visina;

            int sirinaGumba=Math.Min(sirinaGumba1 , sirinaGumba2);

            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {

                    if (mreza[i, j] == null)
                    {
                        mreza[i, j] = new Button();
                        mreza[i, j].Click += new EventHandler(gumb_Click);
                        mreza[i, j].BackColor = Color.White;
                        this.Controls.Add(mreza[i, j]);
                        
                    }



                    mreza[i, j].Width = sirinaGumba;
                    mreza[i, j].Height = sirinaGumba;
                    mreza[i, j].Location = new Point(i * sirinaGumba, j * sirinaGumba);

                }
            }

            SledenjePodatkov();
            AdjustFontSize();


        }

        /// <summary>
        /// Ko kliknemo na nek gumb na igralnem polju kaj se zgodi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gumb_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            if (gumb.BackColor == Color.White)
            {
                gumb.BackColor = naVrsti;
                if (naVrsti == Color.Blue)
                {
                    naVrsti = Color.Red;
                    Ime1.ForeColor = Color.Purple;
                    Ime2.ForeColor = Color.Black;
                    steviloZasedenihPolij_2++;
                }
                else
                {
                    naVrsti = Color.Blue;
                    Ime2.ForeColor = Color.Purple;
                    Ime1.ForeColor = Color.Black;
                    steviloZasedenihPolij_1++;
                }

            }
            else
            {
                if (naVrsti == Color.Red && gumb.BackColor == Color.Blue)
                {
                    if (SteviloZidov_1 > 0)
                    {
                        gumb.BackColor = Color.Gray;
                        SteviloZidov_1--; 
                        naVrsti = Color.Blue;
                        Ime2.ForeColor = Color.Purple;
                        Ime1.ForeColor = Color.Black;
                        steviloZasedenihPolij_2--;
                    }
                    else
                    {
                        MessageBox.Show($"Zmankalo ti je zidov");
                    }
                }

                if (naVrsti == Color.Blue && gumb.BackColor == Color.Red)
                {
                    if (SteviloZidov_2 > 0) 
                    { 
                        gumb.BackColor = Color.Gray;
                        SteviloZidov_2--; 
                        naVrsti = Color.Red;
                        Ime1.ForeColor = Color.Purple;
                        Ime2.ForeColor = Color.Black;
                        steviloZasedenihPolij_1--;
                    }
                    else
                    {
                        MessageBox.Show($"Zmankalo ti je zidov");
                    }
                }


            }
            rezultatInUpdejt();
            zmaga();
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int velikostPolja = this.ClientSize.Height;
            int sirinaGumba = velikostPolja / sirina;

            this.Width= sirinaGumba*visina+500;
            
            if (KateriEkran)
            {
                UstvariPolje();
                SledenjePodatkov();
                AdjustFontSize();


            }
            else { ZacetniEkran(); }

        }
        private void AdjustFontSize()
        {
            float newSize = 12f; // Define the new font size, adjust as needed

            // Adjust font size for each label if it exists
            if (Ime1 != null) Ime1.Font = new Font(Ime1.Font.FontFamily, newSize);
            if (Ime2 != null) Ime2.Font = new Font(Ime2.Font.FontFamily, newSize);
            if (stPolij != null) stPolij.Font = new Font(stPolij.Font.FontFamily, newSize);
            if (stZmag != null) stZmag.Font = new Font(stZmag.Font.FontFamily, newSize);
            if (stZidov != null) stZidov.Font = new Font(stZidov.Font.FontFamily, newSize);
            if (stPolij1 != null) stPolij1.Font = new Font(stPolij1.Font.FontFamily, newSize);
            if (stZmag1 != null) stZmag1.Font = new Font(stZmag1.Font.FontFamily, newSize);
            if (stZidov1 != null) stZidov1.Font = new Font(stZidov1.Font.FontFamily, newSize);
            if (stPolij2 != null) stPolij2.Font = new Font(stPolij2.Font.FontFamily, newSize);
            if (stZmag2 != null) stZmag2.Font = new Font(stZmag2.Font.FontFamily, newSize);
            if (stZidov2 != null) stZidov2.Font = new Font(stZidov2.Font.FontFamily, newSize);
        }


        private void zmaga()
        {
            string zmagal="";
            if (steviloZasedenihPolij_1 >= steviloZasedenihPolijZaZmago)
            {
                zmagal = ime1;
            }
            else if (steviloZasedenihPolij_2 >= steviloZasedenihPolijZaZmago)
            {
                zmagal = ime2;
            }
            else if (steviloZmag_1 >= steviloZmagZaZmago)
            {
                zmagal = ime1;
            }
            else if (steviloZmag_2 >= steviloZmagZaZmago)
            {
                zmagal = ime2;
            }
            else if (PoljeJePolno())
            {
                if (steviloZmag_1 > steviloZmag_2) { zmagal = ime1; }
                else if (steviloZmag_1 < steviloZmag_2) { zmagal = ime2; }
                else
                {
                    if(steviloZasedenihPolij_1 > steviloZasedenihPolij_2) { zmagal = ime1; }
                    else if (steviloZasedenihPolij_1 < steviloZasedenihPolij_2) { zmagal = ime2; }
                    else 
                    {
                        MessageBox.Show("Izzid je neodločen!!!");
                    }
                }
            }
            if(zmagal != "") 
            {
                MessageBox.Show($"Zmagal je {zmagal}");
                for (int i = 0; i < visina; i++)
                {
                    for (int j = 0; j < sirina; j++)
                    {

                        mreza[i, j].Enabled = false;
                        
                        

                    }
                }
            }
            

        }

        /// <summary>
        /// Preveri ali je naše igralno polje že polno
        /// </summary>
        /// <returns>vrne true če je polno sicer false</returns>
        private bool PoljeJePolno()
        {
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {

                    if (mreza[i, j].BackColor == Color.White)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        private void rezultatInUpdejt()
        {   
            CheckForSurroundedTokens();
            //CheckForEnclosedAreas();
            CheckForFourInARow();
            SledenjePodatkov();
        }

        private void CheckForFourInARow()
        {
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    if (mreza[i, j].BackColor == Color.Red || mreza[i, j].BackColor == Color.Blue)
                    {
                        Color playerColor = mreza[i, j].BackColor;

                        // Check horizontal
                        if (j + 3 < sirina &&
                            mreza[i, j + 1].BackColor == playerColor &&
                            mreza[i, j + 2].BackColor == playerColor &&
                            mreza[i, j + 3].BackColor == playerColor)
                        {
                            ConvertToWalls(i, j, 0, 1, playerColor);
                        }

                        // Check vertical
                        if (i + 3 < visina &&
                            mreza[i + 1, j].BackColor == playerColor &&
                            mreza[i + 2, j].BackColor == playerColor &&
                            mreza[i + 3, j].BackColor == playerColor)
                        {
                            ConvertToWalls(i, j, 1, 0, playerColor);
                        }

                        // Check diagonal (down-right)
                        if (i + 3 < visina && j + 3 < sirina &&
                            mreza[i + 1, j + 1].BackColor == playerColor &&
                            mreza[i + 2, j + 2].BackColor == playerColor &&
                            mreza[i + 3, j + 3].BackColor == playerColor)
                        {
                            ConvertToWalls(i, j, 1, 1, playerColor);
                        }

                        // Check diagonal (down-left)
                        if (i + 3 < visina && j - 3 >= 0 &&
                            mreza[i + 1, j - 1].BackColor == playerColor &&
                            mreza[i + 2, j - 2].BackColor == playerColor &&
                            mreza[i + 3, j - 3].BackColor == playerColor)
                        {
                            ConvertToWalls(i, j, 1, -1, playerColor);
                        }
                    }
                }
            }
        }

        private void ConvertToWalls(int row, int col, int rowDir, int colDir, Color playerColor)
        {
            for (int k = 0; k < 4; k++)
            {
                mreza[row + k * rowDir, col + k * colDir].BackColor = Color.Gray;
            }

            if (playerColor == Color.Red)
            {
                steviloZmag_1++;
                steviloZasedenihPolij_1 -= 4;
                
            }
            else if (playerColor == Color.Blue)
            {
                steviloZmag_2++;
                steviloZasedenihPolij_2 -= 4;
            }
        }

        private void CheckForSurroundedTokens()
        {
            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    if (mreza[i, j].BackColor == Color.Red)
                    {
                        if (IsSurrounded(i, j, Color.Red, Color.Blue))
                        {
                            mreza[i, j].BackColor = Color.Blue;
                            steviloZasedenihPolij_1  --;
                            steviloZasedenihPolij_2  ++;
                        }
                    }
                    if (mreza[i, j].BackColor == Color.Blue)
                    {
                        if (IsSurrounded(i, j, Color.Blue, Color.Red))
                        {
                            mreza[i, j].BackColor = Color.Red;
                            steviloZasedenihPolij_1 ++;
                            steviloZasedenihPolij_2 --;
                        }
                    }
                }
            }
        }

        private bool IsSurrounded(int x, int y, Color targetColor, Color surroundingColor)
        {
            // Cardinal directions (N, S, W, E)
            int[,] cardinalDirections = {
        { -1, 0 },  // North
        { 1, 0 },   // South
        { 0, -1 },  // West
        { 0, 1 }    // East
    };

            // Diagonal directions (NW, NE, SW, SE)
            int[,] diagonalDirections = {
        { -1, -1 }, // Northwest
        { -1, 1 },  // Northeast
        { 1, -1 },  // Southwest
        { 1, 1 }    // Southeast
    };

            bool surroundedByCardinals = true;
            bool surroundedByDiagonals = true;

            // Check cardinal directions
            for (int i = 0; i < cardinalDirections.GetLength(0); i++)
            {
                int newX = x + cardinalDirections[i, 0];
                int newY = y + cardinalDirections[i, 1];

                if (newX < 0 || newX >= visina || newY < 0 || newY >= sirina)
                {
                    // Treat the boundary as surrounding
                    continue;
                }
                if (mreza[newX, newY].BackColor != surroundingColor)
                {
                    surroundedByCardinals = false;
                }
            }

            // Check diagonal directions
            for (int i = 0; i < diagonalDirections.GetLength(0); i++)
            {
                int newX = x + diagonalDirections[i, 0];
                int newY = y + diagonalDirections[i, 1];

                if (newX < 0 || newX >= visina || newY < 0 || newY >= sirina)
                {
                    // Treat the boundary as surrounding
                    continue;
                }
                if (mreza[newX, newY].BackColor != surroundingColor)
                {
                    surroundedByDiagonals = false;
                }
            }

            // Cell is considered surrounded if either cardinal or diagonal checks pass
            return surroundedByCardinals || surroundedByDiagonals;
        }

        // ne deluje pravilno
        private void CheckForEnclosedAreas()
        {
            bool[,] visited = new bool[visina, sirina];

            for (int i = 0; i < visina; i++)
            {
                for (int j = 0; j < sirina; j++)
                {
                    // Start flood fill for unvisited and non-boundary cells
                    if (!visited[i, j] && mreza[i, j].BackColor == Color.White)
                    {
                        if (FloodFill(i, j, visited, Color.White, out List<Point> enclosedRegion))
                        {
                            // If the region is enclosed, color all cells in the region
                            foreach (Point p in enclosedRegion)
                            {
                                mreza[p.X, p.Y].BackColor = Color.Blue; // Change to the desired color
                            }
                        }
                    }
                }
            }
        }

        private bool FloodFill(int startX, int startY, bool[,] visited, Color targetColor, out List<Point> enclosedRegion)
        {
            enclosedRegion = new List<Point>();
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(startX, startY));
            visited[startX, startY] = true;

            bool isEnclosed = true;
            int[,] directions = {
        { -1, 0 }, // North
        { 1, 0 },  // South
        { 0, -1 }, // West
        { 0, 1 },  // East
        { -1, -1 }, // Northwest
        { -1, 1 },  // Northeast
        { 1, -1 },  // Southwest
        { 1, 1 }   // Southeast
    };

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();
                enclosedRegion.Add(current);

                for (int i = 0; i < directions.GetLength(0); i++)
                {
                    int newX = current.X + directions[i, 0];
                    int newY = current.Y + directions[i, 1];

                    if (newX < 0 || newX >= visina || newY < 0 || newY >= sirina)
                    {
                        // Reached boundary of grid, not enclosed
                        isEnclosed = false;
                    }
                    else if (!visited[newX, newY])
                    {
                        if (mreza[newX, newY].BackColor == targetColor)
                        {
                            queue.Enqueue(new Point(newX, newY));
                            visited[newX, newY] = true;
                        }
                        else if (mreza[newX, newY].BackColor != Color.Blue) // Assuming Blue is the boundary color
                        {
                            // Encountered a different color; not part of enclosed region
                            isEnclosed = false;
                        }
                    }
                }
            }

            return isEnclosed;
        }
        //
    }
}