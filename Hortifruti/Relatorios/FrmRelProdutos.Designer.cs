namespace Hortifruti.Relatorios
{
    partial class FrmRelProdutos
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
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hortifruti_dbDataSet4 = new Hortifruti.hortifruti_dbDataSet4();
            this.produtoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hortifrutidbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hortifruti_dbDataSet = new Hortifruti.hortifruti_dbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.produtoTableAdapter = new Hortifruti.hortifruti_dbDataSetTableAdapters.ProdutoTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter1 = new Hortifruti.hortifruti_dbDataSet4TableAdapters.ProdutoTableAdapter();
            this.hortifrutidbDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifrutidbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifrutidbDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.hortifruti_dbDataSet4;
            // 
            // hortifruti_dbDataSet4
            // 
            this.hortifruti_dbDataSet4.DataSetName = "hortifruti_dbDataSet4";
            this.hortifruti_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource2
            // 
            this.produtoBindingSource2.DataMember = "Produto";
            this.produtoBindingSource2.DataSource = this.hortifrutidbDataSetBindingSource;
            // 
            // hortifrutidbDataSetBindingSource
            // 
            this.hortifrutidbDataSetBindingSource.DataSource = this.hortifruti_dbDataSet;
            this.hortifrutidbDataSetBindingSource.Position = 0;
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
            reportDataSource1.Name = "dataset_produtos";
            reportDataSource1.Value = this.produtoBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hortifruti.Relatorios.RelProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(958, 613);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.hortifruti_dbDataSet4;
            // 
            // produtoTableAdapter1
            // 
            this.produtoTableAdapter1.ClearBeforeFill = true;
            // 
            // hortifrutidbDataSet4BindingSource
            // 
            this.hortifrutidbDataSet4BindingSource.DataSource = this.hortifruti_dbDataSet4;
            this.hortifrutidbDataSet4BindingSource.Position = 0;
            // 
            // FrmRelProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 613);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.FrmRelProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifrutidbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hortifrutidbDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private hortifruti_dbDataSet hortifruti_dbDataSet;
        private System.Windows.Forms.BindingSource hortifrutidbDataSetBindingSource;
        private hortifruti_dbDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource2;
        private hortifruti_dbDataSet4 hortifruti_dbDataSet4;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private hortifruti_dbDataSet4TableAdapters.ProdutoTableAdapter produtoTableAdapter1;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.BindingSource hortifrutidbDataSet4BindingSource;
    }
}