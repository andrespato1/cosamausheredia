﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEviarCorreo_Click(object sender, EventArgs e)
        {
            CorreoElectronico a = new CorreoElectronico();
            a.enviarFacturacionPorCorreoElectronico("TrabajosUniversitariosTEC@gmail.com", "C:\\Users\\andres\\Desktop\\JorgeMoraComuTecnica.pdf");
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            SeleccionDeReportes Reportar = new SeleccionDeReportes();
            Reportar.Show();
            Hide();

        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            VentanaPedidos pedidonuevo = new VentanaPedidos();
            pedidonuevo.Show();
            Hide();
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            VentanaPersonal vtnPersonal = new VentanaPersonal();
            vtnPersonal.Show();
            Hide();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            VentanaClientes vtnClientes = new VentanaClientes();
            vtnClientes.Show();
            Hide();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            VentanaProductos vtnProductos = new VentanaProductos();
            vtnProductos.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            VentanaFacturas facturas = new VentanaFacturas();
            facturas.Show();
            Hide();
        }

        private void BtnCondicionPago_Click(object sender, EventArgs e)
        {
            VentanaCondicionPago condPago = new VentanaCondicionPago();
            condPago.Show();
            Hide();
        }

        private void BtnCtaCobrar_Click(object sender, EventArgs e)
        {
            VentanaCuentaCobrar ctaCobrar = new VentanaCuentaCobrar();
            ctaCobrar.Show();
            Hide();
        }

        private void botonRegistrarPedido_Click(object sender, EventArgs e)
        {
            VentanaRevisarPedido pedidorevisar = new VentanaRevisarPedido();
            pedidorevisar.Show();
            Hide();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            VentanaCancelarPedido pedidocancelar = new VentanaCancelarPedido();
            pedidocancelar.Show();
            Hide();
        }

        private void botonConfirmarPedido_Click(object sender, EventArgs e)
        {
            VentanaConfirmarPedido pedidoconfirmar = new VentanaConfirmarPedido();
            pedidoconfirmar.Show();
            Hide();
        }

        private void ayudaVentanaPrincipal_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "manual_de_usuario_ventas.pdf");
            Process.Start(pdfPath);
        }
    }
}
