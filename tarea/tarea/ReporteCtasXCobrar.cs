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
    public partial class ReporteCtasXCobrar : Form
    {
        public ReporteCtasXCobrar()
        {
            InitializeComponent();
        }

        private void ReporteCtasXCobrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDeVentasDataSet6.ReporteCuentasXCobrar' table. You can move, or remove it, as needed.
            this.ReporteCuentasXCobrarTableAdapter.Fill(this.sistemaDeVentasDataSet6.ReporteCuentasXCobrar);

            this.reportViewer1.RefreshReport();
        }
    }
}
