using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hortifruti
{
    public partial class Frm_venda : Form
    {
        SqlCommand comando;
        SqlDataAdapter adaptador;

        public Frm_venda()
        {
            InitializeComponent();
            test();
        }

        public void test()
        {
            string config = "Data Source=EDSON-PC;Initial Catalog=hortifruti_db;Integrated Security=True";
            string query = String.Format("SELECT * FROM VENDAS", "bd");

            SqlConnection conexao = new SqlConnection(config);
            conexao.Open();

            SqlCommand comand = new SqlCommand(query, conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(comand);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvVendas.DataSource = data;

            conexao.Close();

        }

        private void Frm_venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet2.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.hortifruti_dbDataSet2.Vendas);

        }

        private void btn_voltar_cli_Click(object sender, EventArgs e)
        {
            Frm_consulta cons = new Frm_consulta();
            cons.Show();
            this.Hide();
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta_venda_personalizada();
        }

        public void consulta_venda_personalizada()
        {

            /*string st = dateTimePicker1.Value.ToString();
            string str = dateTimePicker2.Value.ToShortDateString();
            MessageBox.Show("O valor DateTimePicker1 é:" + st + "E o valor DateTimePicker2 é: " + str + "");*/

            string config = "Data Source=EDSON-PC;Initial Catalog=hortifruti_db;Integrated Security=True";
            string query = "SELECT * FROM VENDAS WHERE Cliente = @cliente AND Data BETWEEN @data1 AND @data2;";

            SqlConnection cn = new SqlConnection(config);
            cn.Open();

            try
            {
                comando = new SqlCommand(query, cn);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@cliente", textBox2.Text);
                comando.Parameters.AddWithValue("@data1", dateTimePicker1.Value);
                comando.Parameters.AddWithValue("@data2", dateTimePicker2.Value);

                if (dateTimePicker2.Value < dateTimePicker1.Value)
                    MessageBox.Show("A data final deve ser maior que a data inicial da busca!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                adaptador = new SqlDataAdapter(comando);
                adaptador.SelectCommand = comando;
                DataTable table = new DataTable();
                adaptador.Fill(table);
                dgvVendas.DataSource = table;
            } 

            catch (Exception ex)    
            {
            throw ex;
            }

            finally
            {
                cn.Close();
                comando.Dispose();
                cn = null;
                comando = null;
            }

        }
    }
}
