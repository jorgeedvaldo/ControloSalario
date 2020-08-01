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
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String NomeUsuario = txtUsuario.Text.ToLower();
            String Senha = txtSenha.Text;
            int LoginState = Bd.Executar("select * from usuario where nomeusuario = '"+NomeUsuario+"' and senha = '"+Senha+"'").Rows.Count;

            if (LoginState == 1)
            {
                FrmPrincipal.IdUsuario = Bd.Retornar("select id from usuario where nomeusuario = '"+NomeUsuario+"'");
                FrmDashboard frm = new FrmDashboard();
                frm.Show();

                this.Hide();
            }
            else
            {
                DialogResult SimNao = MessageBox.Show("Os dados inseridos estão incorrectos, tente novamente.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult SimNao = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SimNao == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

      
    }
}
