using System;
using System.Drawing;
using System.Windows.Forms;

namespace grafika
{
    public partial class Form1 : Form
    {
        private Button myButton;

        public Form1()
        {
            InitializeComponent();//tega pusti ne spreminjaj
            ustvari();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ustvari()
        {
            // Inicializacija gumba
            myButton = new Button();

            // Nastavite lastnosti gumba
            myButton.Size = new Size(100, 50);
            myButton.Location = new Point(50, 50);
            myButton.Text = "Klikni me";
            myButton.Name = "myButton";

            // Dodajte event handler za klik dogodke
            myButton.Click += new EventHandler(Button_Click);

            // Dodajte gumb na obrazec
            this.Controls.Add(myButton);

            // Nastavitve obrazca
            this.ClientSize = new Size(800, 600);
            this.Name = "Form1";
            this.Text = "Moj obrazec";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gumb je bil kliknjen!");
        }
    }
}
