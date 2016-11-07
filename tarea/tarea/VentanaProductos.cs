﻿using System;
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
    public partial class VentanaProductos : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "producto";
        public VentanaProductos()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(DataGridProductos, nombreTabla, "*", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            //Valores para el insert
            string valores = "";
            valores = valores + TxtSKU.Text + ",'";
            valores = valores + TxtDescripcion.Text + "',";
            valores = valores + TxtUnidInventario.Text + ",";
            valores = valores + TxtCostUnitario.Text + ",";
            valores = valores + TxtImpuestos.Text + ",";
            valores = valores + TxtPrecVtaUnit.Text;

            baseDatos.agregarValoresBaseDatos(nombreTabla, valores);
            baseDatos.seleccionarValoresBaseDatos(DataGridProductos, nombreTabla, "*", "");

        }

        private void VentanaProductos_Load(object sender, EventArgs e)
        {

        }

        private void BtnBusquedaProductos_Click(object sender, EventArgs e)
        {
            string atributo = CBAtributosProductos.Text;
            string aBuscar = TxtBusquedaProductos.Text;
            switch (atributo)
            {
                case "SKU":
                    atributo = "SKU";
                    aBuscar = "'" + TxtBusquedaProductos.Text;
                    break;
                case "Descripcion":
                    atributo = "descripcion";
                    aBuscar = "'" + TxtBusquedaProductos.Text ;
                    break;
                case "Unidades en Inventario":
                    atributo = "unidEnInventario";
                    aBuscar = "'" + TxtBusquedaProductos.Text;
                    break;
                case "Costo unitario":
                    atributo = "costoUnit";
                    aBuscar = "'" + TxtBusquedaProductos.Text;
                    break;
                case "Impuestos":
                    atributo = "impuesto";
                    aBuscar = "'" + TxtBusquedaProductos.Text;
                    break;
                case "Precio de venta unitario":
                    atributo = "precioVtaUnit";
                    aBuscar = "'" + TxtBusquedaProductos.Text;
                    break;
            }
            if (CheckBoxBusca.Checked == true)
            {
                baseDatos.seleccionarValoresBaseDatosTodasLasTablas(DataGridProductos, "producto", atributo, aBuscar);
            }
            else
            {
                baseDatos.seleccionarValoresBaseDatos(DataGridProductos, "producto", atributo, aBuscar);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }
    }
}
