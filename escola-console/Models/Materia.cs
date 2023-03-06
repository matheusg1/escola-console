using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_console.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nome { get; set; }
        public string Professor { get; set; }
        public int TurmaId { get; set; }

        public override string ToString()
        {
            return $"{MateriaId}   {Nome}";
        }
    }
}
