namespace tarea
{
    partial class VentanaRevisarPedido
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
            this.botonAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPedidosRevisar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPedidoEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.cbDatosPedido = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sistemaDeVentasDataSet1 = new tarea.sistemaDeVentasDataSet();
            this.botonRevisar = new System.Windows.Forms.Button();
            this.tbAgregarAtributo = new System.Windows.Forms.TextBox();
            this.ayudaRevisarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidosRevisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(13, 13);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(51, 23);
            this.botonAtras.TabIndex = 0;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS";
            // 
            // dataGridPedidosRevisar
            // 
            this.dataGridPedidosRevisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidosRevisar.Location = new System.Drawing.Point(79, 40);
            this.dataGridPedidosRevisar.Name = "dataGridPedidosRevisar";
            this.dataGridPedidosRevisar.Size = new System.Drawing.Size(532, 140);
            this.dataGridPedidosRevisar.TabIndex = 2;
            this.dataGridPedidosRevisar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPedidosRevisar_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el numero de pedido ";
            // 
            // tbPedidoEditar
            // 
            this.tbPedidoEditar.Location = new System.Drawing.Point(250, 194);
            this.tbPedidoEditar.Name = "tbPedidoEditar";
            this.tbPedidoEditar.Size = new System.Drawing.Size(111, 20);
            this.tbPedidoEditar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione el dato a modificar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cambiar estado de pedido";
            // 
            // cbEstadoPedido
            // 
            this.cbEstadoPedido.FormattingEnabled = true;
            this.cbEstadoPedido.Items.AddRange(new object[] {
            "REGISTRADO",
            "REVISADO"});
            this.cbEstadoPedido.Location = new System.Drawing.Point(250, 268);
            this.cbEstadoPedido.Name = "cbEstadoPedido";
            this.cbEstadoPedido.Size = new System.Drawing.Size(111, 21);
            this.cbEstadoPedido.TabIndex = 7;
            // 
            // cbDatosPedido
            // 
            this.cbDatosPedido.FormattingEnabled = true;
            this.cbDatosPedido.Items.AddRange(new object[] {
            "numPedido",
            "codigoCliente",
            "fechaPedido",
            "fechaEstimEntrega",
            "IDPersonal"});
            this.cbDatosPedido.Location = new System.Drawing.Point(250, 244);
            this.cbDatosPedido.Name = "cbDatosPedido";
            this.cbDatosPedido.Size = new System.Drawing.Size(111, 21);
            this.cbDatosPedido.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "REVISAR PEDIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // sistemaDeVentasDataSet1
            // 
            this.sistemaDeVentasDataSet1.DataSetName = "sistemaDeVentasDataSet";
            this.sistemaDeVentasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // botonRevisar
            // 
            this.botonRevisar.Location = new System.Drawing.Point(250, 307);
            this.botonRevisar.Name = "botonRevisar";
            this.botonRevisar.Size = new System.Drawing.Size(106, 23);
            this.botonRevisar.TabIndex = 11;
            this.botonRevisar.Text = "REVISAR";
            this.botonRevisar.UseVisualStyleBackColor = true;
            // 
            // tbAgregarAtributo
            // 
            this.tbAgregarAtributo.Location = new System.Drawing.Point(400, 245);
            this.tbAgregarAtributo.Name = "tbAgregarAtributo";
            this.tbAgregarAtributo.Size = new System.Drawing.Size(111, 20);
            this.tbAgregarAtributo.TabIndex = 12;
            // 
            // ayudaRevisarPedido
            // 
            this.ayudaRevisarPedido.Location = new System.Drawing.Point(15, 307);
            this.ayudaRevisarPedido.Name = "ayudaRevisarPedido";
            this.ayudaRevisarPedido.Size = new System.Drawing.Size(77, 23);
            this.ayudaRevisarPedido.TabIndex = 13;
            this.ayudaRevisarPedido.Text = "AYUDA";
            this.ayudaRevisarPedido.UseVisualStyleBackColor = true;
            // 
            // VentanaRevisarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 354);
            this.Controls.Add(this.ayudaRevisarPedido);
            this.Controls.Add(this.tbAgregarAtributo);
            this.Controls.Add(this.botonRevisar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDatosPedido);
            this.Controls.Add(this.cbEstadoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPedidoEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPedidosRevisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonAtras);
            this.Name = "VentanaRevisarPedido";
            this.Text = "VentanaRevisarPedido";
            this.Load += new System.EventHandler(this.VentanaRevisarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidosRevisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPedidosRevisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPedidoEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEstadoPedido;
        private System.Windows.Forms.ComboBox cbDatosPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private sistemaDeVentasDataSet sistemaDeVentasDataSet1;
        private System.Windows.Forms.Button botonRevisar;
        private System.Windows.Forms.TextBox tbAgregarAtributo;
        private System.Windows.Forms.Button ayudaRevisarPedido;
    }
}