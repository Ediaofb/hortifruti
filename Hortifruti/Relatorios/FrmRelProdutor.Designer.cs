namespace Hortifruti.Relatorios
{
    partial class FrmRelProdutor
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
            this.produtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hortifruti_dbDataSet = new Hortifruti.hortifruti_dbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.produtorTableAdapter = new Hortifruti.hortifruti_dbDataSetTableAdapters.ProdutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // produtorBindingSource
            // 
            this.produtorBindingSource.DataMember = "Produtor";
            this.produtorBindingSource.DataSource = this.hortifruti_dbDataSet;
            // 
            // hortifruti_dbDataSet
            // 
            this.hortifruti_dbDataSet.DataSetName = "hortifruti_dbDataSet";
            this.hortifruti_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dataset_tblProdutores";
            reportDataSource1.Value = this.produtorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hortifruti.Relatorios.RelProdutor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // produtorTableAdapter
            // 
            this.produtorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelProdutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelProdutor";
            this.Text = "Relatório de Produtores";
            this.Load += new System.EventHandler(this.FrmrRelProdutorcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private hortifruti_dbDataSet hortifruti_dbDataSet;
        private System.Windows.Forms.BindingSource produtorBindingSource;
        private hortifruti_dbDataSetTableAdapters.ProdutorTableAdapter produtorTableAdapter;
    }
}