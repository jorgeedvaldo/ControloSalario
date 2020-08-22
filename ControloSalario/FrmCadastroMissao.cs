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
    public partial class FrmCadastroMissao : Form
    {
        public FrmCadastroMissao()
        {
            InitializeComponent();
        }

        public void ActualizarCbAgente()
        {
            cbAgente.DataSource = Bd.Executar("SELECT * FROM Agente WHERE Agente.Id NOT IN(SELECT IdAgente FROM VerMissao WHERE Estado = 'A decorrer' OR Estado = 'Prestes a iniciar') AND Agente.Id NOT IN(SELECT IdAgente FROM VerAgentesDeFerias);");
        }

        private void FrmCadastroMissao_Load(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 1;
            ActualizarCbAgente();
        }

        private void btnAdicionarNaLista_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(cbAgente.SelectedValue);
            bool Existe = false;
            for (int i = 0; i < dgAgente.RowCount; i++)
            {
                int CodigoAgenteLista = Convert.ToInt32(dgAgente.Rows[i].Cells[0].Value);
                if (Codigo == CodigoAgenteLista)
                {
                   Existe = true;
                   break;
                }
            }

            if (!Existe)
            {
                String[] Dados = new String[] { cbAgente.SelectedValue.ToString(), cbAgente.Text };
                dgAgente.Rows.Add(Dados);
                ActualizarCbAgente();
            }
            else 
            {
                MessageBox.Show("O Agente já está inserido na lista", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgAgente.RowCount == 0)
            {
                MessageBox.Show("A lista já está vazia", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                dgAgente.Rows.Remove(dgAgente.SelectedRows[0]);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult SimNao = MessageBox.Show("Tem a certeza que deseja cancelar esta operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SimNao == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtLocal.Clear();
            txtNome.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!");
                }
                else
                {

                    int valor = Bd.Executar("SELECT * FROM Missao WHERE nome = '" + txtNome.Text + "' ").Rows.Count;

                    if (valor == 1)
                    {

                        MessageBox.Show("A missão já está cadastrada", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        Bd.Executar("INSERT INTO Missao(nome, datainicio, datafim, Localizacao, descricao, estado) values('"+txtNome.Text+"', '"+dtDataInicio.Value+"', '"+dtDataFim.Value+"', '"+txtLocal.Text+"', '"+txtDescricao.Text+"', '"+cbEstado.Text+"')");
                        String IdMissao = Bd.Retornar("SELECT MAX(Id) from Missao");
                        for (int i = 0; i < dgAgente.Rows.Count; i++)
                        {
                            Bd.Executar("INSERT INTO MissaoAgente(IdMissao, IdAgente) values("+IdMissao+", "+dgAgente.Rows[i].Cells[0].Value+")");
                        }
                        MessageBox.Show("Missão Cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
