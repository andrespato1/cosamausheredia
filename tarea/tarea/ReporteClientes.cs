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
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDeVentasDataSet.ReporteCliente' table. You can move, or remove it, as needed.
            this.ReporteClienteTableAdapter.Fill(this.sistemaDeVentasDataSet.ReporteCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
