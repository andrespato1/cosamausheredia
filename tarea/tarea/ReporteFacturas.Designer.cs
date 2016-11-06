namespace tarea
{
    partial class ReporteFacturas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistemaDeVentasDataSet5 = new tarea.sistemaDeVentasDataSet5();
            this.ReporteFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteFacturasTableAdapter = new tarea.sistemaDeVentasDataSet5TableAdapters.ReporteFacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteFacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tarea.ReporteFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(775, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaDeVentasDataSet5
            // 
            this.sistemaDeVentasDataSet5.DataSetName = "sistemaDeVentasDataSet5";
            this.sistemaDeVentasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteFacturasBindingSource
            // 
            this.ReporteFacturasBindingSource.DataMember = "ReporteFacturas";
            this.ReporteFacturasBindingSource.DataSource = this.sistemaDeVentasDataSet5;
            // 
            // ReporteFacturasTableAdapter
            // 
            this.ReporteFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFacturas";
            this.Text = "ReporteFacturas";
            this.Load += new System.EventHandler(this.ReporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteFacturasBindingSource;
        private sistemaDeVentasDataSet5 sistemaDeVentasDataSet5;
        private sistemaDeVentasDataSet5TableAdapters.ReporteFacturasTableAdapter ReporteFacturasTableAdapter;
    }
}