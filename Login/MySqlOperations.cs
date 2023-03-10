using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Login
{

    class MySqlOperations
    {
        DbData dadosDeAcesso = new DbData();

       //Form1 form1 = new Form1();

        public string DadosDeConexao()
        {
            string dadosDeConexao = $"SERVER={dadosDeAcesso.server};USER={dadosDeAcesso.user};PASSWORD={dadosDeAcesso.password};DATABASE={dadosDeAcesso.database}";
            return dadosDeConexao;
        }

        public void TetarConexao()
        {
            using var conexao = new MySqlConnection(DadosDeConexao());

            try
            {
                conexao.Open();
                conexao.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        public void SelectTables(string table) 
        {

            using var conexao = new MySqlConnection(DadosDeConexao());
                
            try
            {
                conexao.Open();
                
                using var comandoSql = new MySqlCommand($"SELECT * FROM {table}", conexao);
                MySqlDataReader leitor = comandoSql.ExecuteReader();

                while (leitor.Read()) 
                {
                    MessageBox.Show(leitor[0] + "---" + leitor[1]);
                }
                leitor.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            conexao.Close();
        }

        public void Insert(string tabela, string nome, string sobrenome, string sexo, string senha) 
        {
            using var conexao = new MySqlConnection(DadosDeConexao());
            try
            {
                conexao.Open();

                string nome_usuario = nome + "." + sobrenome;

                MySqlCommand comandoMySql = conexao.CreateCommand();
                comandoMySql.CommandText = $"INSERT INTO {tabela} (nome, sobrenome, nome_usuario, sexo, senha) VALUES ('{nome}', '{sobrenome}','{nome_usuario}','{sexo}', '{senha}')";
                comandoMySql.ExecuteNonQuery();
                 

                MessageBox.Show($"Usuário {nome_usuario} criado!!! Dados inseridos com sucesso!!!");

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            conexao.Close();
        }

        public void Select(string senha, string user) 
        {
            using var conexao = new MySqlConnection(DadosDeConexao());
            try
            {
                conexao.Open();
                
                using var comandoMySql = new MySqlCommand($"SELECT nome_usuario FROM user_data WHERE senha = '{senha}'");
                MySqlDataReader leitor = comandoMySql.ExecuteReader();

                while (leitor.Read())  
                {
                    MessageBox.Show(leitor[0] + "");
                }
                leitor.Close();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

    }
}
