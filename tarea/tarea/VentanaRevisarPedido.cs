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
    public partial class VentanaRevisarPedido : Form
    {
        ConexionSQLVisualStudio baseDatos = new ConexionSQLVisualStudio();
        string nombreTabla = "pedidos";
        public VentanaRevisarPedido()
        {
            InitializeComponent();
            baseDatos.seleccionarValoresBaseDatos(dataGridPedidosRevisar, nombreTabla, "*", "");
            
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        private void VentanaRevisarPedido_Load(object sender, EventArgs e)
        {

        }

        private void dataGridPedidosRevisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
