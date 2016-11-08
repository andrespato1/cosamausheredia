namespace tarea
{
    partial class VentanaPedidos
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
            this.DataGridPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnumPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFechaPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFechaEntregaP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIDEjecVta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSKU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCantidadProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPrecioUnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbImpuesto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.botonAgregarProducto = new System.Windows.Forms.Button();
            this.botonRegistrarPedido = new System.Windows.Forms.Button();
            this.dataGridProdPedido = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.botonAtras = new System.Windows.Forms.Button();
            this.ayudaRegPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridPedidos
            // 
            this.DataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPedidos.Location = new System.Drawing.Point(12, 150);
            this.DataGridPedidos.Name = "DataGridPedidos";
            this.DataGridPedidos.Size = new System.Drawing.Size(312, 88);
            this.DataGridPedidos.TabIndex = 0;
            this.DataGridPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPedidos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de pedido";
            // 
            // tbnumPedido
            // 
            this.tbnumPedido.Location = new System.Drawing.Point(192, 15);
            this.tbnumPedido.Name = "tbnumPedido";
            this.tbnumPedido.Size = new System.Drawing.Size(98, 20);
            this.tbnumPedido.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo cliente";
            // 
            // tbCodigoCliente
            // 
            this.tbCodigoCliente.Location = new System.Drawing.Point(192, 48);
            this.tbCodigoCliente.Name = "tbCodigoCliente";
            this.tbCodigoCliente.Size = new System.Drawing.Size(98, 20);
            this.tbCodigoCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de pedido";
            // 
            // tbFechaPedido
            // 
            this.tbFechaPedido.Location = new System.Drawing.Point(401, 12);
            this.tbFechaPedido.Name = "tbFechaPedido";
            this.tbFechaPedido.Size = new System.Drawing.Size(121, 20);
            this.tbFechaPedido.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de entrega";
            // 
            // tbFechaEntregaP
            // 
            this.tbFechaEntregaP.Location = new System.Drawing.Point(401, 48);
            this.tbFechaEntregaP.Name = "tbFechaEntregaP";
            this.tbFechaEntregaP.Size = new System.Drawing.Size(121, 20);
            this.tbFechaEntregaP.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo Ejecutivo Venta";
            // 
            // tbIDEjecVta
            // 
            this.tbIDEjecVta.Location = new System.Drawing.Point(191, 81);
            this.tbIDEjecVta.Name = "tbIDEjecVta";
            this.tbIDEjecVta.Size = new System.Drawing.Size(98, 20);
            this.tbIDEjecVta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SKU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "PRODUCTOS DISPONIBLES";
            // 
            // tbSKU
            // 
            this.tbSKU.Location = new System.Drawing.Point(413, 170);
            this.tbSKU.Name = "tbSKU";
            this.tbSKU.Size = new System.Drawing.Size(72, 20);
            this.tbSKU.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cantidad";
            // 
            // tbCantidadProducto
            // 
            this.tbCantidadProducto.Location = new System.Drawing.Point(566, 167);
            this.tbCantidadProducto.Name = "tbCantidadProducto";
            this.tbCantidadProducto.Size = new System.Drawing.Size(72, 20);
            this.tbCantidadProducto.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "PrecioUnitario";
            // 
            // tbPrecioUnit
            // 
            this.tbPrecioUnit.Location = new System.Drawing.Point(413, 201);
            this.tbPrecioUnit.Name = "tbPrecioUnit";
            this.tbPrecioUnit.Size = new System.Drawing.Size(72, 20);
            this.tbPrecioUnit.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Descuento";
            // 
            // tbDescuento
            // 
            this.tbDescuento.Location = new System.Drawing.Point(566, 201);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.Size = new System.Drawing.Size(72, 20);
            this.tbDescuento.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Impuesto ";
            // 
            // tbImpuesto
            // 
            this.tbImpuesto.Location = new System.Drawing.Point(413, 238);
            this.tbImpuesto.Name = "tbImpuesto";
            this.tbImpuesto.Size = new System.Drawing.Size(72, 20);
            this.tbImpuesto.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(501, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Precio total";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(567, 238);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(72, 20);
            this.tb.TabIndex = 30;
            // 
            // botonAgregarProducto
            // 
            this.botonAgregarProducto.Location = new System.Drawing.Point(458, 274);
            this.botonAgregarProducto.Name = "botonAgregarProducto";
            this.botonAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarProducto.TabIndex = 31;
            this.botonAgregarProducto.Text = "Agregar producto";
            this.botonAgregarProducto.UseVisualStyleBackColor = true;
            this.botonAgregarProducto.Click += new System.EventHandler(this.botonAgregarProducto_Click);
            // 
            // botonRegistrarPedido
            // 
            this.botonRegistrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarPedido.Location = new System.Drawing.Point(391, 333);
            this.botonRegistrarPedido.Name = "botonRegistrarPedido";
            this.botonRegistrarPedido.Size = new System.Drawing.Size(247, 36);
            this.botonRegistrarPedido.TabIndex = 32;
            this.botonRegistrarPedido.Text = "REGISTRAR PEDIDO";
            this.botonRegistrarPedido.UseVisualStyleBackColor = true;
            // 
            // dataGridProdPedido
            // 
            this.dataGridProdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdPedido.Location = new System.Drawing.Point(15, 281);
            this.dataGridProdPedido.Name = "dataGridProdPedido";
            this.dataGridProdPedido.Size = new System.Drawing.Size(312, 88);
            this.dataGridProdPedido.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Productos pedidos";
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(9, 10);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(52, 23);
            this.botonAtras.TabIndex = 36;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // ayudaRegPedido
            // 
            this.ayudaRegPedido.Location = new System.Drawing.Point(563, 12);
            this.ayudaRegPedido.Name = "ayudaRegPedido";
            this.ayudaRegPedido.Size = new System.Drawing.Size(75, 23);
            this.ayudaRegPedido.TabIndex = 37;
            this.ayudaRegPedido.Text = "AYUDA";
            this.ayudaRegPedido.UseVisualStyleBackColor = true;
            this.ayudaRegPedido.Click += new System.EventHandler(this.ayudaRegPedido_Click);
            // 
            // VentanaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 381);
            this.Controls.Add(this.ayudaRegPedido);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridProdPedido);
            this.Controls.Add(this.botonRegistrarPedido);
            this.Controls.Add(this.botonAgregarProducto);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbImpuesto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDescuento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbPrecioUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbCantidadProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSKU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIDEjecVta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFechaEntregaP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFechaPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCodigoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnumPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridPedidos);
            this.Name = "VentanaPedidos";
            this.Text = "VentanaPedidos";
            this.Load += new System.EventHandler(this.VentanaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnumPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFechaPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFechaEntregaP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIDEjecVta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSKU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCantidadProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPrecioUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbImpuesto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button botonAgregarProducto;
        private System.Windows.Forms.Button botonRegistrarPedido;
        private System.Windows.Forms.DataGridView dataGridProdPedido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button ayudaRegPedido;
    }
}