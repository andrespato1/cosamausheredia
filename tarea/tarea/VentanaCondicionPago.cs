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
    public partial class VentanaCondicionPago : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "condicionPago";

        public VentanaCondicionPago()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(dataGridCondiciones, nombreTabla, "*", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void VentanaCondicionPago_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Valores para el insert
            string valores = "";
            valores = "'"+valores + nombreNuevaCondicion.Text+ "'";

            baseDatos.agregarValoresBaseDatos(nombreTabla, valores);
            baseDatos.seleccionarValoresBaseDatos(dataGridCondiciones, nombreTabla, "*", "");

            nombreNuevaCondicion.Text = "";
        }

        private void nombreNuevaCondicion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
