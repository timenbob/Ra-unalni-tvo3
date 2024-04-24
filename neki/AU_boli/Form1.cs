namespace AU_boli
{
    //int nak_x=genrator.next(this.Width)
    //int nak_y=genrator.next(this.Height)
    //KLICK.Location = new Point(nak_x, nak_y);
    public partial class GIOkno : Form
    {
        Random generator = new Random();
        public GIOkno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KLICK_Click(object sender, EventArgs e)
        {
            string[] sporocila = { "au boli", "bla", "neki" };
            int izb = generator.Next(3);

            this.izpis_sporocilo.Text = sporocila[izb];
            this.timer1.Stop();
            this.Pauza2000.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nak_x = generator.Next(this.Width);
            int nak_y = generator.Next(this.Height);
            KLICK.Location = new Point(nak_x, nak_y);
        }

        private void Pauza2000_Tick(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.Pauza2000.Stop();
        }
    }
}
