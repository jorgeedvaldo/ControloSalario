﻿namespace ControloSalario
{
    partial class FrmRelatorioAvaliacao
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
            this.BdControloSalarioDataSet = new ControloSalario.BdControloSalarioDataSet();
            this.VerEfectivoAvaliadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VerEfectivoAvaliadoTableAdapter = new ControloSalario.BdControloSalarioDataSetTableAdapters.VerEfectivoAvaliadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BdControloSalarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerEfectivoAvaliadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VerEfectivoAvaliadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControloSalario.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(731, 580);
            this.reportViewer1.TabIndex = 0;
            // 
            // BdControloSalarioDataSet
            // 
            this.BdControloSalarioDataSet.DataSetName = "BdControloSalarioDataSet";
            this.BdControloSalarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VerEfectivoAvaliadoBindingSource
            // 
            this.VerEfectivoAvaliadoBindingSource.DataMember = "VerEfectivoAvaliado";
            this.VerEfectivoAvaliadoBindingSource.DataSource = this.BdControloSalarioDataSet;
            // 
            // VerEfectivoAvaliadoTableAdapter
            // 
            this.VerEfectivoAvaliadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 580);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioAvaliacao";
            this.Text = "FrmRelatorioAvaliacao";
            this.Load += new System.EventHandler(this.FrmRelatorioAvaliacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdControloSalarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerEfectivoAvaliadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VerEfectivoAvaliadoBindingSource;
        private BdControloSalarioDataSet BdControloSalarioDataSet;
        private BdControloSalarioDataSetTableAdapters.VerEfectivoAvaliadoTableAdapter VerEfectivoAvaliadoTableAdapter;
    }
}