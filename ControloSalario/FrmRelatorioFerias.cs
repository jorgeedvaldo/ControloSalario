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
    public partial class FrmRelatorioFerias : Form
    {
        public FrmRelatorioFerias()
        {
            InitializeComponent();
        }

        private void FrmRelatorioFerias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BdControloSalarioDataSet.VerAgentesDeFerias' table. You can move, or remove it, as needed.
            this.VerAgentesDeFeriasTableAdapter.Fill(this.BdControloSalarioDataSet.VerAgentesDeFerias);

            this.reportViewer1.RefreshReport();
        }
    }
}
