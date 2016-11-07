namespace tarea
{
    partial class EliminarProducto
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
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.TxtEliminarProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridEliminarProducto = new System.Windows.Forms.DataGridView();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Location = new System.Drawing.Point(335, 12);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarProducto.TabIndex = 0;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.UseVisualStyleBackColor = true;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // TxtEliminarProducto
            // 
            this.TxtEliminarProducto.Location = new System.Drawing.Point(215, 14);
            this.TxtEliminarProducto.Name = "TxtEliminarProducto";
            this.TxtEliminarProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtEliminarProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el SKU del producto a eliminar";
            // 
            // DataGridEliminarProducto
            // 
            this.DataGridEliminarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarProducto.Location = new System.Drawing.Point(13, 53);
            this.DataGridEliminarProducto.Name = "DataGridEliminarProducto";
            this.DataGridEliminarProducto.Size = new System.Drawing.Size(503, 196);
            this.DataGridEliminarProducto.TabIndex = 3;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(426, 12);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 4;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.DataGridEliminarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEliminarProducto);
            this.Controls.Add(this.BtnEliminarProducto);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.TextBox TxtEliminarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridEliminarProducto;
        private System.Windows.Forms.Button BtnAtras;
    }
}