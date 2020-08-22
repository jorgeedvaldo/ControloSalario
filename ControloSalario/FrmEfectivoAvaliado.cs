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
    public partial class FrmEfectivoAvaliado : Form
    {
        public FrmEfectivoAvaliado()
        {
            InitializeComponent();
        }

        private void FrmEfectivoAvaliado_Load(object sender, EventArgs e)
        {
            CbAgente.DataSource = Bd.Executar("SELECT * FROM Agente");
            CbAgente_SelectedIndexChanged(null, null);

            CbEntregaNoTrabalho.SelectedIndex = 0;
            CbPontualidade.SelectedIndex = 0;
            CbPresencaNoTrabalho.SelectedIndex = 0;
        }

        private void CbAgente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LbCodigoAgente.Text = "Número de Agente: " + Bd.Retornar("SELECT NumeroAgente from Agente WHERE Id = " + CbAgente.SelectedValue + "");
                LbNomeAgente.Text = "Nome: " + Bd.Retornar("SELECT Nome from Agente WHERE Id = " + CbAgente.SelectedValue + "");
                LbPatente.Text = "Patente: " + Bd.Retornar("SELECT Patente from Agente WHERE Id = " + CbAgente.SelectedValue + "");
            }
            catch
            {

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Bd.Executar("INSERT INTO EfectivoAvaliado(DataAvaliacao, Presenca, EntregaNoTrabalho, Pontualidade, IdAgente) VALUES('"+DtDataAvaliacao.Value+"', '"+CbPresencaNoTrabalho.Text+"', '"+CbEntregaNoTrabalho.Text+"', '"+CbPontualidade.Text+"', "+CbAgente.SelectedValue+")");
            MessageBox.Show("Avaliação efectuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
