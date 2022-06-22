namespace Hortifruti
{
    partial class Frm_venda
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltar_cli = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hortifruti_dbDataSet2 = new Hortifruti.hortifruti_dbDataSet2();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new Hortifruti.hortifruti_dbDataSet2TableAdapters.VendasTableAdapter();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vendas Realizadas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(538, 100);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(536, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de fim:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(407, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de início:";
            // 
            // btn_voltar_cli
            // 
            this.btn_voltar_cli.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_cli.Location = new System.Drawing.Point(455, 603);
            this.btn_voltar_cli.Name = "btn_voltar_cli";
            this.btn_voltar_cli.Size = new System.Drawing.Size(75, 29);
            this.btn_voltar_cli.TabIndex = 9;
            this.btn_voltar_cli.Text = "Voltar";
            this.btn_voltar_cli.UseVisualStyleBackColor = true;
            this.btn_voltar_cli.Click += new System.EventHandler(this.btn_voltar_cli_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vendas Cadastradas:";
            // 
            // hortifruti_dbDataSet2
            // 
            this.hortifruti_dbDataSet2.DataSetName = "hortifruti_dbDataSet2";
            this.hortifruti_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.hortifruti_dbDataSet2;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToOrderColumns = true;
            this.dgvVendas.ColumnHeadersVisible = false;
            this.dgvVendas.Location = new System.Drawing.Point(37, 190);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(875, 384);
            this.dgvVendas.TabIndex = 6;
            this.dgvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // Frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 657);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_voltar_cli);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vendas";
            this.Load += new System.EventHandler(this.Frm_venda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hortifruti_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_voltar_cli;
        private System.Windows.Forms.Label label3;
        private hortifruti_dbDataSet2 hortifruti_dbDataSet2;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private hortifruti_dbDataSet2TableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}