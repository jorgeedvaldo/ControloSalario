namespace ControloSalario
{
    partial class FrmRelatorioUsuario
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
            this.UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuarioTableAdapter = new ControloSalario.BdControloSalarioDataSetTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BdControloSalarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControloSalario.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(845, 581);
            this.reportViewer1.TabIndex = 0;
            // 
            // BdControloSalarioDataSet
            // 
            this.BdControloSalarioDataSet.DataSetName = "BdControloSalarioDataSet";
            this.BdControloSalarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsuarioBindingSource
            // 
            this.UsuarioBindingSource.DataMember = "Usuario";
            this.UsuarioBindingSource.DataSource = this.BdControloSalarioDataSet;
            // 
            // UsuarioTableAdapter
            // 
            this.UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 581);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioUsuario";
            this.Text = "FrmRelatorioUsuario";
            this.Load += new System.EventHandler(this.FrmRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdControloSalarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UsuarioBindingSource;
        private BdControloSalarioDataSet BdControloSalarioDataSet;
        private BdControloSalarioDataSetTableAdapters.UsuarioTableAdapter UsuarioTableAdapter;
    }
}