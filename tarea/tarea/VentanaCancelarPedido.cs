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
    public partial class VentanaCancelarPedido : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "pedidos";
        CorreoElectronico email = new CorreoElectronico();
        FacturaPDF pedidoPDF = new FacturaPDF();

        public VentanaCancelarPedido()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(datagridPedidosACancelar, nombreTabla, "*", "");

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonProcesarCancelo_Click(object sender, EventArgs e)
        {
            string queryActualizar = "";
            if (tbPedidoCancelar.Text != "")
            {
                queryActualizar = "update pedidos set estado = 'CANCELADO'";
                baseDatos.actualizarValoresBaseDatos(queryActualizar, "numPedido", tbPedidoCancelar.Text);
            }
            if (tbMotivoCancelo.Text != "")
            {
                queryActualizar = "update pedidos set motivoDescripcion = '" + tbMotivoCancelo.Text + "'";
                baseDatos.actualizarValoresBaseDatos(queryActualizar, "numPedido", tbPedidoCancelar.Text);
            }

            pedidoPDF.linea1 = "Estimado cliente el numero de pedido :" + tbPedidoCancelar.Text;
            pedidoPDF.linea2 = "El estado actual del pedido es: CANCELADO" ;
            pedidoPDF.crearFacturaPDF("p"+ tbPedidoCancelar.Text);
            email.enviarFacturacionPorCorreoElectronico("TrabajosUniversitariosTEC@gmail.com", "p" + tbPedidoCancelar.Text);
            baseDatos.seleccionarValoresBaseDatos(datagridPedidosACancelar, nombreTabla, "*", "");
            tbPedidoCancelar.Text = "";
            tbMotivoCancelo.Text = "";
        }
    }
}

