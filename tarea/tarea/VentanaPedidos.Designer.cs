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
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.TxtCantidadPedido = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridPedidos
            // 
            this.DataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPedidos.Location = new System.Drawing.Point(154, 12);
            this.DataGridPedidos.Name = "DataGridPedidos";
            this.DataGridPedidos.Size = new System.Drawing.Size(433, 224);
            this.DataGridPedidos.TabIndex = 0;
            // 
            // CBProductos
            // 
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(12, 12);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(121, 21);
            this.CBProductos.TabIndex = 1;
            // 
            // TxtCantidadPedido
            // 
            this.TxtCantidadPedido.Location = new System.Drawing.Point(12, 40);
            this.TxtCantidadPedido.Name = "TxtCantidadPedido";
            this.TxtCantidadPedido.Size = new System.Drawing.Size(121, 20);
            this.TxtCantidadPedido.TabIndex = 2;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(12, 66);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 27);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(13, 209);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 27);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnPedido
            // 
            this.BtnPedido.Location = new System.Drawing.Point(12, 99);
            this.BtnPedido.Name = "BtnPedido";
            this.BtnPedido.Size = new System.Drawing.Size(120, 27);
            this.BtnPedido.TabIndex = 6;
            this.BtnPedido.Text = "Procesar Pedido";
            this.BtnPedido.UseVisualStyleBackColor = true;
            // 
            // VentanaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 243);
            this.Controls.Add(this.BtnPedido);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtCantidadPedido);
            this.Controls.Add(this.CBProductos);
            this.Controls.Add(this.DataGridPedidos);
            this.Name = "VentanaPedidos";
            this.Text = "VentanaPedidos";
            this.Load += new System.EventHandler(this.VentanaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridPedidos;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.TextBox TxtCantidadPedido;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnPedido;
    }
}