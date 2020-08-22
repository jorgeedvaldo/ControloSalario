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
    public partial class FrmRelatorioUsuario : Form
    {
        public FrmRelatorioUsuario()
        {
            InitializeComponent();
        }

        private void FrmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BdControloSalarioDataSet.Usuario' table. You can move, or remove it, as needed.
            this.UsuarioTableAdapter.Fill(this.BdControloSalarioDataSet.Usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
