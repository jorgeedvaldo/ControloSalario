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
    public partial class FrmCarregamento : Form
    {
        int Valor = 0;
        public FrmCarregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Valor < 100)
            {
                Valor += 2;
                if (Valor == 30)
                {
                    TxtProcessando.Text = "Inserindo os Dados na Base de dados....";
                }
                else if (Valor == 50)
                {
                    TxtProcessando.Text = "Guardando os Dados.....";
                }
                else if (Valor == 80)
                {
                    TxtProcessando.Text = "Dados Guardados na Base de dados......";
                }
            }
            else 
            {
                timer1.Enabled = false;
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }
    }
}
