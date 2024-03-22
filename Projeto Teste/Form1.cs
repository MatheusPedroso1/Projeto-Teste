using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Teste
{
    public partial class Form1 : Form
    {
        private AlunoAcessoDados alunoAcessoDados;
        private Form2 segundaPagina;
        private string connectionString;
        private bool databaseExists = false;

        public Form1(string connectionString)
        {
            InitializeComponent();
            alunoAcessoDados = new AlunoAcessoDados(connectionString);
            this.connectionString = connectionString;
            dgvAluno.CellClick += dgvAluno_CellClick;
        }


        public Form1(Form2 segundaPagina)
        {
            InitializeComponent();
            this.segundaPagina = segundaPagina;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código não utilizado para caso o usuário não tenha criado o banco de dados "ProjetoTeste"
            if (!databaseExists)
            {
                DialogResult result = MessageBox.Show("O banco de dados 'ProjetoTeste' não foi encontrado. Deseja criar o banco de dados e as tabelas agora?", "Criar Banco de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CreateDatabaseAndTables();
                }
                else
                {
                    MessageBox.Show("O programa será encerrado.", "Encerrar Programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            else
            {
                RefreshAlunos();
            }
        }

        private void RefreshAlunos()
        {
            dgvAluno.DataSource = alunoAcessoDados.ObterTodosAlunos();
        }

        private void button1_Click(object sender, EventArgs e) //btnAdicionar
        {
            if (string.IsNullOrEmpty(tbRA.Text) || string.IsNullOrEmpty(tbNome.Text) || string.IsNullOrEmpty(tbEmail.Text) ||string.IsNullOrEmpty(tbTelefone.Text) || dtpDataNascimento.Value == null)
            {
                // Se algum campo estiver vazio, exibir um popup alertando o usuário
                MessageBox.Show("Por favor, preencha todos os dados antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Retorna para que a operação de adicionar não seja realizada
            }

            if (!int.TryParse(tbRA.Text, out int ra))
            {
                // Se não for um número inteiro, exibir uma mensagem de erro
                MessageBox.Show("Apenas números inteiros são permitidos para o RA.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Retorna para que a operação de adicionar não seja realizada
            }


            if (alunoAcessoDados.ExisteAluno(ra))
            {
                MessageBox.Show("O RA fornecido já está em uso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nome = tbNome.Text;
                string email = tbEmail.Text;
                string telefone = tbTelefone.Text;
                DateTime dataNascimento = dtpDataNascimento.Value;

                Aluno aluno = new Aluno(ra, nome, email, telefone, dataNascimento);
                alunoAcessoDados.AdicionarAluno(aluno);

                RefreshAlunos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRA.Text) || string.IsNullOrEmpty(tbNome.Text) || string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbTelefone.Text) || dtpDataNascimento.Value == null)
            {
                MessageBox.Show("Por favor, preencha todos os dados antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbRA.Text, out int ra))
            {
                MessageBox.Show("Apenas números inteiros são permitidos para o RA.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvAluno.SelectedRows.Count > 0)
            {
                string nome = tbNome.Text;
                string email = tbEmail.Text;
                string telefone = tbTelefone.Text;
                DateTime dataNascimento = dtpDataNascimento.Value;

                Aluno aluno = new Aluno(ra, nome, email, telefone, dataNascimento);
                alunoAcessoDados.UpdateAluno(aluno);
                RefreshAlunos();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAluno.SelectedRows.Count > 0)
            {
                // Exibir uma caixa de diálogo de confirmação
                DialogResult result = MessageBox.Show("Tem certeza de que deseja remover este aluno? Esta ação não pode ser desfeita.", "Remover Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar a escolha do usuário
                if (result == DialogResult.Yes)
                {
                    int ra = Convert.ToInt32(dgvAluno.SelectedRows[0].Cells["RA"].Value);
                    alunoAcessoDados.RemoveAluno(ra);
                    RefreshAlunos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno para remover.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rbDesativado.Checked)
            {
                RefreshAlunos();
            }
            else
            {
                string query = "SELECT * FROM Aluno WHERE ";
                List<string> conditions = new List<string>();

                if (rbRA.Checked)
                {
                    int ra;
                    if (int.TryParse(tbRA.Text, out ra))
                        conditions.Add("RA = @RA");
                    else
                        MessageBox.Show("Por favor, preencha o campo RA com um número inteiro válido.", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rbNome.Checked)
                {
                    if (!string.IsNullOrEmpty(tbNome.Text))
                        conditions.Add("Nome LIKE @Nome");
                    else
                        MessageBox.Show("Por favor, preencha o campo Nome.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rbEmail.Checked)
                {
                    if (!string.IsNullOrEmpty(tbEmail.Text))
                        conditions.Add("Email LIKE @Email");
                    else
                        MessageBox.Show("Por favor, preencha o campo Email.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Combinar as condições em uma única string
                query += string.Join(" AND ", conditions);

                // Executar a consulta SQL com os parâmetros
                if (conditions.Any())
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        // Adicionar os parâmetros com base nos campos preenchidos
                        if (rbRA.Checked)
                            command.Parameters.AddWithValue("@RA", int.Parse(tbRA.Text));
                        if (!string.IsNullOrEmpty(tbNome.Text))
                            command.Parameters.AddWithValue("@Nome", $"%{tbNome.Text}%");
                        if (!string.IsNullOrEmpty(tbEmail.Text))
                            command.Parameters.AddWithValue("@Email", $"%{tbEmail.Text}%");

                        // Executar a consulta e atualizar o DataGridView
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        // Verificar se a consulta retornou resultados
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Valor pedido não encontrado!", "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dgvAluno.DataSource = dataTable;
                        }
                    }
                }
            }
        }


        private void btnProximo_Click(object sender, EventArgs e)
        {
            // Verifica se a instância da segunda página ainda não foi criada
            if (segundaPagina == null || segundaPagina.IsDisposed)
            {
                // Cria uma nova instância da segunda página (Livros)
                segundaPagina = new Form2(connectionString); // Passa a connectionString aqui

                // Exibe a segunda página (Livros)
                segundaPagina.Show();
            }
            else
            {
                // A segunda página já foi criada, apenas a exibe
                MessageBox.Show("A página de Livros já está aberta");
                segundaPagina.Show();
            }
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = dgvAluno.Rows[e.RowIndex];

                // Preenche os textboxes com os dados da linha selecionada
                tbRA.Text = row.Cells["RA"].Value.ToString();
                tbNome.Text = row.Cells["Nome"].Value.ToString();
                tbEmail.Text = row.Cells["Email"].Value.ToString();
                tbTelefone.Text = row.Cells["Telefone"].Value.ToString();
                dtpDataNascimento.Value = Convert.ToDateTime(row.Cells["DataNascimento"].Value);
            }
        }


        // Nada abaixo acabou sendo utilizado no programa
        private void CreateDatabaseAndTables()
        {
            string createDatabaseQuery = "CREATE DATABASE ProjetoTeste";

            string useDatabaseQuery = "USE ProjetoTeste";

            string createAlunoTableQuery = "CREATE TABLE Aluno (" +
                                           "RA INT PRIMARY KEY," +
                                           "Nome VARCHAR(100)," +
                                           "Email VARCHAR(100)," +
                                           "Telefone VARCHAR(15)," +
                                           "DataNascimento DATE)";

            string createLivroTableQuery = "CREATE TABLE Livro (" +
                                            "Codigo INT PRIMARY KEY," +
                                            "RA INT," +
                                            "Titulo VARCHAR(100)," +
                                            "Autor VARCHAR(100)," +
                                            "Categoria VARCHAR(50)," +
                                            "Editora VARCHAR(100)," +
                                            "FOREIGN KEY (RA) REFERENCES Aluno(RA))";

            string createEmprestimoLivroTableQuery = "CREATE TABLE EmprestimoLivro (" +
                                                      "Codigo INT PRIMARY KEY," +
                                                      "DataRetirada DATE," +
                                                      "DataEntrega DATE)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Cria o banco de dados
                    SqlCommand command = new SqlCommand(createDatabaseQuery, connection);
                    command.ExecuteNonQuery();

                    SqlCommand commandText = new SqlCommand(useDatabaseQuery, connection);
                    command.ExecuteNonQuery();

                    // Cria a tabela Aluno
                    command.CommandText = createAlunoTableQuery;
                    command.ExecuteNonQuery();

                    // Cria a tabela Livro
                    command.CommandText = createLivroTableQuery;
                    command.ExecuteNonQuery();

                    // Cria a tabela EmprestimoLivro
                    command.CommandText = createEmprestimoLivroTableQuery;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Banco de dados e tabelas criados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar o banco de dados e tabelas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btCriarDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                // Tente criar a database e as tabelas
                CreateDatabaseAndTables();
                MessageBox.Show("A database e as tabelas foram criadas com sucesso!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 1801)
                {
                    MessageBox.Show("A database já foi criada anteriormente.");
                }
                else
                {
                    MessageBox.Show("Erro ao criar a database e tabelas: " + ex.Message);
                }
            }
        }
    }
}
