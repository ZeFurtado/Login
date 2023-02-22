using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Login
{
    internal class MySqlOperations
    {
        DbData dadosDeAcesso = new DbData();

        string DadosDeConexao() 
        {
            string conexao = $"SERVER={dadosDeAcesso.server};USER={dadosDeAcesso.user};PASSWORD={dadosDeAcesso.password};DATABASE={dadosDeAcesso.database}";
            return conexao;
        }

    }
}
