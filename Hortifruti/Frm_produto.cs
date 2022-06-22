using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace Hortifruti
{
    public partial class Frm_produto : Form
    {
        //MetodosUteis metodos = new MetodosUteis();

        public Frm_produto()
        {
            InitializeComponent();
            test();
          /*  ConfiguraDataGridView();
            string comandoSQL = "Select * from produto";

            atualizaDataGridView(comandoSQL);*/
        }

        public void test()
        {
            string config = "Data Source=EDSON-PC;Initial Catalog=hortifruti_db;Integrated Security=True";
            string query = String.Format("SELECT * FROM PRODUTO", "bd");

            SqlConnection conexao = new SqlConnection(config);
            conexao.Open();

            SqlCommand comand = new SqlCommand(query, conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(comand);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvProduto.DataSource = data;

        }


        /*public void atualizaDataGridView(string comandoSQL)
        {
            MySqlConnection conn = new MySqlConnection(metodos.conectaBD());

            try
            {
                conn.Open();
                MySqlCommand sql = new MySqlCommand(comandoSQL, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvProduto.DataSource = ds;
                dgvProduto.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os dados!\n\n" + ex + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        } */

        // -- CONFIGURA DATAGRIDVIEW--\\

        public void ConfiguraDataGridView()
        {
            //Renomeia as colunas do DataGridView

            dgvProduto.Columns[0].HeaderText = "idProduto";
            dgvProduto.Columns[1].HeaderText = "nome";
            dgvProduto.Columns[2].HeaderText = "tipo";
            dgvProduto.Columns[3].HeaderText = "preço";

            //Redimensiona o tamanho das colunas
            dgvProduto.Columns[0].Width = 60;
            dgvProduto.Columns[1].Width = 100;
            dgvProduto.Columns[2].Width = 100;
            dgvProduto.Columns[3].Width = 100;
        }

        private void btn_voltar_cli_Click(object sender, EventArgs e)
        {
            Frm_consulta cons = new Frm_consulta();
            cons.Show();
            this.Close();
        }

        private void Frm_produto_Load(object sender, EventArgs e)
        {
          /*  MySqlConnection cnx = new MySqlConnection(metodos.conectaBD());

            try
            {
                cnx.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha de acesso ao banco de dados. \n\nDescrição do erro:\n\n" + ex + ". ");
                return;
            }
            //define comandos MySql
            MySqlCommand cmdSQL = new MySqlCommand("Select * from produto", cnx);

            //faz a ponte entre o objeto Dataset e a fonte de dados - cria um adapter para preencher um DataSet
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSQL);

            //define um objeto DataSet que guardará na memória os dados obtidos da fonte de dados
            DataSet ds = new DataSet();

            //estrutura da tabela do banco de dados ou de outra fonte de informação
            DataTable produto = new DataTable();

            //recupera os dados da fonte de dados usando a instrução SQL
            da.Fill(produto);

            //obtém ou define a fonte de dados que será exibida no DataGridView
            dgvProduto.DataSource = produto;
            ConfiguraDataGridView();
            atualizaDataGridView("SELECT * FROM produto ORDER BY nome"); */
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
