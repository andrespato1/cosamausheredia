namespace tarea
{
    partial class ReporteClientes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistemaDeVentasDataSet = new tarea.sistemaDeVentasDataSet();
            this.ReporteClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteClienteTableAdapter = new tarea.sistemaDeVentasDataSetTableAdapters.ReporteClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ReporteClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tarea.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(214, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaDeVentasDataSet
            // 
            this.sistemaDeVentasDataSet.DataSetName = "sistemaDeVentasDataSet";
            this.sistemaDeVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteClienteBindingSource
            // 
            this.ReporteClienteBindingSource.DataMember = "ReporteCliente";
            this.ReporteClienteBindingSource.DataSource = this.sistemaDeVentasDataSet;
            // 
            // ReporteClienteTableAdapter
            // 
            this.ReporteClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClientes";
            this.Text = "ReporteClientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteClienteBindingSource;
        private sistemaDeVentasDataSet sistemaDeVentasDataSet;
        private sistemaDeVentasDataSetTableAdapters.ReporteClienteTableAdapter ReporteClienteTableAdapter;
    }
}