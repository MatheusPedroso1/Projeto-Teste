using System;
using System.Data.SqlClient;

namespace Projeto_Teste
{
    public class dbConexao
    {
        // Defina a string de conexão com o banco de dados
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Aluno;Integrated Security=True";

        // Método para abrir a conexão com o banco de dados
        public SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            try
            {
                conexao.Open();
                Console.WriteLine("Conexão aberta com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
            }
            return conexao;
        }

        // Método para fechar a conexão com o banco de dados
        public void FecharConexao(SqlConnection conexao)
        {
            try
            {
                conexao.Close();
                Console.WriteLine("Conexão fechada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }
    }
}
