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
    public partial class FrmConsultarMissao : Form
    {
        public FrmConsultarMissao()
        {
            InitializeComponent();
        }

        private void FrmConsultarMissao_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bd.Executar("SELECT * FROM VerMissao");
            cbPesquisa.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbPesquisa.Text == "Mostrar Tudo")
            {
                dataGridView1.DataSource = Bd.Executar("SELECT * FROM VerMissao");
                return;
            }
            dataGridView1.DataSource = Bd.Executar("SELECT * FROM VerMissao WHERE " + cbPesquisa.Text + " LIKE '" + txtPesquisa.Text + "%'");
        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPesquisa_TextChanged(null, null);
            }
            catch { }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            cbPesquisa.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
