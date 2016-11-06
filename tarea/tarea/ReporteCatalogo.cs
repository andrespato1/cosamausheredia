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
    public partial class ReporteCatalogo : Form
    {
        public ReporteCatalogo()
        {
            InitializeComponent();
        }

        private void ReporteCatalogo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDeVentasDataSet3.CatProducto' table. You can move, or remove it, as needed.
            this.CatProductoTableAdapter.Fill(this.sistemaDeVentasDataSet3.CatProducto);

            this.reportViewer1.RefreshReport();
        }
    }
}
