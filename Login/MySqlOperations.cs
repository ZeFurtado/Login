﻿using System;
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
                //Escrever uma mensagem na label 7 aqui
                conexao.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        public void Insert(string tabela, string nome, string sobrenome, string nome_usuario,string sexo, string senha) 
        {
            using var conexao = new MySqlConnection(DadosDeConexao());
            try
            {
                conexao.Open();

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

        public void Select(string senha, string user) // Usar para validar o login
        {
            using var conexao = new MySqlConnection(DadosDeConexao());
            try
            {
                conexao.Open();
                
                using var comandoMySql = new MySqlCommand($"SELECT nome_usuario FROM user_data WHERE senha = '{senha}'", conexao);
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
                conexao.Close();
            }

        }

        public bool UserExists(string user) 
        {
            using var conexao = new MySqlConnection(DadosDeConexao());

            try
            {
                conexao.Open();
                using var comandoMySql = new MySqlCommand($"SELECT * FROM user_data WHERE nome_usuario = '{user}'", conexao);
                MySqlDataReader leitor = comandoMySql.ExecuteReader();


                if (leitor.Read())
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }

                
            }
            catch (Exception ex) 
            {
 
                conexao.Close();
                MessageBox.Show(ex.Message);
                return true;
                
            }
        }

    }
}
