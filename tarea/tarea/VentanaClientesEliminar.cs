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
    public partial class VentanaClientesEliminar : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "cliente";
        public VentanaClientesEliminar()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarCliente, nombreTabla, "*", "");
        }

        private void VentanaClientesEliminar_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            baseDatos.eliminarValoresBaseDatos(nombreTabla, "codigoCliente", TxtEliminar.Text);
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarCliente, nombreTabla, "*", "");
            TxtEliminar.Text = "";
        }
    }
}
