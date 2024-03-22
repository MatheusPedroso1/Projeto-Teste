using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Teste
{
    public class LivroAcessoDados
    {
        private string connectionString;

        public LivroAcessoDados(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AdicionarLivro(Livro livro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Inserir dados na tabela Livros
                string insertLivroQuery = "INSERT INTO Livros (Codigo, RA, Titulo, Autor, Categoria, Editora) VALUES (@Codigo, @RA, @Titulo, @Autor, @Categoria, @Editora)";
                SqlCommand insertLivroCommand = new SqlCommand(insertLivroQuery, connection);
                insertLivroCommand.Parameters.AddWithValue("@Codigo", livro.Codigo);
                insertLivroCommand.Parameters.AddWithValue("@RA", livro.RA);
                insertLivroCommand.Parameters.AddWithValue("@Titulo", livro.Titulo);
                insertLivroCommand.Parameters.AddWithValue("@Autor", livro.Autor);
                insertLivroCommand.Parameters.AddWithValue("@Categoria", livro.Categoria);
                insertLivroCommand.Parameters.AddWithValue("@Editora", livro.Editora);
                insertLivroCommand.ExecuteNonQuery();

                // Inserir dados na tabela EmprestimosLivros
                string insertEmprestimoQuery = "INSERT INTO EmprestimosLivros (Codigo, DataRetirada, DataEntrega) VALUES (@Codigo, @DataRetirada, @DataEntrega)";
                SqlCommand insertEmprestimoCommand = new SqlCommand(insertEmprestimoQuery, connection);
                insertEmprestimoCommand.Parameters.AddWithValue("@Codigo", livro.Codigo);
                insertEmprestimoCommand.Parameters.AddWithValue("@DataRetirada", livro.DataRetirada);
                insertEmprestimoCommand.Parameters.AddWithValue("@DataEntrega", livro.DataEntrega);
                insertEmprestimoCommand.ExecuteNonQuery();
            }
        }

        public List<Livro> ObterTodosLivros()
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Livros.Codigo, Livros.RA, Livros.Titulo, Livros.Autor, Livros.Categoria, Livros.Editora, EmprestimosLivros.DataRetirada, EmprestimosLivros.DataEntrega " +
                               "FROM Livros " +
                               "LEFT JOIN EmprestimosLivros ON Livros.Codigo = EmprestimosLivros.Codigo";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Livro livro = new Livro
                    {
                        Codigo = Convert.ToInt32(reader["Codigo"]),
                        RA = Convert.ToInt32(reader["RA"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Editora = reader["Editora"].ToString(),
                        DataRetirada = Convert.ToDateTime(reader["DataRetirada"]),
                        DataEntrega = Convert.ToDateTime(reader["DataEntrega"])
                    };
                    livros.Add(livro);
                }
            }

            return livros;
        }



        public void AdicionarEmprestimoLivro(EmprestimoLivro emprestimoLivro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EmprestimosLivros (Codigo, DataRetirada, DataEntrega) " +
                               "VALUES (@Codigo, @DataRetirada, @DataEntrega)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", emprestimoLivro.Codigo);
                command.Parameters.AddWithValue("@DataRetirada", emprestimoLivro.DataRetirada);
                command.Parameters.AddWithValue("@DataEntrega", emprestimoLivro.DataEntrega);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<EmprestimoLivro> ObterTodosEmprestimosLivros()
        {
            List<EmprestimoLivro> emprestimosLivros = new List<EmprestimoLivro>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Codigo, DataRetirada, DataEntrega FROM EmprestimosLivros";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EmprestimoLivro emprestimoLivro = new EmprestimoLivro
                    {
                        Codigo = Convert.ToInt32(reader["Codigo"]),
                        DataRetirada = Convert.ToDateTime(reader["DataRetirada"]),
                        DataEntrega = Convert.ToDateTime(reader["DataEntrega"])
                    };
                    emprestimosLivros.Add(emprestimoLivro);
                }
            }

            return emprestimosLivros;
        }

        public bool ExisteLivro(int codigo)
        {
            bool existe = false;

            // Consulta SQL para verificar se o código já existe
            string query = "SELECT COUNT(*) FROM Livros WHERE Codigo = @Codigo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", codigo);

                connection.Open();

                // ExecuteScalar retorna o número de livros com o código fornecido
                int count = (int)command.ExecuteScalar();

                // Se o número for maior que 0, significa que o código já existe
                if (count > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        public void UpdateLivro(Livro livro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Livro SET Titulo = @Titulo, Autor = @Autor, Categoria = @Categoria, Editora = @Editora WHERE Codigo = @Codigo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Titulo", livro.Titulo);
                command.Parameters.AddWithValue("@Autor", livro.Autor);
                command.Parameters.AddWithValue("@Categoria", livro.Categoria);
                command.Parameters.AddWithValue("@Editora", livro.Editora);
                command.Parameters.AddWithValue("@Codigo", livro.Codigo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveLivro(int codigo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Inicia a transação
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Define o comando SQL para excluir os dados da tabela Livros
                    string deleteLivrosQuery = "DELETE FROM Livros WHERE Codigo = @Codigo";
                    SqlCommand deleteLivrosCommand = new SqlCommand(deleteLivrosQuery, connection, transaction);
                    deleteLivrosCommand.Parameters.AddWithValue("@Codigo", codigo);

                    // Executa o comando para excluir os dados da tabela Livros
                    deleteLivrosCommand.ExecuteNonQuery();

                    // Define o comando SQL para excluir os dados da tabela EmprestimosLivros
                    string deleteEmprestimosQuery = "DELETE FROM EmprestimosLivros WHERE Codigo = @Codigo";
                    SqlCommand deleteEmprestimosCommand = new SqlCommand(deleteEmprestimosQuery, connection, transaction);
                    deleteEmprestimosCommand.Parameters.AddWithValue("@Codigo", codigo);

                    // Executa o comando para excluir os dados da tabela EmprestimosLivros
                    deleteEmprestimosCommand.ExecuteNonQuery();

                    // Commita a transação se tudo ocorrer bem
                    transaction.Commit();

                    MessageBox.Show("Dados removidos com sucesso.");
                }
                catch (Exception ex)
                {
                    // Rollback da transação em caso de erro
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao remover os dados: " + ex.Message);
                }
            }
        }
    }
}
