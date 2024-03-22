using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste
{
    public class Aluno
    {
        public Aluno() { }
        public Aluno(int ra, string nome, string email, string telefone, DateTime dataNascimento)
        {
            this.RA = ra;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.DataNascimento = dataNascimento;
        }

        public int RA { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
