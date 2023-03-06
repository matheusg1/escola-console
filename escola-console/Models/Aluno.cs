using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_console.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public Guid Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }        
        public DateTime DataNascimento { get; set; }
        public int TurmaId { get; set; }

        public override string ToString()
        {
            return $"{AlunoId}   {Nome} {Sobrenome}";
        }
    }
}
