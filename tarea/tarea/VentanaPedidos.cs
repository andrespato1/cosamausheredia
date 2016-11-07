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
    }
}
