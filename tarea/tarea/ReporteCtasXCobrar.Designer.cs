namespace tarea
{
    partial class ReporteCtasXCobrar
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
            this.sistemaDeVentasDataSet6 = new tarea.sistemaDeVentasDataSet6();
            this.ReporteCuentasXCobrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteCuentasXCobrarTableAdapter = new tarea.sistemaDeVentasDataSet6TableAdapters.ReporteCuentasXCobrarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCuentasXCobrarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteCuentasXCobrarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tarea.ReporteCtasXCobrar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(756, 368);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaDeVentasDataSet6
            // 
            this.sistemaDeVentasDataSet6.DataSetName = "sistemaDeVentasDataSet6";
            this.sistemaDeVentasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteCuentasXCobrarBindingSource
            // 
            this.ReporteCuentasXCobrarBindingSource.DataMember = "ReporteCuentasXCobrar";
            this.ReporteCuentasXCobrarBindingSource.DataSource = this.sistemaDeVentasDataSet6;
            // 
            // ReporteCuentasXCobrarTableAdapter
            // 
            this.ReporteCuentasXCobrarTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCtasXCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 368);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCtasXCobrar";
            this.Text = "ReporteCtasXCobrar";
            this.Load += new System.EventHandler(this.ReporteCtasXCobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteCuentasXCobrarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteCuentasXCobrarBindingSource;
        private sistemaDeVentasDataSet6 sistemaDeVentasDataSet6;
        private sistemaDeVentasDataSet6TableAdapters.ReporteCuentasXCobrarTableAdapter ReporteCuentasXCobrarTableAdapter;
    }
}