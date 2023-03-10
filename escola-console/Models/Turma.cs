using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_console.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string Codigo { get; set; }
        public int EscolaId { get; set; }
        public IEnumerable<Materia> Materias { get; set; }
        public IEnumerable<Aluno> Alunos { get; set; }
        public int? QuantidadeMaterias { get; set; }
        public int? QuantidadeAlunos { get; set; }

        public override string ToString()
        {
            return $"{TurmaId}   {Codigo}";
        }
    }
}
