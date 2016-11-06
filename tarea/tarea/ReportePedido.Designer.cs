namespace tarea
{
    partial class ReportePedido
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
            this.sistemaDeVentasDataSet4 = new tarea.sistemaDeVentasDataSet4();
            this.ReportePedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportePedidosTableAdapter = new tarea.sistemaDeVentasDataSet4TableAdapters.ReportePedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportePedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tarea.ReportePedidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaDeVentasDataSet4
            // 
            this.sistemaDeVentasDataSet4.DataSetName = "sistemaDeVentasDataSet4";
            this.sistemaDeVentasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportePedidosBindingSource
            // 
            this.ReportePedidosBindingSource.DataMember = "ReportePedidos";
            this.ReportePedidosBindingSource.DataSource = this.sistemaDeVentasDataSet4;
            // 
            // ReportePedidosTableAdapter
            // 
            this.ReportePedidosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 341);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePedido";
            this.Text = "ReportePedido";
            this.Load += new System.EventHandler(this.ReportePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePedidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportePedidosBindingSource;
        private sistemaDeVentasDataSet4 sistemaDeVentasDataSet4;
        private sistemaDeVentasDataSet4TableAdapters.ReportePedidosTableAdapter ReportePedidosTableAdapter;
    }
}