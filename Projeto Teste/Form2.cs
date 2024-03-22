using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Teste
{
    public partial class Form2 : Form
    {
        private LivroAcessoDados livroAcessoDados;
        private string connectionString;

        public Form2(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString; // Atribui a connectionString recebida como argumento à variável de instância
            livroAcessoDados = new LivroAcessoDados(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshLivros();
        }

        private void RefreshLivros()
        {
            dgvLivros.DataSource = livroAcessoDados.ObterTodosLivros();
        }

        private void lblEditora_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // O botão de voltar para a primeira página foi removido
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodigo.Text) || string.IsNullOrEmpty(tbRA.Text) || string.IsNullOrEmpty(tbTitulo.Text) || string.IsNullOrEmpty(tbAutor.Text) || string.IsNullOrEmpty(tbCategoria.Text) || string.IsNullOrEmpty(tbEditora.Text) || dtpRetirada.Value == null || dtpEntrega.Value == null)
            {
                // Se algum campo estiver vazio, exibir um popup alertando o usuário
                MessageBox.Show("Por favor, preencha todos os dados antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Retorna para que a operação de adicionar não seja realizada
            }

            int ra;
            if (!int.TryParse(tbRA.Text, out ra))
            {
                MessageBox.Show("RA deve ser um número inteiro válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codigo;
            if (!int.TryParse(tbCodigo.Text, out codigo))
            {
                MessageBox.Show("Código deve ser um número inteiro válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string titulo = tbTitulo.Text;
            string autor = tbAutor.Text;
            string categoria = tbCategoria.Text;
            string editora = tbEditora.Text;
            DateTime dataRetirada = dtpRetirada.Value;
            DateTime dataEntrega = dtpEntrega.Value;

            Livro livro = new Livro(codigo, ra, titulo, autor, categoria, editora, dataRetirada, dataEntrega);
            livroAcessoDados.AdicionarLivro(livro);

            RefreshLivros();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodigo.Text) || string.IsNullOrEmpty(tbRA.Text) || string.IsNullOrEmpty(tbTitulo.Text) || string.IsNullOrEmpty(tbAutor.Text) || string.IsNullOrEmpty(tbCategoria.Text) || string.IsNullOrEmpty(tbEditora.Text) || dtpRetirada.Value == null || dtpEntrega.Value == null)
            {
                // Se algum campo estiver vazio, exibir um popup alertando o usuário
                MessageBox.Show("Por favor, preencha todos os dados antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Retorna para que a operação de adicionar não seja realizada
            }

            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                // Se não for um número inteiro, exibir uma mensagem de erro
                MessageBox.Show("Apenas números inteiros são permitidos para o Código.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Retorna sem executar a operação de edição
            }

            if (!int.TryParse(tbCodigo.Text, out int ra))
            {
                MessageBox.Show("Apenas números inteiros são permitidos para o RA.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvLivros.SelectedRows.Count > 0)
            {
                string titulo = tbTitulo.Text;
                string autor = tbAutor.Text;
                string categoria = tbCategoria.Text;
                string editora = tbEditora.Text;
                DateTime dataRetirada = dtpRetirada.Value;
                DateTime dataEntrega = dtpEntrega.Value;

                Livro livro = new Livro(codigo, ra, titulo, autor, categoria, editora, dataRetirada, dataEntrega);
                livroAcessoDados.UpdateLivro(livro);
                RefreshLivros();
            }
            else
            {
                MessageBox.Show("Selecione um livro para editar.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvLivros.SelectedRows.Count > 0)
            {
                // Exibir uma caixa de diálogo de confirmação
                DialogResult result = MessageBox.Show("Tem certeza de que deseja remover este livro? Esta ação não pode ser desfeita.", "Remover Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar a escolha do usuário
                if (result == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(dgvLivros.SelectedRows[0].Cells["Codigo"].Value);
                    livroAcessoDados.RemoveLivro(codigo);
                    RefreshLivros();
                }
            }
            else
            {
                MessageBox.Show("Selecione um livro para remover.");
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RefreshLivros();
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
