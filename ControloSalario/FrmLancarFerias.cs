﻿using System;
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
    public partial class FrmLancarFerias : Form
    {
        public FrmLancarFerias()
        {
            InitializeComponent();
        }

        private void LancarFerias_Load(object sender, EventArgs e)
        {
            CbAgente.DataSource = Bd.Executar("SELECT * FROM Agente"); ;

            CbAgente_SelectedIndexChanged(null, null);
            DtDataInicio_ValueChanged(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            TxtDias.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(TxtDias.Text);
                if (TxtDias.Text == "")
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!");
                }
                else
                {
                    Bd.Executar("INSERT INTO Ferias(Dias, DataInicio, DataRegresso, IdAgente) VALUES(" + TxtDias.Text + ", '" + DtDataInicio.Value.ToShortDateString() + "', '" + DtDataRegresso.Value.ToShortDateString() + "', "+CbAgente.SelectedValue+")");
                    MessageBox.Show("Férias lançadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar_Click(null, null);                  
                }
            }
            catch
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos correctamente!");
            }
        }

        private void CbAgente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                LbCodigoAgente.Text = "Número de Agente: " + Bd.Retornar("SELECT NumeroAgente from Agente WHERE Id = " + CbAgente.SelectedValue + "");
                LbNomeAgente.Text = "Nome: " + Bd.Retornar("SELECT Nome from Agente WHERE Id = "+CbAgente.SelectedValue+"");
                LbPatente.Text = "Patente: " + Bd.Retornar("SELECT Patente from Agente WHERE Id = " + CbAgente.SelectedValue + "");
            }
            catch 
            { 
            
            }
        }

        private void DtDataInicio_ValueChanged(object sender, EventArgs e)
        {
            DtDataRegresso.MinDate = DtDataInicio.Value.AddDays(1);
        }
    }
}
