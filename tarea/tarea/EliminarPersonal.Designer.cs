namespace tarea
{
    partial class EliminarPersonal
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
            this.DataGridEliminarPersonal = new System.Windows.Forms.DataGridView();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnEliminarPersonal = new System.Windows.Forms.Button();
            this.TxtEncargado = new System.Windows.Forms.TextBox();
            this.TxtIDEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFechaRetiro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEliminarPersonal
            // 
            this.DataGridEliminarPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarPersonal.Location = new System.Drawing.Point(9, 99);
            this.DataGridEliminarPersonal.Name = "DataGridEliminarPersonal";
            this.DataGridEliminarPersonal.Size = new System.Drawing.Size(389, 190);
            this.DataGridEliminarPersonal.TabIndex = 0;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(305, 14);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(88, 62);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnEliminarPersonal
            // 
            this.BtnEliminarPersonal.Location = new System.Drawing.Point(199, 30);
            this.BtnEliminarPersonal.Name = "BtnEliminarPersonal";
            this.BtnEliminarPersonal.Size = new System.Drawing.Size(87, 46);
            this.BtnEliminarPersonal.TabIndex = 4;
            this.BtnEliminarPersonal.Text = "Eliminar";
            this.BtnEliminarPersonal.UseVisualStyleBackColor = true;
            this.BtnEliminarPersonal.Click += new System.EventHandler(this.BtnEliminarPersonal_Click);
            // 
            // TxtEncargado
            // 
            this.TxtEncargado.Location = new System.Drawing.Point(91, 30);
            this.TxtEncargado.Name = "TxtEncargado";
            this.TxtEncargado.Size = new System.Drawing.Size(93, 20);
            this.TxtEncargado.TabIndex = 5;
            // 
            // TxtIDEliminar
            // 
            this.TxtIDEliminar.Location = new System.Drawing.Point(9, 30);
            this.TxtIDEliminar.Name = "TxtIDEliminar";
            this.TxtIDEliminar.Size = new System.Drawing.Size(76, 20);
            this.TxtIDEliminar.TabIndex = 6;
            this.TxtIDEliminar.TextChanged += new System.EventHandler(this.TxtIDEliminar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese el ID del personal a eliminar y el nuevo encargado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "fecha de retiro";
            // 
            // TxtFechaRetiro
            // 
            this.TxtFechaRetiro.Location = new System.Drawing.Point(91, 56);
            this.TxtFechaRetiro.Name = "TxtFechaRetiro";
            this.TxtFechaRetiro.Size = new System.Drawing.Size(93, 20);
            this.TxtFechaRetiro.TabIndex = 9;
            // 
            // EliminarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 301);
            this.Controls.Add(this.TxtFechaRetiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIDEliminar);
            this.Controls.Add(this.TxtEncargado);
            this.Controls.Add(this.BtnEliminarPersonal);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.DataGridEliminarPersonal);
            this.Name = "EliminarPersonal";
            this.Text = "EliminarPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridEliminarPersonal;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnEliminarPersonal;
        private System.Windows.Forms.TextBox TxtEncargado;
        private System.Windows.Forms.TextBox TxtIDEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFechaRetiro;
    }
}