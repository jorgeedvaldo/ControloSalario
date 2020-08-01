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
    public partial class FrmCadastroAgente : Form
    {
        public FrmCadastroAgente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBI.Clear();
            txtNome.Clear();
            txtTelefone1.Clear();
            txtTelefone2.Clear();
            txtMorada.Clear();
            txtAgente.Clear();
            txtGuia.Clear();
        }

        private void FrmCadastroAgente_Load(object sender, EventArgs e)
        {
            //cbEstado.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
            cbPatente.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTelefone1.Text == "" || txtNome.Text == "")
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!");
                }
                else
                {

                    int valor = Bd.Executar("SELECT *FROM agente WHERE nome = '" + txtNome.Text + "' ").Rows.Count;

                    if (valor == 1)
                    {

                        MessageBox.Show("O Agente já está cadastrado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        Bd.Executar("INSERT INTO Agente(numeroagente, numeroguia, nome, sexo, bi, datanascimento, dataingresso, patente, telefone1, telefone2, morada) values('" + txtAgente.Text + "', '" + txtGuia.Text + "', '" + txtNome.Text + "','" + cbSexo.Text + "', '" + txtBI.Text + "','" + dtDataNascimento.Value + "', '" + DateTime.Now + "', '" + cbPatente.Text + "', '" + txtTelefone1.Text + "', '" + txtTelefone2.Text + "', '" + txtMorada.Text + "')");
                        MessageBox.Show("Agente Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLimpar_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

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
    }
}
