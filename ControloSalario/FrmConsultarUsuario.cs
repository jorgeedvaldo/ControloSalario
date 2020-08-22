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
    public partial class FrmConsultarUsuario : Form
    {
        public FrmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void FrmConsultarUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bd.Executar("SELECT * FROM Usuario");
            cbPesquisa.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbPesquisa.Text == "Mostrar Tudo")
            {
                dataGridView1.DataSource = Bd.Executar("SELECT * FROM Usuario");
                return;
            }
            dataGridView1.DataSource = Bd.Executar("SELECT * FROM Usuario WHERE " + cbPesquisa.Text + " LIKE '" + txtPesquisa.Text + "%'");
        }

        private void cbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPesquisa_TextChanged(null, null);
            }
            catch { }
        }
    }
}
