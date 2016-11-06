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
    public partial class ReportePersonal : Form
    {
        public ReportePersonal()
        {
            InitializeComponent();
        }

        private void ReportePersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaDeVentasDataSet8.ReportePersonal' table. You can move, or remove it, as needed.
            this.ReportePersonalTableAdapter.Fill(this.sistemaDeVentasDataSet8.ReportePersonal);

            this.reportViewer1.RefreshReport();
        }
    }
}
