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
    public partial class ANAMENU : Form
    {
        public ANAMENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KAYDET frm = new KAYDET();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ANAMENU_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SİL sil = new SİL();
            sil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GÜNCELLE gle = new GÜNCELLE();
            gle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VERİ_İSLEM vari = new VERİ_İSLEM();
            vari.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KATEGORİ kgr = new KATEGORİ();
            kgr.Show();
            this.Hide();
        }
    }
}
