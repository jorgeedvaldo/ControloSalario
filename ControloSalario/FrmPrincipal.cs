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
    public partial class FrmPrincipal : Form
    {
        public static string IdUsuario;
        public FrmPrincipal()
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

        private void BtnAvaliarAgente_Click(object sender, EventArgs e)
        {
            FrmEfectivoAvaliado frm = new FrmEfectivoAvaliado();
            frm.ShowDialog();
        }

        private void BtnEfectuarEncomenda_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRelatorioUsuario frm = new FrmRelatorioUsuario();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmLancarFerias frm = new FrmLancarFerias();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmConsultarAgentesDeFerias frm = new FrmConsultarAgentesDeFerias();
            frm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRelatorioFerias frm = new FrmRelatorioFerias();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmRelatorioAgentes frm = new FrmRelatorioAgentes();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmRelatorioMissao frm = new FrmRelatorioMissao();
            frm.ShowDialog();
        }
    }
}
