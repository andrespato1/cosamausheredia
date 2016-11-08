using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class VentanaFacturarPedidos : Form
    {
        public VentanaFacturarPedidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btFacturarPedido_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbNumFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAtrasFacturarPedido_Click(object sender, EventArgs e)
        {
            VentanaFacturas factPedidos = new VentanaFacturas();
            factPedidos.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
