using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class VentanaFacturas : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "pedidos";

        public VentanaFacturas()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(dataGridFact, nombreTabla, "*", "");
        }

        private void VentanaFacturas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAtrasSeleccionarFactura_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void btTramitarFactura_Click(object sender, EventArgs e)
        {
            VentanaFacturarPedidos factPedidos = new VentanaFacturarPedidos();
            factPedidos.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ayudaFacturas_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "manual_de_usuario_ventas.pdf");
            Process.Start(pdfPath);
        }
    }
}
