using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalısanYonetimSistemi_2._0
{
    public partial class KATEGORİ : Form
    {
        public KATEGORİ()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;Database=personel;uid=root;pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        private void btnk_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO kategorib(Departman)" +
              "VALUES (@Departman)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Departman", txtktgadi.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM kategorib", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void KATEGORİ_Load(object sender, EventArgs e)
        {
            VeriGetir();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek istediğinizden eminmisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string sql = "DELETE FROM kategorib WHERE id=@id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                VeriGetir();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ANAMENU ana = new ANAMENU();
            ana.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE kategorib " +
                   "SET Departman=@Departman " +
                   "WHERE id=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Departman", txtktgadi.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].ToString();
            txtktgadi.Text = dataGridView1.CurrentRow.Cells[1].ToString();
        }
    }
}
