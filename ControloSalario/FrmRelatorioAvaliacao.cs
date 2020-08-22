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
    public partial class FrmRelatorioAvaliacao : Form
    {
        public FrmRelatorioAvaliacao()
        {
            InitializeComponent();
        }

        private void FrmRelatorioAvaliacao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
