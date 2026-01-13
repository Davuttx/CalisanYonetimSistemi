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
    public partial class KAYDET : Form
    {
        public KAYDET()
        {
            InitializeComponent();
            conboverigetir();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;Database=personel;uid=root;pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ANAMENU ana = new ANAMENU();
            ana.ShowDialog();

        }

        private void conboverigetir()
        {
            MySqlCommand veri = new MySqlCommand("SELECT *FROM kategorib", conn);
            MySqlDataReader dr;
            conn.Open();
            dr = veri.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["Departman"]);
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO personela(Ad,Soyad,T.C.,Cinsiyet,Departman,maas,eposta,TeleNo,giristarihi)" +
               "VALUES (@Ad,@Soyad,@tc,@Cinsiyet,@Departman,@maas,@eposta,@tlno,@giristarihi)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ad", textBox2.Text);
            cmd.Parameters.AddWithValue("@Soyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@tc", textBox4.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Departman", comboBox2.Text);
            cmd.Parameters.AddWithValue("@maas", textBox5.Text);
            cmd.Parameters.AddWithValue("@eposta", textBox6.Text);
            cmd.Parameters.AddWithValue("@tlno", textBox7.Text);
            cmd.Parameters.AddWithValue("@giristarihi", textBox8.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();

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

        private void KAYDET_Load(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToLongDateString();
            VeriGetir();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           
        }
    }
}
