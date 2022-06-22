using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hortifruti
{
    public partial class Frm_compra : Form
    {
        public Frm_compra()
        {
            InitializeComponent();
        }

        private void Frm_compra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet4.Compra'. Você pode movê-la ou removê-la conforme necessário.
            this.compraTableAdapter.Fill(this.hortifruti_dbDataSet4.Compra);

        }

        private void btn_voltar_cli_Click(object sender, EventArgs e)
        {
            Frm_consulta cons = new Frm_consulta();
            cons.Show();
            this.Hide();
        }
    }
}
