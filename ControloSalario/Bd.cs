using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControloSalario
{
    class Bd
    {
        //metodo para estabelecer a conexão com o servidor
        public static OleDbConnection Conexao()
        {
            String conexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\BdControloSalario.accdb";
            OleDbConnection link = new OleDbConnection(conexao);
            return link;
        }

        //metodo para retornar dados na base de dados
        public static string Retornar(String Comando)
        {
            OleDbCommand comando = new OleDbCommand(Comando, Conexao());
            comando.Connection.Open();
            string valor = Convert.ToString(comando.ExecuteScalar());
            comando.Connection.Close();
            return valor;
        }


        //metodo para retornar tabela
        public static DataTable Executar(String Comando)
        {
            OleDbCommand Cmd = new OleDbCommand(Comando, Conexao());
            OleDbDataAdapter dados = new OleDbDataAdapter(Cmd);
            DataTable tb = new DataTable();
            dados.Fill(tb);
            return tb;
        }
    }
}