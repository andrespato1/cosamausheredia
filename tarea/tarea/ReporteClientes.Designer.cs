﻿namespace tarea
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReporteClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDeVentasDataSet = new tarea.sistemaDeVentasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteClienteTableAdapter = new tarea.sistemaDeVentasDataSetTableAdapters.ReporteClienteTableAdapter();
            this.sistemaDeVentasDataSet1 = new tarea.sistemaDeVentasDataSet1();
            this.sistemaDeVentasDataSet3 = new tarea.sistemaDeVentasDataSet3();
            this.CatProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CatProductoTableAdapter = new tarea.sistemaDeVentasDataSet3TableAdapters.CatProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteClienteBindingSource
            // 
            this.ReporteClienteBindingSource.DataMember = "ReporteCliente";
            this.ReporteClienteBindingSource.DataSource = this.sistemaDeVentasDataSet;
            // 
            // sistemaDeVentasDataSet
            // 
            this.sistemaDeVentasDataSet.DataSetName = "sistemaDeVentasDataSet";
            this.sistemaDeVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Reporte1";
            reportDataSource1.Value = this.ReporteClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tarea.ReportClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteClienteTableAdapter
            // 
            this.ReporteClienteTableAdapter.ClearBeforeFill = true;
            // 
            // sistemaDeVentasDataSet1
            // 
            this.sistemaDeVentasDataSet1.DataSetName = "sistemaDeVentasDataSet1";
            this.sistemaDeVentasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaDeVentasDataSet3
            // 
            this.sistemaDeVentasDataSet3.DataSetName = "sistemaDeVentasDataSet3";
            this.sistemaDeVentasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CatProductoBindingSource
            // 
            this.CatProductoBindingSource.DataMember = "CatProducto";
            this.CatProductoBindingSource.DataSource = this.sistemaDeVentasDataSet3;
            // 
            // CatProductoTableAdapter
            // 
            this.CatProductoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 324);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClientes";
            this.Text = "ReporteClientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeVentasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteClienteBindingSource;
        private sistemaDeVentasDataSet sistemaDeVentasDataSet;
        private sistemaDeVentasDataSetTableAdapters.ReporteClienteTableAdapter ReporteClienteTableAdapter;
        private sistemaDeVentasDataSet1 sistemaDeVentasDataSet1;
        private System.Windows.Forms.BindingSource CatProductoBindingSource;
        private sistemaDeVentasDataSet3 sistemaDeVentasDataSet3;
        private sistemaDeVentasDataSet3TableAdapters.CatProductoTableAdapter CatProductoTableAdapter;
    }
}