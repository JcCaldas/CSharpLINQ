using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LINQConsultas
{
    public class FonteDados
    {
        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1, 2, 4, 8, 16, 32, 64, 128, 256, 512
            };
            return numeros;
        }

        public static List<int> GetListaNegra()
        {
            List<int> numeros = new List<int>()
            {
                16, 128, 512
            };
            return numeros;
        }

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno {Nome = "Maria", Idade = 42},
                new Aluno {Nome = "Manoel", Idade = 34},
                new Aluno {Nome = "Amanda", Idade = 21},
                new Aluno {Nome = "Carlos", Idade = 18},
                new Aluno {Nome = "Alícia", Idade = 15},
            };
            return alunos;
        }
    }
}
