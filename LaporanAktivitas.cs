using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMKmart
{
    public partial class LaporanAktivitas : Form
    {
        public LaporanAktivitas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void LaporanAktivitas_Load(object sender, EventArgs e)
        {

        }
        private void LaporanAktivitas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AktivitasGudang aktivitasGudang = new AktivitasGudang();
            aktivitasGudang.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AktivitasAdmin aktivitasAdmin = new AktivitasAdmin();
            aktivitasAdmin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AktivitasKasir aktivitasKasir = new AktivitasKasir();
            aktivitasKasir.Show();
            this.Hide();
        }
    }
}
