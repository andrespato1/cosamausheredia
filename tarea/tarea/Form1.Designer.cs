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
            this.SuspendLayout();
            // 
            // BtnProducto
            // 
            this.BtnProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.BtnProducto.Location = new System.Drawing.Point(34, 27);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 0;
            this.BtnProducto.Text = "Productos";
            this.BtnProducto.UseVisualStyleBackColor = true;
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(34, 56);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Clientes";
            this.BtnCliente.UseVisualStyleBackColor = true;
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Location = new System.Drawing.Point(34, 85);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(75, 23);
            this.BtnPersonal.TabIndex = 2;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.UseVisualStyleBackColor = true;
            // 
            // BtnPedido
            // 
            this.BtnPedido.Location = new System.Drawing.Point(34, 114);
            this.BtnPedido.Name = "BtnPedido";
            this.BtnPedido.Size = new System.Drawing.Size(75, 23);
            this.BtnPedido.TabIndex = 4;
            this.BtnPedido.Text = "Pedidos";
            this.BtnPedido.UseVisualStyleBackColor = true;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(34, 143);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(75, 42);
            this.BtnReporte.TabIndex = 5;
            this.BtnReporte.Text = "Generar Reportes";
            this.BtnReporte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 228);
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
    }
}

