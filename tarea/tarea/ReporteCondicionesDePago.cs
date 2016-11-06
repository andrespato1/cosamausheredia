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
    public partial class ReporteCondicionesDePago : Form
    {
        public ReporteCondicionesDePago()
        {
            InitializeComponent();
        }

        private void ReporteCondicionesDePago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDeVentasDataSet2.Condpago' table. You can move, or remove it, as needed.
            this.CondpagoTableAdapter.Fill(this.sistemaDeVentasDataSet2.Condpago);

            this.reportViewer1.RefreshReport();
        }
    }
}
