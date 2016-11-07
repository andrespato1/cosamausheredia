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
    public partial class VentanaClientes : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "cliente";
        public VentanaClientes()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridClientes, nombreTabla, "*", "");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Valores para el insert
            string valores = "";
            valores = valores + TxtCodigoCliente.Text + ",'";
            valores = valores + TxtNombre.Text + "','";
            valores = valores + TxtDireccion.Text + "','";
            valores = valores + TxtCodigoPostal.Text + "','";
            valores = valores + TxtUbicacion.Text + "',";
            valores = valores + TxtTelefono.Text + ",'";
            valores = valores + TxtEmail.Text + "','";
            valores = valores + TxtFecha.Text + "',";
            valores = valores + TxtCredito.Text + ",'";
            valores = valores + TxtEntrega.Text + "','";
            valores = valores + TxtCondicion.Text + "'";

            baseDatos.agregarValoresBaseDatos(nombreTabla, valores);
            baseDatos.seleccionarValoresBaseDatos(DataGridClientes, nombreTabla, "*", "");

            TxtCodigoCliente.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtCodigoPostal.Text = "";
            TxtUbicacion.Text = "";
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
            TxtFecha.Text = "";
            TxtCredito.Text = "";
            TxtEntrega.Text = "";
            TxtCondicion.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void VentanaClientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string queryActualizar = "";
            if (TxtCodigoCliente.Text != "")
            {
                if (TxtNombre.Text != "")
                {
                    queryActualizar = "update cliente set nombre = '" + TxtNombre.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtDireccion.Text != "")
                {
                    queryActualizar = "update cliente set direccion = '" + TxtDireccion.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtCodigoPostal.Text != "")
                {
                    queryActualizar = "update cliente set codigoPostal = '" + TxtCodigoPostal.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtUbicacion.Text != "")
                {
                    queryActualizar = "update cliente set paisUbic = '" + TxtUbicacion.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtTelefono.Text != "")
                {
                    queryActualizar = "update cliente set telefono = " + TxtTelefono.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtEmail.Text != "")
                {
                    queryActualizar = "update cliente set email = '" + TxtEmail.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtFecha.Text != "")
                {
                    queryActualizar = "update cliente set fechaInicioR = '" + TxtFecha.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtCredito.Text != "")
                {
                    queryActualizar = "update cliente set limiteCred = " + TxtCredito.Text;
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtEntrega.Text != "")
                {
                    queryActualizar = "update cliente set dirEntregaProd = '" + TxtEntrega.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
                if (TxtFecha.Text != "")
                {
                    queryActualizar = "update cliente set fechaInicioR = '" + TxtFecha.Text + "'";
                    baseDatos.actualizarValoresBaseDatos(queryActualizar, "codigoCliente", TxtCodigoCliente.Text);
                }
            }

            baseDatos.seleccionarValoresBaseDatos(DataGridClientes, nombreTabla, "*", "");

            TxtCodigoCliente.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtCodigoPostal.Text = "";
            TxtUbicacion.Text = "";
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
            TxtFecha.Text = "";
            TxtCredito.Text = "";
            TxtEntrega.Text = "";
            TxtCondicion.Text = "";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (checkBusquedaCliente.Checked == true)
            {
                baseDatos.seleccionarValoresBaseDatosTodasLasTablas(DataGridClientes, "cliente", CBBuscarCliente.Text, "like '" + TxtBusquedaCliente.Text + "%'");
            }
            else
            {
                baseDatos.seleccionarValoresBaseDatos(DataGridClientes, "cliente", CBBuscarCliente.Text, "like '" + TxtBusquedaCliente.Text + "%'");
            }
            TxtBusquedaCliente.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente vtnaEliminar = new tarea.EliminarCliente();
            vtnaEliminar.Show();
            Hide();
        }
    }
}
