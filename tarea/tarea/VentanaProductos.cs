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
    public partial class VentanaProductos : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "producto";
        public VentanaProductos()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridProductos, nombreTabla, "*", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            //Valores para el insert
            string valores = "";
            valores = valores + TxtSKU.Text + ",";
            valores = valores + "'"+TxtDescripcion.Text + "'" + ",";
            valores = valores + TxtUnidInventario.Text + ",";
            valores = valores + TxtCostUnitario.Text + ",";
            valores = valores + TxtImpuestos.Text + ",";
            valores = valores + TxtPrecVtaUnit.Text;

            baseDatos.agregarValoresBaseDatos(nombreTabla, valores);
            baseDatos.seleccionarValoresBaseDatos(DataGridProductos, nombreTabla, "*", "");

            TxtSKU.Text = "";
            TxtDescripcion.Text = "";
            TxtUnidInventario.Text = "";
            TxtCostUnitario.Text = "";
            TxtImpuestos.Text = "";
            TxtPrecVtaUnit.Text = "";
        }

        private void VentanaProductos_Load(object sender, EventArgs e)
        {

        }

        private void BtnBusquedaProductos_Click(object sender, EventArgs e)
        {
            if (CheckBoxBusca.Checked == true)
            {
                baseDatos.seleccionarValoresBaseDatosTodasLasTablas(DataGridProductos, "producto", CBAtributosProductos.Text, "like '" + TxtBusquedaProductos.Text + "%'");
            }
            else
            {
                baseDatos.seleccionarValoresBaseDatos(DataGridProductos, "producto", CBAtributosProductos.Text, "like '" + TxtBusquedaProductos.Text + "%'");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string queryActualizar = "";
            if (TxtSKU.Text != "")
            {
                if (TxtDescripcion.Text != "")
                {
                    queryActualizar = "update producto set descripcion = '" + TxtDescripcion.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "SKU", TxtSKU.Text);
                }
                if (TxtUnidInventario.Text != "")
                {
                    queryActualizar = "update producto set unidEnInventario = " + TxtUnidInventario.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "SKU", TxtSKU.Text);
                }
                if (TxtCostUnitario.Text != "")
                {
                    queryActualizar = "update producto set costoUnit = " + TxtCostUnitario.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "SKU", TxtSKU.Text);
                }
                if (TxtImpuestos.Text != "")
                {
                    queryActualizar = "update producto set impuesto = " + TxtImpuestos.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "SKU", TxtSKU.Text);
                }
                if (TxtPrecVtaUnit.Text != "")
                {
                    queryActualizar = "update producto set precioVtaUnit = " + TxtPrecVtaUnit.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "SKU", TxtSKU.Text);
                }
            }

            baseDatos.seleccionarValoresBaseDatos(DataGridProductos, nombreTabla, "*", "");

            TxtSKU.Text = "";
            TxtDescripcion.Text = "";
            TxtUnidInventario.Text = "";
            TxtCostUnitario.Text = "";
            TxtImpuestos.Text = "";
            TxtPrecVtaUnit.Text = "";
        }

        private void DataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto vtanaEliminarProducto = new EliminarProducto();
            vtanaEliminarProducto.Show();
            Hide();
        }
    }
}
