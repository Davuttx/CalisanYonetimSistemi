using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CalısanYonetimSistemi_2._0
{
    public partial class loding : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int currentValue = 1;
        int interval = 500;
        int minInterval = 100;
        bool isDatabaseConnected = false;

        public loding()
        {
            InitializeComponent();
            timer.Interval = interval;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void loding_Load(object sender, EventArgs e)
        {
            try
            {
                // MySQL veritabanına bağlanma
                MySqlConnection conn = new MySqlConnection("server=localhost;Database=personel;uid=root;pwd='';");
                conn.Open();

                isDatabaseConnected = true; // Bağlantı başarılı
            }
            catch (Exception ex)
            {
                // Bağlantı başarısız, hata formunu göster
                isDatabaseConnected = false;
                this.Hide();
                hata hata = new hata();
                hata.Show();

                // Tüm işlemleri devre dışı bırak
                DisableAllControls();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isDatabaseConnected)
            {
                // Veritabanı bağlantısı başarısızsa işlemi durdur
                timer.Stop();
                return;
            }

            currentValue *= 2;
            if (currentValue <= progressBar1.Maximum)
            {
                progressBar1.Value = currentValue;

                if (timer.Interval > minInterval)
                {
                    timer.Interval = Math.Max(timer.Interval - 100, minInterval);
                }
            }
            else
            {
                timer.Stop();
                this.Hide();
                ANAMENU ana = new ANAMENU();
                ana.Show();
            }
        }

        // Tüm kontrolleri devre dışı bırakmak için kullanılan metod
        private void DisableAllControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
        }
    }
}
