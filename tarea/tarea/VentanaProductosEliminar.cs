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
    public partial class VentanaProductosEliminar : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "producto";
        public VentanaProductosEliminar()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarProducto, nombreTabla, "*", "");
        }

        private void VentanaProductosEliminar_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            baseDatos.eliminarValoresBaseDatos(nombreTabla, "SKU", TxtEliminar.Text);
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarProducto, nombreTabla, "*", "");
            TxtEliminar.Text = "";
        }
    }
}
