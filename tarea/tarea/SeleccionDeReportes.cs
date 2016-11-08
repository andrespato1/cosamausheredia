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
                
            }
            if (SeleccionReporte.Text == "Reporte de Condiciones de Pago") {

                RCondicion.Show();
               
            }
            if (SeleccionReporte.Text == "Reporte de Catálogo de Productos") {
                RCatalogo.Show();
                
            }
            if (SeleccionReporte.Text == "Reporte de Pedidos") {
                Rpedido.Show();
                
            }
            if (SeleccionReporte.Text == "Reporte de Facturas") {
                RFactura.Show();
                
            }
            if (SeleccionReporte.Text == "Reporte de Cuentas por Cobrar") {
                RCtasXCobrar.Show();
                
            }
            if (SeleccionReporte.Text == "Reporte de Personal") {
                Rpersonal.Show();
                
            }

            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }
    }
}
