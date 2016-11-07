namespace tarea
{
    partial class VentanaFacturas
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumFacturaAFacturar = new System.Windows.Forms.TextBox();
            this.dataGridFact = new System.Windows.Forms.DataGridView();
            this.btTramitarFactura = new System.Windows.Forms.Button();
            this.btAtrasSeleccionarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero de pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNumFacturaAFacturar
            // 
            this.tbNumFacturaAFacturar.Location = new System.Drawing.Point(182, 28);
            this.tbNumFacturaAFacturar.Name = "tbNumFacturaAFacturar";
            this.tbNumFacturaAFacturar.Size = new System.Drawing.Size(143, 20);
            this.tbNumFacturaAFacturar.TabIndex = 1;
            // 
            // dataGridFact
            // 
            this.dataGridFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFact.Location = new System.Drawing.Point(12, 67);
            this.dataGridFact.Name = "dataGridFact";
            this.dataGridFact.Size = new System.Drawing.Size(505, 294);
            this.dataGridFact.TabIndex = 2;
            this.dataGridFact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btTramitarFactura
            // 
            this.btTramitarFactura.Location = new System.Drawing.Point(391, 28);
            this.btTramitarFactura.Name = "btTramitarFactura";
            this.btTramitarFactura.Size = new System.Drawing.Size(83, 23);
            this.btTramitarFactura.TabIndex = 3;
            this.btTramitarFactura.Text = "Facturar";
            this.btTramitarFactura.UseVisualStyleBackColor = true;
            this.btTramitarFactura.Click += new System.EventHandler(this.btTramitarFactura_Click);
            // 
            // btAtrasSeleccionarFactura
            // 
            this.btAtrasSeleccionarFactura.Location = new System.Drawing.Point(12, 12);
            this.btAtrasSeleccionarFactura.Name = "btAtrasSeleccionarFactura";
            this.btAtrasSeleccionarFactura.Size = new System.Drawing.Size(58, 23);
            this.btAtrasSeleccionarFactura.TabIndex = 4;
            this.btAtrasSeleccionarFactura.Text = "Atrás";
            this.btAtrasSeleccionarFactura.UseVisualStyleBackColor = true;
            this.btAtrasSeleccionarFactura.Click += new System.EventHandler(this.btAtrasSeleccionarFactura_Click);
            // 
            // VentanaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 379);
            this.Controls.Add(this.btAtrasSeleccionarFactura);
            this.Controls.Add(this.btTramitarFactura);
            this.Controls.Add(this.dataGridFact);
            this.Controls.Add(this.tbNumFacturaAFacturar);
            this.Controls.Add(this.label1);
            this.Name = "VentanaFacturas";
            this.Text = "VentanaFacturas";
            this.Load += new System.EventHandler(this.VentanaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumFacturaAFacturar;
        private System.Windows.Forms.DataGridView dataGridFact;
        private System.Windows.Forms.Button btTramitarFactura;
        private System.Windows.Forms.Button btAtrasSeleccionarFactura;
    }
}