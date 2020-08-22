namespace ControloSalario
{
    partial class FrmRelatorioAgentes
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
            this.AgenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AgenteTableAdapter = new ControloSalario.BdControloSalarioDataSetTableAdapters.AgenteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BdControloSalarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AgenteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControloSalario.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(806, 549);
            this.reportViewer1.TabIndex = 0;
            // 
            // BdControloSalarioDataSet
            // 
            this.BdControloSalarioDataSet.DataSetName = "BdControloSalarioDataSet";
            this.BdControloSalarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AgenteBindingSource
            // 
            this.AgenteBindingSource.DataMember = "Agente";
            this.AgenteBindingSource.DataSource = this.BdControloSalarioDataSet;
            // 
            // AgenteTableAdapter
            // 
            this.AgenteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioAgentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 549);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioAgentes";
            this.Text = "FrmRelatorioAgentes";
            this.Load += new System.EventHandler(this.FrmRelatorioAgentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdControloSalarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AgenteBindingSource;
        private BdControloSalarioDataSet BdControloSalarioDataSet;
        private BdControloSalarioDataSetTableAdapters.AgenteTableAdapter AgenteTableAdapter;
    }
}