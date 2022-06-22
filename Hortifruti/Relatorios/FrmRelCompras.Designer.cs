namespace Hortifruti.Relatorios
{
    partial class FrmRelCompras
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
            this.compraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hortifrutidbDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hortifruti_dbDataSet4 = new Hortifruti.hortifruti_dbDataSet4();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hortifruti_dbDataSet2 = new Hortifruti.hortifruti_dbDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.compraTableAdapter = new Hortifruti.hortifruti_dbDataSet2TableAdapters.CompraTableAdapter();
            this.compraTableAdapter1 = new Hortifruti.hortifruti_dbDataSet4TableAdapters.CompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifrutidbDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // compraBindingSource1
            // 
            this.compraBindingSource1.DataMember = "Compra";
            this.compraBindingSource1.DataSource = this.hortifrutidbDataSet4BindingSource;
            // 
            // hortifrutidbDataSet4BindingSource
            // 
            this.hortifrutidbDataSet4BindingSource.DataSource = this.hortifruti_dbDataSet4;
            this.hortifrutidbDataSet4BindingSource.Position = 0;
            // 
            // hortifruti_dbDataSet4
            // 
            this.hortifruti_dbDataSet4.DataSetName = "hortifruti_dbDataSet4";
            this.hortifruti_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.hortifruti_dbDataSet2;
            // 
            // hortifruti_dbDataSet2
            // 
            this.hortifruti_dbDataSet2.DataSetName = "hortifruti_dbDataSet2";
            this.hortifruti_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.compraBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hortifruti.Relatorios.RelCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1046, 541);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmRelCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 541);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Compras";
            this.Load += new System.EventHandler(this.FrmRerlCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifrutidbDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private hortifruti_dbDataSet2 hortifruti_dbDataSet2;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private hortifruti_dbDataSet2TableAdapters.CompraTableAdapter compraTableAdapter;
        private System.Windows.Forms.BindingSource hortifrutidbDataSet4BindingSource;
        private hortifruti_dbDataSet4 hortifruti_dbDataSet4;
        private System.Windows.Forms.BindingSource compraBindingSource1;
        private hortifruti_dbDataSet4TableAdapters.CompraTableAdapter compraTableAdapter1;
    }
}