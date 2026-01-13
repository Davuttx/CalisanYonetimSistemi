namespace CalısanYonetimSistemi_2._0
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        private string ad = "Davut";
        private string sifre = "1234";
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == ad)
            {
                if (textBox2.Text == sifre)
                {
                    //ANAMENU frm = new ANAMENU();
                    //frm.Show();
                    this.Hide();
                    loding loding = new loding();
                    loding.Show();

                }

                if (textBox2.Text != sifre)
                {
                    MessageBox.Show("Şifre yanlış!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (textBox1.Text != ad)
            {
                MessageBox.Show("ad yanlış!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
