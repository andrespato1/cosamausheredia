namespace tarea
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnPedido = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnCondicionPago = new System.Windows.Forms.Button();
            this.BtnCtaCobrar = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.botonRegistrarPedido = new System.Windows.Forms.Button();
            this.botonConfirmarPedido = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProducto
            // 
            this.BtnProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.BtnProducto.Location = new System.Drawing.Point(386, 218);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 0;
            this.BtnProducto.Text = "Productos";
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(34, 220);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Clientes";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Location = new System.Drawing.Point(386, 160);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(75, 23);
            this.BtnPersonal.TabIndex = 2;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnPedido
            // 
            this.BtnPedido.Location = new System.Drawing.Point(34, 27);
            this.BtnPedido.Name = "BtnPedido";
            this.BtnPedido.Size = new System.Drawing.Size(75, 52);
            this.BtnPedido.TabIndex = 4;
            this.BtnPedido.Text = "Registrar nuevo pedido";
            this.BtnPedido.UseVisualStyleBackColor = true;
            this.BtnPedido.Click += new System.EventHandler(this.BtnPedido_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(386, 27);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(75, 42);
            this.BtnReporte.TabIndex = 5;
            this.BtnReporte.Text = "Generar Reportes";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnCondicionPago
            // 
            this.BtnCondicionPago.Location = new System.Drawing.Point(386, 75);
            this.BtnCondicionPago.Name = "BtnCondicionPago";
            this.BtnCondicionPago.Size = new System.Drawing.Size(75, 39);
            this.BtnCondicionPago.TabIndex = 7;
            this.BtnCondicionPago.Text = "Condicion de pago";
            this.BtnCondicionPago.UseVisualStyleBackColor = true;
            this.BtnCondicionPago.Click += new System.EventHandler(this.BtnCondicionPago_Click);
            // 
            // BtnCtaCobrar
            // 
            this.BtnCtaCobrar.Location = new System.Drawing.Point(386, 120);
            this.BtnCtaCobrar.Name = "BtnCtaCobrar";
            this.BtnCtaCobrar.Size = new System.Drawing.Size(75, 34);
            this.BtnCtaCobrar.TabIndex = 8;
            this.BtnCtaCobrar.Text = "Cuentas por cobrar";
            this.BtnCtaCobrar.UseVisualStyleBackColor = true;
            this.BtnCtaCobrar.Click += new System.EventHandler(this.BtnCtaCobrar_Click);
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.Location = new System.Drawing.Point(386, 189);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(75, 23);
            this.BtnFacturas.TabIndex = 10;
            this.BtnFacturas.Text = "Facturas";
            this.BtnFacturas.UseVisualStyleBackColor = true;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // botonRegistrarPedido
            // 
            this.botonRegistrarPedido.Location = new System.Drawing.Point(34, 85);
            this.botonRegistrarPedido.Name = "botonRegistrarPedido";
            this.botonRegistrarPedido.Size = new System.Drawing.Size(75, 39);
            this.botonRegistrarPedido.TabIndex = 11;
            this.botonRegistrarPedido.Text = "Revisar pedido";
            this.botonRegistrarPedido.UseVisualStyleBackColor = true;
            this.botonRegistrarPedido.Click += new System.EventHandler(this.botonRegistrarPedido_Click);
            // 
            // botonConfirmarPedido
            // 
            this.botonConfirmarPedido.Location = new System.Drawing.Point(34, 175);
            this.botonConfirmarPedido.Name = "botonConfirmarPedido";
            this.botonConfirmarPedido.Size = new System.Drawing.Size(75, 39);
            this.botonConfirmarPedido.TabIndex = 12;
            this.botonConfirmarPedido.Text = "Confirmar pedido";
            this.botonConfirmarPedido.UseVisualStyleBackColor = true;
            this.botonConfirmarPedido.Click += new System.EventHandler(this.botonConfirmarPedido_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(34, 130);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 39);
            this.botonCancelar.TabIndex = 13;
            this.botonCancelar.Text = "Cancelar pedido";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 287);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonConfirmarPedido);
            this.Controls.Add(this.botonRegistrarPedido);
            this.Controls.Add(this.BtnFacturas);
            this.Controls.Add(this.BtnCtaCobrar);
            this.Controls.Add(this.BtnCondicionPago);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnPedido);
            this.Controls.Add(this.BtnPersonal);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.BtnProducto);
            this.Name = "Form1";
            this.Text = "Venta Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnPersonal;
        private System.Windows.Forms.Button BtnPedido;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnCondicionPago;
        private System.Windows.Forms.Button BtnCtaCobrar;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Button botonRegistrarPedido;
        private System.Windows.Forms.Button botonConfirmarPedido;
        private System.Windows.Forms.Button botonCancelar;
    }
}

