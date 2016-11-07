namespace tarea
{
    partial class VentanaPersonalEliminar
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
            this.DataGridEliminarPersonal = new System.Windows.Forms.DataGridView();
            this.TxtIDJefe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(540, 10);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 0;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtEliminar
            // 
            this.TxtEliminar.Location = new System.Drawing.Point(288, 12);
            this.TxtEliminar.Name = "TxtEliminar";
            this.TxtEliminar.Size = new System.Drawing.Size(67, 20);
            this.TxtEliminar.TabIndex = 1;
            this.TxtEliminar.TextChanged += new System.EventHandler(this.TxtEliminar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el ID del personal a eliminar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataGridEliminarPersonal
            // 
            this.DataGridEliminarPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEliminarPersonal.Location = new System.Drawing.Point(13, 39);
            this.DataGridEliminarPersonal.Name = "DataGridEliminarPersonal";
            this.DataGridEliminarPersonal.Size = new System.Drawing.Size(711, 230);
            this.DataGridEliminarPersonal.TabIndex = 5;
            // 
            // TxtIDJefe
            // 
            this.TxtIDJefe.Location = new System.Drawing.Point(460, 12);
            this.TxtIDJefe.Name = "TxtIDJefe";
            this.TxtIDJefe.Size = new System.Drawing.Size(74, 20);
            this.TxtIDJefe.TabIndex = 8;
            this.TxtIDJefe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = " ID del nuevo jefe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // VentanaPersonalEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIDJefe);
            this.Controls.Add(this.DataGridEliminarPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEliminar);
            this.Controls.Add(this.BtnEliminar);
            this.Name = "VentanaPersonalEliminar";
            this.Text = "VentanaPersonalEliminar";
            this.Load += new System.EventHandler(this.VentanaPersonalEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEliminarPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridEliminarPersonal;
        private System.Windows.Forms.TextBox TxtIDJefe;
        private System.Windows.Forms.Label label3;
    }
}