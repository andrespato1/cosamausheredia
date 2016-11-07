namespace tarea
{
    partial class VentanaProductosEliminar
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridEliminarProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(467, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 0;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtEliminar
            // 
            this.TxtEliminar.Location = new System.Drawing.Point(361, 6);
            this.TxtEliminar.Name = "TxtEliminar";
            this.TxtEliminar.Size = new System.Drawing.Size(100, 20);
            this.TxtEliminar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el SKU del produscto a eliminar";
            // 
            // DataGridEliminarProducto
            // 
            this.DataGridEliminarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarProducto.Location = new System.Drawing.Point(12, 36);
            this.DataGridEliminarProducto.Name = "DataGridEliminarProducto";
            this.DataGridEliminarProducto.Size = new System.Drawing.Size(735, 198);
            this.DataGridEliminarProducto.TabIndex = 3;
            // 
            // VentanaProductosEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 246);
            this.Controls.Add(this.DataGridEliminarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEliminar);
            this.Controls.Add(this.BtnEliminar);
            this.Name = "VentanaProductosEliminar";
            this.Text = "VentanaProductosEliminar";
            this.Load += new System.EventHandler(this.VentanaProductosEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridEliminarProducto;
    }
}