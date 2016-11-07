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
    public partial class VentanaPersonal : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "personal";
        public VentanaPersonal()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridPersonal, nombreTabla, "*", "");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Valores para el insert
            string valores = "";
            valores = valores + TxtIDPersonal.Text + ",'";
            valores = valores + TxtPuesto.Text + "','";
            valores = valores + TxtNombre.Text + "','";
            valores = valores + TxtApellido1.Text + "','";
            valores = valores + TxtApellido2.Text + "','";
            valores = valores + TxtNacimiento.Text + "',";
            valores = valores + TxtTelefono.Text + ",'";
            valores = valores + TxtResidencia.Text + "','";
            valores = valores + TxtEmail.Text + "',";
            valores = valores + TxtIDJefe.Text + ",'";
            valores = valores + TxtFechaIngreso.Text + "','";
            valores = valores + TxtFechaRetiro.Text + "'";

            baseDatos.agregarValoresBaseDatos(nombreTabla, valores);
            baseDatos.seleccionarValoresBaseDatos(DataGridPersonal, nombreTabla, "*", "");

            TxtIDPersonal.Text = "";
            TxtPuesto.Text = "";
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtNacimiento.Text = "";
            TxtTelefono.Text = "";
            TxtResidencia.Text = "";
            TxtEmail.Text = "";
            TxtIDJefe.Text = "";
            TxtFechaIngreso.Text = "";
            TxtFechaRetiro.Text = "";
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void VentanaPersonal_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscarPersonal_Click(object sender, EventArgs e)
        {
            if (checkBusquedaPersonal.Checked == true)
            {
                baseDatos.seleccionarValoresBaseDatosTodasLasTablas(DataGridPersonal, "personal", CBBuscarPersonal.Text, "like '" + TxtBuscarPersonal.Text + "%'");
            }
            else
            {
                baseDatos.seleccionarValoresBaseDatos(DataGridPersonal, "personal", CBBuscarPersonal.Text, "like '" + TxtBuscarPersonal.Text + "%'");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string queryActualizar = "";
            if (TxtIDPersonal.Text != "")
            {
                if (TxtPuesto.Text != "")
                {
                    queryActualizar = "update personal set puestoTrab = '" + TxtPuesto.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtNombre.Text != "")
                {
                    queryActualizar = "update personal set nombre = '" + TxtNombre.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtApellido1.Text != "")
                {
                    queryActualizar = "update personal set apellido1 = '" + TxtApellido1.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtApellido2.Text != "")
                {
                    queryActualizar = "update personal set apellido2 = '" + TxtApellido2.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtNacimiento.Text != "")
                {
                    queryActualizar = "update personal set fechaNacim = " + TxtNacimiento.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtTelefono.Text != "")
                {
                    queryActualizar = "update personal set telefono = " + TxtTelefono.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtResidencia.Text != "")
                {
                    queryActualizar = "update personal set lugarResid = '" + TxtResidencia.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtEmail.Text != "")
                {
                    queryActualizar = "update personal set email = " + TxtEmail.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtIDJefe.Text != "")
                {
                    queryActualizar = "update personal set IDJefe = " + TxtIDJefe.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtFechaIngreso.Text != "")
                {
                    queryActualizar = "update personal set fechaIngreso = '" + TxtFechaIngreso.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtFechaIngreso.Text != "")
                {
                    queryActualizar = "update personal set fechaIngreso = '" + TxtFechaIngreso.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
                if (TxtFechaRetiro.Text != "")
                {
                    queryActualizar = "update personal set fechaRetiro = '" + TxtFechaRetiro.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "IDPersonal", TxtIDPersonal.Text);
                }
            }

            baseDatos.seleccionarValoresBaseDatos(DataGridPersonal, nombreTabla, "*", "");

            TxtIDPersonal.Text = "";
            TxtPuesto.Text = "";
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtNacimiento.Text = "";
            TxtTelefono.Text = "";
            TxtResidencia.Text = "";
            TxtEmail.Text = "";
            TxtIDJefe.Text = "";
            TxtFechaIngreso.Text = "";
            TxtFechaRetiro.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPersonal vtanaEliminarPersonal = new EliminarPersonal();
            vtanaEliminarPersonal.Show();
            Hide();
        }
    }
}
