using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LINQProjecao
{
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public int Nota { get; set; }
        public List<string> Cursos { get; set; } = new List<string>();
    }
}
