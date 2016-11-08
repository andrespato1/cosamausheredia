namespace tarea
{
    partial class VentanaCondicionPago
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
            this.nombreNuevaCondicion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridCondiciones = new System.Windows.Forms.DataGridView();
            this.ayudarCPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCondiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(13, 13);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(75, 23);
            this.botonAtras.TabIndex = 0;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una nueva condicion de pago";
            // 
            // nombreNuevaCondicion
            // 
            this.nombreNuevaCondicion.Location = new System.Drawing.Point(101, 60);
            this.nombreNuevaCondicion.Name = "nombreNuevaCondicion";
            this.nombreNuevaCondicion.Size = new System.Drawing.Size(198, 20);
            this.nombreNuevaCondicion.TabIndex = 2;
            this.nombreNuevaCondicion.TextChanged += new System.EventHandler(this.nombreNuevaCondicion_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(306, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridCondiciones
            // 
            this.dataGridCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCondiciones.Location = new System.Drawing.Point(147, 116);
            this.dataGridCondiciones.Name = "dataGridCondiciones";
            this.dataGridCondiciones.Size = new System.Drawing.Size(141, 150);
            this.dataGridCondiciones.TabIndex = 4;
            // 
            // ayudarCPago
            // 
            this.ayudarCPago.Location = new System.Drawing.Point(357, 269);
            this.ayudarCPago.Name = "ayudarCPago";
            this.ayudarCPago.Size = new System.Drawing.Size(75, 23);
            this.ayudarCPago.TabIndex = 5;
            this.ayudarCPago.Text = "AYUDAR";
            this.ayudarCPago.UseVisualStyleBackColor = true;
            // 
            // VentanaCondicionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 321);
            this.Controls.Add(this.ayudarCPago);
            this.Controls.Add(this.dataGridCondiciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nombreNuevaCondicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonAtras);
            this.Name = "VentanaCondicionPago";
            this.Text = "VentanaCondicionPago";
            this.Load += new System.EventHandler(this.VentanaCondicionPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCondiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreNuevaCondicion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridCondiciones;
        private System.Windows.Forms.Button ayudarCPago;
    }
}