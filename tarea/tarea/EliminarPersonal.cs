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
    public partial class EliminarPersonal : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "personal";
        public EliminarPersonal()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarPersonal, nombreTabla, "*", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtIDEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminarPersonal_Click(object sender, EventArgs e)
        {
            string queryActualizar = "update personal set puestoTrab = null";
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDEliminar.Text);
            queryActualizar = "update personal set fechaRetiro = '" + TxtFechaRetiro.Text + "'";
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDEliminar.Text);
            queryActualizar = "update personal set IDJefe = " + TxtEncargado.Text;
            baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDJefe", TxtIDEliminar.Text);

            baseDatos.seleccionarValoresBaseDatos(DataGridEliminarPersonal, nombreTabla, "*", "");
            TxtEncargado.Text = "";
            TxtIDEliminar.Text = "";
            TxtFechaRetiro.Text = "";

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            VentanaPersonal vtnPersonal = new VentanaPersonal();
            vtnPersonal.Show();
            Hide();
        }
    }
}
