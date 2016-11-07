namespace tarea
{
    partial class VentanaClientesEliminar
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
            this.TxtEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DataGridEliminarCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEliminar
            // 
            this.TxtEliminar.Location = new System.Drawing.Point(370, 13);
            this.TxtEliminar.Name = "TxtEliminar";
            this.TxtEliminar.Size = new System.Drawing.Size(100, 20);
            this.TxtEliminar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el codigo del cliente a eliminar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(476, 11);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DataGridEliminarCliente
            // 
            this.DataGridEliminarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarCliente.Location = new System.Drawing.Point(3, 39);
            this.DataGridEliminarCliente.Name = "DataGridEliminarCliente";
            this.DataGridEliminarCliente.Size = new System.Drawing.Size(823, 225);
            this.DataGridEliminarCliente.TabIndex = 5;
            // 
            // VentanaClientesEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 278);
            this.Controls.Add(this.DataGridEliminarCliente);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEliminar);
            this.Name = "VentanaClientesEliminar";
            this.Text = "VentanaClientesEliminar";
            this.Load += new System.EventHandler(this.VentanaClientesEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DataGridEliminarCliente;
    }
}