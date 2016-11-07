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
    public partial class EliminarCliente : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "cliente";
        public EliminarCliente()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarCliente, nombreTabla, "*", "");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            string queryActualizar = "update cliente set fechaInicioR = null";
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtEliminarCliente.Text);
            queryActualizar = "update cliente set limiteCred = null";
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtEliminarCliente.Text);

            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarCliente, nombreTabla, "*", "");
            TxtEliminarCliente.Text = "";
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            VentanaClientes vtnaClienta = new VentanaClientes();
            vtnaClienta.Show();
            Hide();
        }
    }
}
