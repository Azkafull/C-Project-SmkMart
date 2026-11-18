using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMKmart
{
    public partial class KelolaBarng : Form
    {
        public KelolaBarng()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void KelolaBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void KelolaBarng_Load(object sender, EventArgs e)
        {

        }
    }
}
