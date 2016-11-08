namespace tarea
{
    partial class VentanaFacturarPedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAtrasFacturarPedido = new System.Windows.Forms.Button();
            this.dgPedidoSeleccionado = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgProductosDelPedido = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBFacturarTodoPedido = new System.Windows.Forms.CheckBox();
            this.btFacturarPedido = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNumFactura = new System.Windows.Forms.TextBox();
            this.tbFechaFact = new System.Windows.Forms.TextBox();
            this.tbFechaVencim = new System.Windows.Forms.TextBox();
            this.tbDirEntrega = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCantProductos = new System.Windows.Forms.TextBox();
            this.ayudaFacturarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosDelPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el codigo de producto a facturar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btAtrasFacturarPedido
            // 
            this.btAtrasFacturarPedido.Location = new System.Drawing.Point(12, 8);
            this.btAtrasFacturarPedido.Name = "btAtrasFacturarPedido";
            this.btAtrasFacturarPedido.Size = new System.Drawing.Size(59, 23);
            this.btAtrasFacturarPedido.TabIndex = 2;
            this.btAtrasFacturarPedido.Text = "Atras";
            this.btAtrasFacturarPedido.UseVisualStyleBackColor = true;
            this.btAtrasFacturarPedido.Click += new System.EventHandler(this.btAtrasFacturarPedido_Click);
            // 
            // dgPedidoSeleccionado
            // 
            this.dgPedidoSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoSeleccionado.Location = new System.Drawing.Point(23, 179);
            this.dgPedidoSeleccionado.Name = "dgPedidoSeleccionado";
            this.dgPedidoSeleccionado.Size = new System.Drawing.Size(278, 29);
            this.dgPedidoSeleccionado.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar producto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgProductosDelPedido
            // 
            this.dgProductosDelPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosDelPedido.Location = new System.Drawing.Point(23, 227);
            this.dgProductosDelPedido.Name = "dgProductosDelPedido";
            this.dgProductosDelPedido.Size = new System.Drawing.Size(278, 124);
            this.dgProductosDelPedido.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(319, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 153);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datos del pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Productos del pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Productos a facturar";
            // 
            // checkBFacturarTodoPedido
            // 
            this.checkBFacturarTodoPedido.AutoSize = true;
            this.checkBFacturarTodoPedido.Location = new System.Drawing.Point(23, 73);
            this.checkBFacturarTodoPedido.Name = "checkBFacturarTodoPedido";
            this.checkBFacturarTodoPedido.Size = new System.Drawing.Size(213, 17);
            this.checkBFacturarTodoPedido.TabIndex = 10;
            this.checkBFacturarTodoPedido.Text = "Facturar todos lod productos del pedido";
            this.checkBFacturarTodoPedido.UseVisualStyleBackColor = true;
            // 
            // btFacturarPedido
            // 
            this.btFacturarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacturarPedido.Location = new System.Drawing.Point(411, 328);
            this.btFacturarPedido.Name = "btFacturarPedido";
            this.btFacturarPedido.Size = new System.Drawing.Size(82, 23);
            this.btFacturarPedido.TabIndex = 11;
            this.btFacturarPedido.Text = "FACTURAR";
            this.btFacturarPedido.UseVisualStyleBackColor = true;
            this.btFacturarPedido.Click += new System.EventHandler(this.btFacturarPedido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero de Factura";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Direccion de Entrega";
            // 
            // tbNumFactura
            // 
            this.tbNumFactura.Location = new System.Drawing.Point(215, 9);
            this.tbNumFactura.Name = "tbNumFactura";
            this.tbNumFactura.Size = new System.Drawing.Size(73, 20);
            this.tbNumFactura.TabIndex = 16;
            this.tbNumFactura.TextChanged += new System.EventHandler(this.tbNumFactura_TextChanged);
            // 
            // tbFechaFact
            // 
            this.tbFechaFact.Location = new System.Drawing.Point(215, 37);
            this.tbFechaFact.Name = "tbFechaFact";
            this.tbFechaFact.Size = new System.Drawing.Size(73, 20);
            this.tbFechaFact.TabIndex = 17;
            // 
            // tbFechaVencim
            // 
            this.tbFechaVencim.Location = new System.Drawing.Point(449, 9);
            this.tbFechaVencim.Name = "tbFechaVencim";
            this.tbFechaVencim.Size = new System.Drawing.Size(113, 20);
            this.tbFechaVencim.TabIndex = 18;
            // 
            // tbDirEntrega
            // 
            this.tbDirEntrega.Location = new System.Drawing.Point(449, 37);
            this.tbDirEntrega.Name = "tbDirEntrega";
            this.tbDirEntrega.Size = new System.Drawing.Size(113, 20);
            this.tbDirEntrega.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad de productos facturados";
            // 
            // tbCantProductos
            // 
            this.tbCantProductos.Location = new System.Drawing.Point(489, 73);
            this.tbCantProductos.Name = "tbCantProductos";
            this.tbCantProductos.Size = new System.Drawing.Size(73, 20);
            this.tbCantProductos.TabIndex = 21;
            // 
            // ayudaFacturarPedido
            // 
            this.ayudaFacturarPedido.Location = new System.Drawing.Point(23, 367);
            this.ayudaFacturarPedido.Name = "ayudaFacturarPedido";
            this.ayudaFacturarPedido.Size = new System.Drawing.Size(59, 23);
            this.ayudaFacturarPedido.TabIndex = 22;
            this.ayudaFacturarPedido.Text = "AYUDA";
            this.ayudaFacturarPedido.UseVisualStyleBackColor = true;
            // 
            // VentanaFacturarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 402);
            this.Controls.Add(this.ayudaFacturarPedido);
            this.Controls.Add(this.tbCantProductos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDirEntrega);
            this.Controls.Add(this.tbFechaVencim);
            this.Controls.Add(this.tbFechaFact);
            this.Controls.Add(this.tbNumFactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btFacturarPedido);
            this.Controls.Add(this.checkBFacturarTodoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgProductosDelPedido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgPedidoSeleccionado);
            this.Controls.Add(this.btAtrasFacturarPedido);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "VentanaFacturarPedidos";
            this.Text = "VentanaFacturarPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosDelPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btAtrasFacturarPedido;
        private System.Windows.Forms.DataGridView dgPedidoSeleccionado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgProductosDelPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBFacturarTodoPedido;
        private System.Windows.Forms.Button btFacturarPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNumFactura;
        private System.Windows.Forms.TextBox tbFechaFact;
        private System.Windows.Forms.TextBox tbFechaVencim;
        private System.Windows.Forms.TextBox tbDirEntrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCantProductos;
        private System.Windows.Forms.Button ayudaFacturarPedido;
    }
}