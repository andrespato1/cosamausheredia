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
    public partial class VentanaRevisarPedido : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "pedidos";
        CorreoElectronico correo = new CorreoElectronico();
        FacturaPDF pdf = new FacturaPDF();
        public VentanaRevisarPedido()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatosTodasLasTablas(dataGridPedidosRevisar, nombreTabla, "estado", " = 'REGISTRADO'");

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void VentanaRevisarPedido_Load(object sender, EventArgs e)
        {

        }

        private void dataGridPedidosRevisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botonRevisar_Click(object sender, EventArgs e)
        {
            string queryActualizar = "";
            if (tbPedidoEditar.Text != "")
            {
                if (cbEstadoPedido.Text != "")
                {
                    queryActualizar = "update pedidos set estado = '" + cbEstadoPedido.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "numPedido", tbPedidoEditar.Text);
                }
                if (cbDatosPedido.Text == "fechaPedido")
                {
                    queryActualizar = "update pedidos set fechaPedido = '" + tbAgregarAtributo.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "numPedido", tbPedidoEditar.Text);
                }
                if (cbDatosPedido.Text == "fechaEstimEntrega")
                {
                    queryActualizar = "update pedidos set fechaPedido = '" + tbAgregarAtributo.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "numPedido", tbPedidoEditar.Text);

                }
            }
            pdf.linea1 = "Estimado cliente el numero de factura :"+ tbPedidoEditar.Text;
            pdf.linea2 = "El estado actual del pedido es: " + cbEstadoPedido.Text;
            pdf.crearFacturaPDF(tbPedidoEditar.Text);
            correo.enviarFacturacionPorCorreoElectronico("TrabajosUniversitariosTEC@gmail.com", tbPedidoEditar.Text);
            baseDatos.seleccionarValoresBaseDatosTodasLasTablas(dataGridPedidosRevisar, nombreTabla, "estado", " = 'REGISTRADO'");
            tbAgregarAtributo.Text = "";
            tbPedidoEditar.Text = "";
            cbDatosPedido.Text = "";
            cbEstadoPedido.Text = "";
        }
    }
}
