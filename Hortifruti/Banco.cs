using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hortifruti
{
    class Banco
    {
        public static SqlConnection conexao;

        public static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection("Data Source=EDSON-PC;Initial Catalog=hortifruti_db;Integrated Security=True");
            conexao.Open();
            return conexao;
        }

        public static DataTable consulta(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
    }    
}