namespace tarea
{
    partial class VentanaCancelarPedido
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
            this.PEDIDOS = new System.Windows.Forms.Label();
            this.datagridPedidosACancelar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPedidoCancelar = new System.Windows.Forms.TextBox();
            this.tbMotivoCancelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonProcesarCancelo = new System.Windows.Forms.Button();
            this.ayudaPedidosCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosACancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(12, 12);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(62, 23);
            this.botonAtras.TabIndex = 0;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // PEDIDOS
            // 
            this.PEDIDOS.AutoSize = true;
            this.PEDIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PEDIDOS.Location = new System.Drawing.Point(287, 17);
            this.PEDIDOS.Name = "PEDIDOS";
            this.PEDIDOS.Size = new System.Drawing.Size(62, 13);
            this.PEDIDOS.TabIndex = 1;
            this.PEDIDOS.Text = "PEDIDOS";
            // 
            // datagridPedidosACancelar
            // 
            this.datagridPedidosACancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPedidosACancelar.Location = new System.Drawing.Point(89, 33);
            this.datagridPedidosACancelar.Name = "datagridPedidosACancelar";
            this.datagridPedidosACancelar.Size = new System.Drawing.Size(478, 159);
            this.datagridPedidosACancelar.TabIndex = 2;
            this.datagridPedidosACancelar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el numero de pedido a cancelar";
            // 
            // tbPedidoCancelar
            // 
            this.tbPedidoCancelar.Location = new System.Drawing.Point(268, 216);
            this.tbPedidoCancelar.Name = "tbPedidoCancelar";
            this.tbPedidoCancelar.Size = new System.Drawing.Size(182, 20);
            this.tbPedidoCancelar.TabIndex = 4;
            // 
            // tbMotivoCancelo
            // 
            this.tbMotivoCancelo.Location = new System.Drawing.Point(268, 251);
            this.tbMotivoCancelo.Name = "tbMotivoCancelo";
            this.tbMotivoCancelo.Size = new System.Drawing.Size(182, 20);
            this.tbMotivoCancelo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo";
            // 
            // botonProcesarCancelo
            // 
            this.botonProcesarCancelo.Location = new System.Drawing.Point(229, 289);
            this.botonProcesarCancelo.Name = "botonProcesarCancelo";
            this.botonProcesarCancelo.Size = new System.Drawing.Size(145, 23);
            this.botonProcesarCancelo.TabIndex = 7;
            this.botonProcesarCancelo.Text = "PROCESAR";
            this.botonProcesarCancelo.UseVisualStyleBackColor = true;
            this.botonProcesarCancelo.Click += new System.EventHandler(this.botonProcesarCancelo_Click);
            // 
            // ayudaPedidosCancelar
            // 
            this.ayudaPedidosCancelar.Location = new System.Drawing.Point(509, 289);
            this.ayudaPedidosCancelar.Name = "ayudaPedidosCancelar";
            this.ayudaPedidosCancelar.Size = new System.Drawing.Size(62, 23);
            this.ayudaPedidosCancelar.TabIndex = 8;
            this.ayudaPedidosCancelar.Text = "AYUDA";
            this.ayudaPedidosCancelar.UseVisualStyleBackColor = true;
            // 
            // VentanaCancelarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 324);
            this.Controls.Add(this.ayudaPedidosCancelar);
            this.Controls.Add(this.botonProcesarCancelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMotivoCancelo);
            this.Controls.Add(this.tbPedidoCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridPedidosACancelar);
            this.Controls.Add(this.PEDIDOS);
            this.Controls.Add(this.botonAtras);
            this.Name = "VentanaCancelarPedido";
            this.Text = "VentanaCancelarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosACancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label PEDIDOS;
        private System.Windows.Forms.DataGridView datagridPedidosACancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPedidoCancelar;
        private System.Windows.Forms.TextBox tbMotivoCancelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonProcesarCancelo;
        private System.Windows.Forms.Button ayudaPedidosCancelar;
    }
}