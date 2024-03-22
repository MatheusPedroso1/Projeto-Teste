using System;

namespace Projeto_Teste
{
    public class Livro
    {
        public Livro() { }

        public Livro(int codigo, int ra, string titulo, string autor, string categoria, string editora, DateTime dataRetirada, DateTime dataEntrega)
        {
            this.Codigo = codigo;
            this.RA = ra;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Categoria = categoria;
            this.Editora = editora;
            this.DataRetirada = dataRetirada;
            this.DataEntrega = dataEntrega;
        }

        public int Codigo { get; set; }
        public int RA { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public string Editora { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
