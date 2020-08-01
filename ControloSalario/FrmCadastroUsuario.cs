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
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            cbCargo.SelectedIndex = 1;
            //cbFuncionario.DataSource = Bd.Executar("SELECT * FROM Agente WHERE Agente.Id NOT IN(SELECT IdAgente FROM Missao);");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Clear();
            txtPalavraPasse.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult SimNao = MessageBox.Show("Tem a certeza que deseja cancelar esta operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SimNao == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPalavraPasse.Text == "" || txtNomeUsuario.Text == "")
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!");
                }
                else
                {

                    int valor = Bd.Executar("SELECT * FROM usuario WHERE nomeusuario = '" + txtNomeUsuario.Text + "' ").Rows.Count;

                    if (valor == 1)
                    {

                        MessageBox.Show("O Usuário já está cadastrado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        Bd.Executar("INSERT INTO usuario (nomeusuario, senha, cargo) values('" + txtNomeUsuario.Text + "', '" + txtPalavraPasse.Text + "', '" + cbCargo.Text + "')");
                        MessageBox.Show("Usuário Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpar_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
