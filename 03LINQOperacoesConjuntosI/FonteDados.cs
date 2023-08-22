using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LINQOperacoesConjuntosI
{
    public class FonteDados
    {
        public static int[] GetIdades()
        {
            var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 35, 36, 40 };
            return idades;
        }

        public static string[] GetNomes()
        {
            var nomes = new[] { "Paulo", "MARIA", "paulo", "Amanda", "maria", "amanda" };
            return nomes;
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

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() { Nome = "Maria", Idade = 36 },
                new Aluno() { Nome = "Manoel", Idade = 33 },
                new Aluno() { Nome = "Amanda", Idade = 21 },
                new Aluno() { Nome = "Carlos", Idade = 18 },
                new Aluno() { Nome = "Jaime", Idade = 36 },
                new Aluno() { Nome = "Débora", Idade = 33 },
                new Aluno() { Nome = "Alicia", Idade = 18 },
                new Aluno() { Nome = "Sandra", Idade = 19 },
            };
            return alunos;
        }

        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1,2, 4, 8, 16, 32, 64, 128, 256, 512
            };
            return numeros;
        }
    }

}
