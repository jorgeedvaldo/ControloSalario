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
    public partial class FrmRelatorioAgentes : Form
    {
        public FrmRelatorioAgentes()
        {
            InitializeComponent();
        }

        private void FrmRelatorioAgentes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BdControloSalarioDataSet.Agente' table. You can move, or remove it, as needed.
            this.AgenteTableAdapter.Fill(this.BdControloSalarioDataSet.Agente);

            this.reportViewer1.RefreshReport();
        }
    }
}
