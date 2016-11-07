namespace tarea
{
    partial class SeleccionDeReportes
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
            this.SeleccionReporte = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el reporte a generar: \r\n";
            // 
            // SeleccionReporte
            // 
            this.SeleccionReporte.FormattingEnabled = true;
            this.SeleccionReporte.Items.AddRange(new object[] {
            "Reporte de Clientes",
            "Reporte de Condiciones de Pago",
            "Reporte de Catálogo de Productos",
            "Reporte de Pedidos",
            "Reporte de Facturas",
            "Reporte de Cuentas por Cobrar",
            "Reporte de Personal"});
            this.SeleccionReporte.Location = new System.Drawing.Point(224, 105);
            this.SeleccionReporte.Name = "SeleccionReporte";
            this.SeleccionReporte.Size = new System.Drawing.Size(121, 21);
            this.SeleccionReporte.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(12, 259);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "Atras";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // SeleccionDeReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 309);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SeleccionReporte);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionDeReportes";
            this.Text = "SeleccionDeReportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SeleccionReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Salir;
    }
}