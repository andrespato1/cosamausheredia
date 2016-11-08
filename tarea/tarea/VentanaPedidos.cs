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
    public partial class VentanaPedidos : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "producto";

        public VentanaPedidos()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridPedidos, nombreTabla, "*", "");
        }

        private void VentanaPedidos_Load(object sender, EventArgs e)
        {

        }

        private void tbProductoPedir_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            string var = "";
            var = var + tbnumPedido.Text;
            var = var + "," + tbSKU.Text;
            var = var + "," + tbCantidadProducto.Text;
            var = var + "," + tbPrecioUnit.Text;
            var = var + "," + tbDescuento.Text;
            var = var + "," + tbImpuesto.Text;
            var = var + "," + (int.Parse(tbCantidadProducto.Text) * int.Parse(tbPrecioUnit.Text));

            baseDatos.agregarValoresBaseDatos("detalleProducto_pedidos", var);
            tbnumPedido.Text = "";
            tbSKU.Text = "";
            tbCantidadProducto.Text = "";
            tbPrecioUnit.Text = "";
            tbDescuento.Text = "";
            tbImpuesto.Text = "";
            tbCantidadProducto.Text = "";

        }

        private void ayudaRegPedido_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "manual_de_usuario_ventas.pdf");
            Process.Start(pdfPath);
        }
    }
}
