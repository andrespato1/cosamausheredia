namespace tarea
{
    partial class VentanaConfirmarPedido
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
            this.tbCodigoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonBuscarPedido = new System.Windows.Forms.Button();
            this.tbPedidoConfirmar = new System.Windows.Forms.TextBox();
            this.dataGridConfirmarPedido = new System.Windows.Forms.DataGridView();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstadoConfirmar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConfirmarPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(13, 13);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(54, 23);
            this.botonAtras.TabIndex = 0;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el codigo del cliente";
            // 
            // tbCodigoCliente
            // 
            this.tbCodigoCliente.Location = new System.Drawing.Point(213, 40);
            this.tbCodigoCliente.Name = "tbCodigoCliente";
            this.tbCodigoCliente.Size = new System.Drawing.Size(132, 20);
            this.tbCodigoCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el pedido a tramitar";
            // 
            // botonBuscarPedido
            // 
            this.botonBuscarPedido.Location = new System.Drawing.Point(369, 38);
            this.botonBuscarPedido.Name = "botonBuscarPedido";
            this.botonBuscarPedido.Size = new System.Drawing.Size(97, 23);
            this.botonBuscarPedido.TabIndex = 4;
            this.botonBuscarPedido.Text = "Buscar pedidos";
            this.botonBuscarPedido.UseVisualStyleBackColor = true;
            // 
            // tbPedidoConfirmar
            // 
            this.tbPedidoConfirmar.Location = new System.Drawing.Point(213, 71);
            this.tbPedidoConfirmar.Name = "tbPedidoConfirmar";
            this.tbPedidoConfirmar.Size = new System.Drawing.Size(132, 20);
            this.tbPedidoConfirmar.TabIndex = 5;
            // 
            // dataGridConfirmarPedido
            // 
            this.dataGridConfirmarPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConfirmarPedido.Location = new System.Drawing.Point(24, 107);
            this.dataGridConfirmarPedido.Name = "dataGridConfirmarPedido";
            this.dataGridConfirmarPedido.Size = new System.Drawing.Size(459, 135);
            this.dataGridConfirmarPedido.TabIndex = 6;
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.Location = new System.Drawing.Point(182, 302);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(127, 28);
            this.botonConfirmar.TabIndex = 7;
            this.botonConfirmar.Text = "PROCESAR";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado del pedido";
            // 
            // cbEstadoConfirmar
            // 
            this.cbEstadoConfirmar.FormattingEnabled = true;
            this.cbEstadoConfirmar.Items.AddRange(new object[] {
            "CONFIRMADO",
            "RECHAZADO",
            "REPROCESAR"});
            this.cbEstadoConfirmar.Location = new System.Drawing.Point(130, 263);
            this.cbEstadoConfirmar.Name = "cbEstadoConfirmar";
            this.cbEstadoConfirmar.Size = new System.Drawing.Size(121, 21);
            this.cbEstadoConfirmar.TabIndex = 9;
            // 
            // VentanaConfirmarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 349);
            this.Controls.Add(this.cbEstadoConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.dataGridConfirmarPedido);
            this.Controls.Add(this.tbPedidoConfirmar);
            this.Controls.Add(this.botonBuscarPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonAtras);
            this.Name = "VentanaConfirmarPedido";
            this.Text = "VentanaConfirmarPedido";
            this.Load += new System.EventHandler(this.VentanaConfirmarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConfirmarPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonBuscarPedido;
        private System.Windows.Forms.TextBox tbPedidoConfirmar;
        private System.Windows.Forms.DataGridView dataGridConfirmarPedido;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstadoConfirmar;
    }
}