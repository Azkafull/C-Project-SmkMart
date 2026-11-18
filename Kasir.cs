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
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Kasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kasir_Load(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LihatBarang lihatBarangForm = new LihatBarang();
            lihatBarangForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RiwayatTransaksi riwayatTransaksiForm = new RiwayatTransaksi();
            riwayatTransaksiForm.Show();
            this.Hide();
        }
    }
}
