namespace tarea
{
    partial class ReporteCondicionesDePago
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
            this.sistemaDeVentasDataSet2 = new tarea.sistemaDeVentasDataSet2();
            this.CondpagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CondpagoTableAdapter = new tarea.sistemaDeVentasDataSet2TableAdapters.CondpagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CondpagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CondpagoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tarea.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(763, 354);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaDeVentasDataSet2
            // 
            this.sistemaDeVentasDataSet2.DataSetName = "sistemaDeVentasDataSet2";
            this.sistemaDeVentasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CondpagoBindingSource
            // 
            this.CondpagoBindingSource.DataMember = "Condpago";
            this.CondpagoBindingSource.DataSource = this.sistemaDeVentasDataSet2;
            // 
            // CondpagoTableAdapter
            // 
            this.CondpagoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCondicionesDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 354);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCondicionesDePago";
            this.Text = "ReporteCondicionesDePago";
            this.Load += new System.EventHandler(this.ReporteCondicionesDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CondpagoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CondpagoBindingSource;
        private sistemaDeVentasDataSet2 sistemaDeVentasDataSet2;
        private sistemaDeVentasDataSet2TableAdapters.CondpagoTableAdapter CondpagoTableAdapter;
    }
}