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
    public partial class VentanaPersonalEliminar : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "personal";
        DateTime esteDia = DateTime.Today;

        public VentanaPersonalEliminar()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarPersonal, nombreTabla, "*", "");
        }

        private void VentanaPersonalEliminar_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            string queryActualizar = "update personal set puestoTrab = null";
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtEliminar.Text);
            queryActualizar = "update personal set fechaRetiro = '" + esteDia.ToString("yyyy-MM-dd") + "'";
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtEliminar.Text);
            queryActualizar = "update personal set IDJefe = " + TxtIDJefe.Text;
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDJefe", TxtEliminar.Text);
            
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarPersonal, nombreTabla, "*", "");
            TxtEliminar.Text = "";
            TxtIDJefe.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
