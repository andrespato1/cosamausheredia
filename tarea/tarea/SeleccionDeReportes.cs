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
            if (SeleccionReporte.Text == "Reporte de Clientes") {

                Rcliente.Show();
                this.Close();
            }
        }
    }
}
