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
    public partial class AktivitasAdmin : Form
    {
        public AktivitasAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LaporanAktivitas laporanAktivitas = new LaporanAktivitas();
            laporanAktivitas.Show();
            this.Hide();
        }
    }
}
