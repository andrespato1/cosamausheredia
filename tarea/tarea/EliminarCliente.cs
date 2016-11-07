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
            baseDatos.eliminarValoresBaseDatos(nombreTabla, "codigoCliente", TxtEliminarCliente.Text);
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarCliente, nombreTabla, "*", "");
            TxtEliminarCliente.Text = "";
        }
    }
}
