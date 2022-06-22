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
    public partial class FrmRelProdutor : Form
    {
        public FrmRelProdutor()
        {
            InitializeComponent();
        }

        private void FrmrRelProdutorcs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hortifruti_dbDataSet.Produtor'. Você pode movê-la ou removê-la conforme necessário.
            this.produtorTableAdapter.Fill(this.hortifruti_dbDataSet.Produtor);

            this.reportViewer1.RefreshReport();
        }
    }
}
