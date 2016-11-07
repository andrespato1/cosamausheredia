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
    public partial class EliminarProducto : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "producto";
        public EliminarProducto()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarProducto, nombreTabla, "*", "");
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            baseDatos.eliminarValoresBaseDatos(nombreTabla, "SKU", TxtEliminarProducto.Text);
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarProducto, nombreTabla, "*", "");
            TxtEliminarProducto.Text = "";
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            VentanaProductos vtnProductos = new VentanaProductos();
            vtnProductos.Show();
            Hide();
        }
    }
}
