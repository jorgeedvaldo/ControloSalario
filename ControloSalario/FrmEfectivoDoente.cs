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
    public partial class FrmEfectivoDoente : Form
    {
        public FrmEfectivoDoente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEfectivoDoente_Load(object sender, EventArgs e)
        {
            CbAgente.DataSource = Bd.Executar("SELECT * FROM Agente");
            CbAgente_SelectedIndexChanged(null, null);

            CbDoenteAoDomicilio.SelectedIndex = 0;
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            TxtDoencaPotencial.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (TxtDoencaPotencial.Text == "")
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!");
                }
                else
                {
                    Bd.Executar("INSERT INTO EfectivoDoente(DoencaPotencial, DoenteAoDomicilio, IdAgente) VALUES('"+TxtDoencaPotencial.Text+"', '"+CbDoenteAoDomicilio.Text+"', "+CbAgente.SelectedValue+")");
                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar_Click(null, null);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Verifique se todos os campos foram preenchidos correctamente!");
            //}
        }
    }
}
