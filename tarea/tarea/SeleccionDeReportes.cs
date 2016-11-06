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
    public partial class SeleccionDeReportes : Form
    {
        public SeleccionDeReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { ReporteClientes Rcliente = new ReporteClientes();
            ReporteCondicionesDePago RCondicion = new ReporteCondicionesDePago();
            ReporteCatalogo RCatalogo = new ReporteCatalogo();
            ReportePedido Rpedido = new ReportePedido();
            ReporteFacturas RFactura = new ReporteFacturas();
            ReporteCtasXCobrar RCtasXCobrar = new ReporteCtasXCobrar();
            ReportePersonal Rpersonal = new ReportePersonal();
            
            if (SeleccionReporte.Text == "Reporte de Clientes")
            {

                Rcliente.Show();
                this.Close();
            }
            if (SeleccionReporte.Text == "Reporte de Condiciones de Pago") {

                RCondicion.Show();
                this.Close();
            }
            if (SeleccionReporte.Text == "Reporte de Catálogo de Productos") {
                RCatalogo.Show();
                this.Close();
            }
            if (SeleccionReporte.Text == "Reporte de Pedidos") {
                Rpedido.Show();
                this.Close();
            }
            if (SeleccionReporte.Text == "Reporte de Facturas") {
                RFactura.Show();
                this.Close();
            }
            if (SeleccionReporte.Text == "Reporte de Cuentas por Cobrar") {
                RCtasXCobrar.Show();
                this.Close();
            }
            if (SeleccionReporte.Text == "Reporte de Personal") {
                Rpersonal.Show();
                this.Close();
            }

            
        }
    }
}
