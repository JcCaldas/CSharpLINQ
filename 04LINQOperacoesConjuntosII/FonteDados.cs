using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04LINQOperacoesConjuntosII
{
    public class FonteDados
    {
        public static List<Aluno> GetTurmaA()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { Nome = "Maria", Idade = 36, Nascimento = new DateTime(2001, 6, 11) },
                new Aluno() { Nome = "Manoel", Idade = 33, Nascimento = new DateTime(2000, 2, 10) },
                new Aluno() { Nome = "Amanda", Idade = 21, Nascimento = new DateTime(1986, 9, 30) },
                new Aluno() { Nome = "Carlos", Idade = 18, Nascimento = new DateTime(1999, 10, 11) },
                new Aluno() { Nome = "Jaime", Idade = 36, Nascimento = new DateTime(1988, 9, 15) }
            };
            return alunos;
        }

        public static List<Aluno> GetTurmaB()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { Nome = "Homero", Idade = 26, Nascimento = new DateTime(1988, 9, 15) },
                new Aluno() { Nome = "Silvia", Idade = 31, Nascimento = new DateTime(2001, 9, 30) },
                new Aluno() { Nome = "Felicio", Idade = 21, Nascimento = new DateTime(1986, 9, 30) },
                new Aluno() { Nome = "Carlos", Idade = 18, Nascimento = new DateTime(2002, 8, 15) },
                new Aluno() { Nome = "Alfredo", Idade = 33, Nascimento = new DateTime(1999, 10, 11) },
                new Aluno() { Nome = "Denize", Idade = 30, Nascimento = new DateTime(2004, 11, 5) }
            };
            return alunos;
        }

        public static string[] GetPaises()
        {
            var paises = new[] { "Brasil", "USA", "UK", "Argentina", "China" };
            return paises;
        }

        public static string[] GetPaises2()
        {
            var paises = new[] { "Brasil", "uk", "Argentina", "França", "Japão" };
            return paises;
        }
    }
}
