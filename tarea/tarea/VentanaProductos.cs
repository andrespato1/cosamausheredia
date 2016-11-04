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
            valores = valores + TxtSKU.Text + ",'";
            valores = valores + TxtDescripcion.Text + "',";
            valores = valores + TxtUnidInventario.Text + ",";
            valores = valores + TxtCostUnitario.Text + ",";
            valores = valores + TxtImpuestos.Text + ",";
            valores = valores + TxtPrecVtaUnit.Text;

            baseDatos.agregarValoresBaseDatos(nombreTabla, valores);
            baseDatos.seleccionarValoresBaseDatos(DataGridProductos, nombreTabla, "*", "");

        }
    }
}
