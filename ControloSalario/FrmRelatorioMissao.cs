using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControloSalario
{
    public partial class FrmRelatorioMissao : Form
    {
        public FrmRelatorioMissao()
        {
            InitializeComponent();
        }

        private void FrmRelatorioMissao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BdControloSalarioDataSet.VerMissao' table. You can move, or remove it, as needed.
            this.VerMissaoTableAdapter.Fill(this.BdControloSalarioDataSet.VerMissao);

            this.reportViewer1.RefreshReport();
        }
    }
}
