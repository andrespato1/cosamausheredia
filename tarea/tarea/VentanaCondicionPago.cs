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
        public VentanaCondicionPago()
        {
            InitializeComponent();
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
    }
}
