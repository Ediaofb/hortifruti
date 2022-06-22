using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hortifruti.Relatorios
{
    public partial class FrmRelVendas : Form
    {
        public FrmRelVendas()
        {
            InitializeComponent();
        }

        private void FrmRelVendas_Load(object sender, EventArgs e)
        {
            SqlCommand comando;
            SqlDataAdapter adapter;

            /*string query_clientes = @"SELECT Nome, Id_cliente FROM Cliente";
            cb_clientes.Items.Clear();
            cb_clientes.DataSource = Banco.consulta(query_clientes);
            cb_clientes.DisplayMember = "Nome";
            cb_clientes.ValueMember = "Id_cliente";*/

            //string config = "Data Source=EDSON-PC;Initial Catalog=hortifruti_db;Integrated Security=True";
            string query_vendas = @"SELECT * FROM VENDAS WHERE data BETWEEN #" + dateTimePicker1.Value + "AND" + dateTimePicker2.Value + "#";

            try
            {
                Banco.ConexaoBanco();

                //SqlConnection conexao = new SqlConnection(config);
                //conexao.Open();

                //using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings("Hortifruti.Properties.Settings.hortifruti_dbConnectionString").ConnectionString))
                cb_clientes.Items.Clear();
                cb_clientes.DataSource = Banco.consulta(query_vendas);

               /*adapter = new SqlDataAdapter(comando);
                adapter.SelectCommand = comando;*/
                DataTable table = new DataTable();
                table = Banco.consulta(query_vendas);
                //adapter.Fill(table);
                //dgvVendas.DataSource = table;
            }
            catch
            {

            }
            
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet4.Vendas'. Você pode movê-la ou removê-la conforme necessário.
          //  this.vendasTableAdapter1.Fill(this.hortifruti_dbDataSet4.Vendas);
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet1.Vendas'. Você pode movê-la ou removê-la conforme necessário.
           // this.vendasTableAdapter.Fill(this.hortifruti_dbDataSet1.Vendas);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void hortifrutidbDataSet4BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_consult_rel_vendas_Click(object sender, EventArgs e)
        {
            string query_vendas = @"SELECT * FROM VENDAS WHERE data BETWEEN #" + dateTimePicker1.Value + "AND" + dateTimePicker2.Value + "#";
            //Consulta a venda por intervalo de data

            Banco.ConexaoBanco(); //Conecta no banco
            Banco.consulta(query_vendas); //Realiza a consulta

            reportViewer1.LocalReport.DataSources.Clear(); //Limpa o datasource do datagridviewer
            ReportDataSource rds = new ReportDataSource("dataset_tbl_Vendas", Banco.consulta(query_vendas));//preenchendo o datasource com os dados da consulta ao banco.
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();//Atualiza o datagridviewer
        }
    }
}
