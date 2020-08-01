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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void BtnSistemaFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProdutosCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroMissao frm = new FrmCadastroMissao();
            frm.ShowDialog();
        }

        private void BtnProdutosConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarMissao frm = new FrmConsultarMissao();
            frm.ShowDialog();
        }

        private void BtnClientesCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroAgente frm = new FrmCadastroAgente();
            frm.ShowDialog();
        }

        private void BtnClientesConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarAgente frm = new FrmConsultarAgente();
            frm.ShowDialog();
        }

        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuario frm = new FrmCadastrarUsuario();
            frm.ShowDialog();
        }

        private void BtnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            FrmConsultarUsuario frm = new FrmConsultarUsuario();
            frm.ShowDialog();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 2;
        }
    }
}
