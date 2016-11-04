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


        }
    }
}
