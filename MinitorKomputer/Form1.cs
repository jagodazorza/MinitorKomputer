namespace MinitorKomputer
{
    public partial class Form1 : Form
    {
        public int cenaK;
        public int cenaM;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }
        public void oblicz()
        {
            int cena = cenaK + cenaM;
            label1.Text = cena.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
