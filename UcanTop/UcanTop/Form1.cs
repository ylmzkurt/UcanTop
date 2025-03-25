namespace UcanTop
{
    public partial class Form1 : Form
    {
        int yerX = 2, yerY = 2;
        int kalanHak = 5;
        int kurtarmaSayisi = 0;
        int saniye = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void duvaraCarpma()
        {
            if (top.Top <= duvarUst.Bottom) // Üst duvara çarpma
                yerY *= -1;

            if (top.Left >= duvarSol.Right) // Sol duvara çarpma
                yerX *= -1;

            if (top.Right <= duvarSag.Left) // Sað duvara çarpma
                yerX *= -1;

            if (top.Bottom >= engel.Top && top.Left >= engel.Left && top.Right <= engel.Right)
            {
                kurtarmaSayisi++;
                label4.Text = "Kurtarma Sayýsý: " + kurtarmaSayisi.ToString();
                yerY *= -1; // Engele çarpma

            }
        }

        private void yanmaOlayi(object sender, EventArgs e)
        {
            if (top.Top >= engel.Bottom)
            {
                kalanHak--;

                if (kalanHak == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Oyun sona erdi", "Yandýnýz!", MessageBoxButtons.OK);
                    ActiveForm.Close();
                }
                else if (kalanHak > 0)
                {
                    timer1.Stop();
                    timer2.Stop();

                    kurtarmaSayisi = 0;
                    saniye = 0;

                    label4.Text = "Kurtarma Sayýsý: " + kurtarmaSayisi.ToString();
                    label7.Text = saniye.ToString();
                    MessageBox.Show("Yandýnýz.\nKalan Hak:" + kalanHak.ToString());

                    label3.Text = "Kalan Hak: " + kalanHak.ToString();
                    Form1_Load(sender, e);
                }
            }
        }

        private void topuSifirla()
        {
            top.Location = new Point(101, 61);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            top.Location = new Point(top.Location.X + yerX, top.Location.Y + yerY);
            duvaraCarpma();
            yanmaOlayi(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            engel.Left = e.X;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            label7.Text = saniye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topuSifirla();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
    }
}
