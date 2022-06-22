using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hortifruti
{
    public partial class Frm_fornecedor : Form
    {
        public Frm_fornecedor()
        {
            InitializeComponent();
            test();
        }

        public void test()
        {
            string config = "Data Source=EDSON-PC;Initial Catalog=hortifruti_db;Integrated Security=True";
            string query = String.Format("SELECT * FROM PRODUTOR", "bd");

            SqlConnection conexao = new SqlConnection(config);
            conexao.Open();

            SqlCommand comand = new SqlCommand(query, conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(comand);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvProduto.DataSource = data;
            

        }

        private void Frm_fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet3.Produtor'. Você pode movê-la ou removê-la conforme necessário.
            this.produtorTableAdapter1.Fill(this.hortifruti_dbDataSet3.Produtor);
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet2.Produtor'. Você pode movê-la ou removê-la conforme necessário.
            this.produtorTableAdapter.Fill(this.hortifruti_dbDataSet2.Produtor);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_voltar_cli_Click(object sender, EventArgs e)
        {
            Frm_consulta cons = new Frm_consulta();
            cons.Show();
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtorTableAdapter.FillBy(this.hortifruti_dbDataSet2.Produtor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
try {
    this.produtorTableAdapter1.FillBy(this.hortifruti_dbDataSet3.Produtor);
}
catch (System.Exception ex) {
    System.Windows.Forms.MessageBox.Show(ex.Message);
}

        }
    }
}
