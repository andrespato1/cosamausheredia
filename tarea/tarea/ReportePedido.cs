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
    public partial class ReportePedido : Form
    {
        public ReportePedido()
        {
            InitializeComponent();
        }

        private void ReportePedido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDeVentasDataSet4.ReportePedidos' table. You can move, or remove it, as needed.
            this.ReportePedidosTableAdapter.Fill(this.sistemaDeVentasDataSet4.ReportePedidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
