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
    public partial class VentanaConfirmarPedido : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "pedidos";

        public VentanaConfirmarPedido()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(dataGridConfirmarPedido, nombreTabla, "*", "");
        }

        private void VentanaConfirmarPedido_Load(object sender, EventArgs e)
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
