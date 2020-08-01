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

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAgente frm = new FrmCadastroAgente();
            frm.ShowDialog();
        }

        private void salarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroSalario frm = new FrmCadastroSalario();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmConsultarAgente frm = new FrmConsultarAgente();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultarMissao frm = new FrmConsultarMissao();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuario frm = new FrmCadastrarUsuario();
            frm.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCadastroMissao frm = new FrmCadastroMissao();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
