using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalısanYonetimSistemi_2._0
{
    public partial class VERİ_İSLEM : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;Database=personel;uid=root;pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public VERİ_İSLEM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ANAMENU ana = new ANAMENU();
            ana.Show();
        }
        void VeriGetir(string sql)
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM personela", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT SUM(maas) as 'Toplam Maaş' From personela");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT * From personela WHERE Cinsiyet='kadın' ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT DISTINCT Departman From personela");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT AVG(maas) as 'Ortalama Maaş' From personela WHERE Cinsiyet='Kadın'");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT AVG(maas) as 'Ortalama Maaş' From personela WHERE Cinsiyet='Erkek'");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT * From personela WHERE Cinsiyet='Erkek' ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT MAX(maas) as 'EN Yüksek Maaş' From personela");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VeriGetir("SELECT * From personela Order By Ad asc");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // TextBox'tan oranı al
            string oranText = textBox1.Text;

            // Oranı sayıya çevir ve doğrula
            if (decimal.TryParse(oranText, out decimal oran))
            {
                // Veritabanı güncelleme sorgusunu oranla dinamik olarak oluştur
                string sorgu = $"UPDATE personela SET maas = maas + (maas * {oran} / 100)";

                // Sorguyu çalıştır (VeriGetir metoduna sorguyu gönder)
                VeriGetir(sorgu);
            }
            VeriGetir();
        }

        private void VERİ_İSLEM_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
    }
}
