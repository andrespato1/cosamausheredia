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
    public partial class VentanaPedidos : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "producto";
        int i = 0;

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
            i = 0;
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
            baseDatos.seleccionarValoresBaseDatosTodasLasTablas(dataGridProdPedido, "detalleProducto_pedidos", "numPedido", "= " + tbnumPedido.Text);
            tbSKU.Text = "";
            tbCantidadProducto.Text = "";
            tbPrecioUnit.Text = "";
            tbDescuento.Text = "";
            tbImpuesto.Text = "";
            tbCantidadProducto.Text = "";

        }

        private void botonRegistrarPedido_Click(object sender, EventArgs e)
        {
            string var = "";
            var = var + tbnumPedido.Text;
            var = var + "," + tbCodigoCliente.Text;
            var = var + ",'" + tbFechaPedido.Text + "'";
            var = var + ",'" + tbFechaEntregaP.Text + "'";
            var = var + "," + tbIDEjecVta.Text;
            var = var + ",'REGISTRADO'";
            var = var + ",' '";

            baseDatos.agregarValoresBaseDatos("pedidos", var);
        }
    }
}
