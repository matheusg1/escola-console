using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_console.Models
{
    public class Escola
    {
        public int EscolaId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public IEnumerable<Turma> Turmas { get; set; }
        public int? QuantidadeTurmas { get; set; }
    }
}
