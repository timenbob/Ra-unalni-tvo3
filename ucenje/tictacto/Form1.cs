using System;
using System.Drawing;
using System.Windows.Forms;

namespace tictacto
{
    public partial class Form1 : Form
    {
        private Button[,] buttons = new Button[3, 3];
        private bool isXTurn = true;

        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            this.Text = "Križci in Krožci";
            this.ClientSize = new Size(300, 300);
            //this.MinimumSize = new Size(300, 300);

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.RowCount = 3;
            panel.ColumnCount = 3;
            for (int i = 0; i < 3; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33f));
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Button button = new Button();
                    button.Dock = DockStyle.Fill;
                    button.Font = new Font("Arial", 24, FontStyle.Bold);
                    button.Click += new EventHandler(Button_Click);
                    buttons[row, col] = button;
                    panel.Controls.Add(button, col, row);
                }
            }

            this.Controls.Add(panel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "")
            {
                button.Text = isXTurn ? "X" : "O";
                if (CheckForWinner())
                {
                    MessageBox.Show($"{button.Text} je zmagal!", "Konec igre");
                    DisableAllButtons();
                }
                else if (IsDraw())
                {
                    MessageBox.Show("Igra se je končala z neodločenim izidom!", "Konec igre");
                }
                isXTurn = !isXTurn;
            }
        }

        private bool CheckForWinner()
        {
            // Preverjanje vrstic
            for (int row = 0; row < 3; row++)
            {
                if (buttons[row, 0].Text != "" && buttons[row, 0].Text == buttons[row, 1].Text && buttons[row, 1].Text == buttons[row, 2].Text)
                {
                    return true;
                }
            }
            // Preverjanje stolpcev
            for (int col = 0; col < 3; col++)
            {
                if (buttons[0, col].Text != "" && buttons[0, col].Text == buttons[1, col].Text && buttons[1, col].Text == buttons[2, col].Text)
                {
                    return true;
                }
            }
            // Preverjanje diagonale
            if (buttons[0, 0].Text != "" && buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                return true;
            }
            if (buttons[0, 2].Text != "" && buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text)
            {
                return true;
            }
            return false;
        }

        private bool IsDraw()
        {
            foreach (Button button in buttons)
            {
                if (button.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void DisableAllButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int maxi = Math.Max(this.Width, this.Height);
            this.Width= maxi;
            this.Height=maxi;
        }
    }
}
