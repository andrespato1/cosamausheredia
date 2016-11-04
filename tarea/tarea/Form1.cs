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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEviarCorreo_Click(object sender, EventArgs e)
        {
            CorreoElectronico a = new CorreoElectronico();
            a.enviarFacturacionPorCorreoElectronico("TrabajosUniversitariosTEC@gmail.com", "C:\\Users\\andres\\Desktop\\JorgeMoraComuTecnica.pdf");
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            SeleccionDeReportes Reportar = new SeleccionDeReportes();
            Reportar.Show();
            this.Close();

            
        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {

        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            VentanaPersonal vtnPersonal = new VentanaPersonal();
            vtnPersonal.Show();
            Hide();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            VentanaClientes vtnClientes = new VentanaClientes();
            vtnClientes.Show();
            Hide();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            VentanaProductos vtnProductos = new VentanaProductos();
            vtnProductos.Show();
            Hide();
        }
    }
}
