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
    public partial class RiwayatTransaksi : Form
    {
        public RiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void RiwayatTransaksi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kasir kasir = new Kasir();
            kasir.Show();

            this.Hide();
        }
    }
}
