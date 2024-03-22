using System;

namespace Projeto_Teste
{
    public class EmprestimoLivro
    {
        public EmprestimoLivro() { }
        public EmprestimoLivro(int codigo, DateTime dataRetirada, DateTime dataEntrega)
        {
            this.Codigo = codigo;
            this.DataRetirada = dataRetirada;
            this.DataEntrega = dataEntrega;
        }

        public int Codigo { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
