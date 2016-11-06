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
    public partial class ReporteFacturas : Form
    {
        public ReporteFacturas()
        {
            InitializeComponent();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDeVentasDataSet5.ReporteFacturas' table. You can move, or remove it, as needed.
            this.ReporteFacturasTableAdapter.Fill(this.sistemaDeVentasDataSet5.ReporteFacturas);

            this.reportViewer1.RefreshReport();
        }
    }
}
