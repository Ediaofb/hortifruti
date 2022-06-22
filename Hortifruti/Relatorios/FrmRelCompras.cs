using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hortifruti.Relatorios
{
    public partial class FrmRelCompras : Form
    {
        public FrmRelCompras()
        {
            InitializeComponent();
        }

        private void FrmRerlCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet4.Compra'. Você pode movê-la ou removê-la conforme necessário.
            this.compraTableAdapter1.Fill(this.hortifruti_dbDataSet4.Compra);
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet2.Compra'. Você pode movê-la ou removê-la conforme necessário.
            this.compraTableAdapter.Fill(this.hortifruti_dbDataSet2.Compra);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
