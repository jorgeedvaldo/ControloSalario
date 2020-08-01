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
    public partial class FrmCadastroSalario : Form
    {
        public FrmCadastroSalario()
        {
            InitializeComponent();
        }

        private void FrmCadastroSalario_Load(object sender, EventArgs e)
        {
            cbAgente.DataSource = Bd.Executar("SELECT * FROM Agente");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalarioBase.Clear();
            txtSubcidioAlimentacao.Clear();
            txtSubcidioTransporte.Clear();
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
            //try
            //{
                if (txtSalarioBase.Text == "")
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!");
                }
                else
                {
                    Bd.Executar("INSERT INTO Salario(SalarioBase, PercentagemIrt, PercentagemInss, SubcidioTransporte, SubcidioAlimentacao, IdAgente) values(" + txtSalarioBase.Text + ", " + txtIRT.Value + ", " + txtINSS.Value + ", " + txtSubcidioTransporte.Text + ", " + txtSubcidioAlimentacao.Text + ", " + cbAgente.SelectedValue + ")");
                    MessageBox.Show("Salario Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar_Click(null, null);                 
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
