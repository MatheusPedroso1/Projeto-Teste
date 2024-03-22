using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_Teste
{
    public class AlunoAcessoDados
    {
        private string connectionString;

        public AlunoAcessoDados(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AdicionarAluno(Aluno aluno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Aluno (RA, Nome, Email, Telefone, DataNascimento) " +
                               "VALUES (@RA, @Nome, @Email, @Telefone, @DataNascimento)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RA", aluno.RA);
                command.Parameters.AddWithValue("@Nome", aluno.Nome);
                command.Parameters.AddWithValue("@Email", aluno.Email);
                command.Parameters.AddWithValue("@Telefone", aluno.Telefone);
                command.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Aluno> ObterTodosAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RA, Nome, Email, Telefone, DataNascimento FROM Aluno";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Aluno aluno = new Aluno
                    {
                        RA = Convert.ToInt32(reader["RA"]),
                        Nome = reader["Nome"].ToString(),
                        Email = reader["Email"].ToString(),
                        Telefone = reader["Telefone"].ToString(),
                        DataNascimento = Convert.ToDateTime(reader["DataNascimento"])
                    };
                    alunos.Add(aluno);
                }
            }

            return alunos;
        }

        public bool ExisteAluno(int ra)
        {
            bool existe = false;

            // Consulta SQL para verificar se o RA já existe
            string query = "SELECT COUNT(*) FROM Aluno WHERE RA = @RA";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RA", ra);

                connection.Open();

                // ExecuteScalar retorna o número de alunos com o RA fornecido
                int count = (int)command.ExecuteScalar();

                // Se o número for maior que 0, significa que o RA já existe
                if (count > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }

        public void RemoveAluno(int ra)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Aluno WHERE RA = @RA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RA", ra);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAluno(Aluno aluno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Aluno SET Nome = @Nome, Email = @Email, Telefone = @Telefone, DataNascimento = @DataNascimento WHERE RA = @RA";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", aluno.Nome);
                command.Parameters.AddWithValue("@Email", aluno.Email);
                command.Parameters.AddWithValue("@Telefone", aluno.Telefone);
                command.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);
                command.Parameters.AddWithValue("@RA", aluno.RA);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Aluno> BuscarAlunos(string nome, string email, string telefone, DateTime? dataNascimento)
        {
            List<Aluno> alunos = new List<Aluno>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Alunos WHERE 1=1");

                // Adiciona condições à consulta apenas para os campos preenchidos
                if (!string.IsNullOrEmpty(nome))
                {
                    queryBuilder.Append(" AND Nome LIKE @Nome");
                }
                if (!string.IsNullOrEmpty(email))
                {
                    queryBuilder.Append(" AND Email LIKE @Email");
                }
                if (!string.IsNullOrEmpty(telefone))
                {
                    queryBuilder.Append(" AND Telefone LIKE @Telefone");
                }
                if (dataNascimento.HasValue)
                {
                    queryBuilder.Append(" AND DataNascimento = @DataNascimento");
                }

                SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);

                // Adiciona parâmetros apenas para os campos preenchidos
                if (!string.IsNullOrEmpty(nome))
                {
                    command.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                }
                if (!string.IsNullOrEmpty(email))
                {
                    command.Parameters.AddWithValue("@Email", "%" + email + "%");
                }
                if (!string.IsNullOrEmpty(telefone))
                {
                    command.Parameters.AddWithValue("@Telefone", "%" + telefone + "%");
                }
                if (dataNascimento.HasValue)
                {
                    command.Parameters.AddWithValue("@DataNascimento", dataNascimento.Value);
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Lê os dados do aluno do SqlDataReader e adiciona à lista de alunos
                    // Lembre-se de ajustar isso conforme a estrutura da sua tabela Alunos
                    int ra = Convert.ToInt32(reader["RA"]);
                    string nomeAluno = reader["Nome"].ToString();
                    string emailAluno = reader["Email"].ToString();
                    string telefoneAluno = reader["Telefone"].ToString();
                    DateTime dataNascimentoAluno = Convert.ToDateTime(reader["DataNascimento"]);

                    Aluno aluno = new Aluno(ra, nomeAluno, emailAluno, telefoneAluno, dataNascimentoAluno);
                    alunos.Add(aluno);
                }

                reader.Close();
            }

            return alunos;
        }

    }
}