namespace tarea
{
    partial class VentanaProductos
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
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSKU = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtUnidInventario = new System.Windows.Forms.TextBox();
            this.TxtCostUnitario = new System.Windows.Forms.TextBox();
            this.TxtImpuestos = new System.Windows.Forms.TextBox();
            this.TxtPrecVtaUnit = new System.Windows.Forms.TextBox();
            this.DataGridProductos = new System.Windows.Forms.DataGridView();
            this.TxtBusquedaProductos = new System.Windows.Forms.TextBox();
            this.BtnBusquedaProductos = new System.Windows.Forms.Button();
            this.CBAtributosProductos = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.CheckBoxBusca = new System.Windows.Forms.CheckBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(205, 168);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(100, 24);
            this.BtnAgregarProducto.TabIndex = 0;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SKU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidades en inventarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio de venta unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Impuestos";
            // 
            // TxtSKU
            // 
            this.TxtSKU.Location = new System.Drawing.Point(205, 21);
            this.TxtSKU.Name = "TxtSKU";
            this.TxtSKU.Size = new System.Drawing.Size(100, 20);
            this.TxtSKU.TabIndex = 7;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(205, 46);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxtDescripcion.TabIndex = 8;
            // 
            // TxtUnidInventario
            // 
            this.TxtUnidInventario.Location = new System.Drawing.Point(205, 69);
            this.TxtUnidInventario.Name = "TxtUnidInventario";
            this.TxtUnidInventario.Size = new System.Drawing.Size(100, 20);
            this.TxtUnidInventario.TabIndex = 9;
            // 
            // TxtCostUnitario
            // 
            this.TxtCostUnitario.Location = new System.Drawing.Point(205, 94);
            this.TxtCostUnitario.Name = "TxtCostUnitario";
            this.TxtCostUnitario.Size = new System.Drawing.Size(100, 20);
            this.TxtCostUnitario.TabIndex = 10;
            // 
            // TxtImpuestos
            // 
            this.TxtImpuestos.Location = new System.Drawing.Point(205, 117);
            this.TxtImpuestos.Name = "TxtImpuestos";
            this.TxtImpuestos.Size = new System.Drawing.Size(100, 20);
            this.TxtImpuestos.TabIndex = 11;
            // 
            // TxtPrecVtaUnit
            // 
            this.TxtPrecVtaUnit.Location = new System.Drawing.Point(205, 142);
            this.TxtPrecVtaUnit.Name = "TxtPrecVtaUnit";
            this.TxtPrecVtaUnit.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecVtaUnit.TabIndex = 12;
            // 
            // DataGridProductos
            // 
            this.DataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProductos.Location = new System.Drawing.Point(358, 81);
            this.DataGridProductos.Name = "DataGridProductos";
            this.DataGridProductos.Size = new System.Drawing.Size(433, 191);
            this.DataGridProductos.TabIndex = 13;
            // 
            // TxtBusquedaProductos
            // 
            this.TxtBusquedaProductos.Location = new System.Drawing.Point(358, 51);
            this.TxtBusquedaProductos.Name = "TxtBusquedaProductos";
            this.TxtBusquedaProductos.Size = new System.Drawing.Size(189, 20);
            this.TxtBusquedaProductos.TabIndex = 14;
            // 
            // BtnBusquedaProductos
            // 
            this.BtnBusquedaProductos.Location = new System.Drawing.Point(716, 48);
            this.BtnBusquedaProductos.Name = "BtnBusquedaProductos";
            this.BtnBusquedaProductos.Size = new System.Drawing.Size(75, 23);
            this.BtnBusquedaProductos.TabIndex = 15;
            this.BtnBusquedaProductos.Text = "Buscar";
            this.BtnBusquedaProductos.UseVisualStyleBackColor = true;
            this.BtnBusquedaProductos.Click += new System.EventHandler(this.BtnBusquedaProductos_Click);
            // 
            // CBAtributosProductos
            // 
            this.CBAtributosProductos.FormattingEnabled = true;
            this.CBAtributosProductos.Items.AddRange(new object[] {
            "SKU",
            "Descripcion",
            "Unidades en Inventario",
            "Costo unitario",
            "Impuestos",
            "Precio de venta unitario"});
            this.CBAtributosProductos.Location = new System.Drawing.Point(553, 50);
            this.CBAtributosProductos.Name = "CBAtributosProductos";
            this.CBAtributosProductos.Size = new System.Drawing.Size(157, 21);
            this.CBAtributosProductos.TabIndex = 16;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(12, 222);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 24);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(12, 192);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 24);
            this.BtnActualizar.TabIndex = 18;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // CheckBoxBusca
            // 
            this.CheckBoxBusca.AutoSize = true;
            this.CheckBoxBusca.Location = new System.Drawing.Point(358, 23);
            this.CheckBoxBusca.Name = "CheckBoxBusca";
            this.CheckBoxBusca.Size = new System.Drawing.Size(379, 17);
            this.CheckBoxBusca.TabIndex = 20;
            this.CheckBoxBusca.Text = "Desea que al realizar la busque se muestren todas las columnas de la tabla";
            this.CheckBoxBusca.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(13, 278);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // VentanaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 337);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.CheckBoxBusca);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CBAtributosProductos);
            this.Controls.Add(this.BtnBusquedaProductos);
            this.Controls.Add(this.TxtBusquedaProductos);
            this.Controls.Add(this.DataGridProductos);
            this.Controls.Add(this.TxtPrecVtaUnit);
            this.Controls.Add(this.TxtImpuestos);
            this.Controls.Add(this.TxtCostUnitario);
            this.Controls.Add(this.TxtUnidInventario);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtSKU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Name = "VentanaProductos";
            this.Text = "VentanaProductos";
            this.Load += new System.EventHandler(this.VentanaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSKU;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtUnidInventario;
        private System.Windows.Forms.TextBox TxtCostUnitario;
        private System.Windows.Forms.TextBox TxtImpuestos;
        private System.Windows.Forms.TextBox TxtPrecVtaUnit;
        private System.Windows.Forms.DataGridView DataGridProductos;
        private System.Windows.Forms.TextBox TxtBusquedaProductos;
        private System.Windows.Forms.Button BtnBusquedaProductos;
        private System.Windows.Forms.ComboBox CBAtributosProductos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.CheckBox CheckBoxBusca;
        private System.Windows.Forms.Button btnAtras;
    }
}