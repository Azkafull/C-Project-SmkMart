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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LaporanAktivitas laporanAktivitas = new LaporanAktivitas();
            laporanAktivitas.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelolaAkun kelolaAkun = new KelolaAkun();
            kelolaAkun.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KelolaBarng kelolaBarng = new KelolaBarng();
            kelolaBarng.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LaporanPenjualan laporanPenjualan = new LaporanPenjualan();
            laporanPenjualan.Show();
            this.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
