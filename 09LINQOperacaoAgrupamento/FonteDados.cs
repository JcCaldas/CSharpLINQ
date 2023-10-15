using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LINQOperacaoAgrupamento
{
    public class FonteDados
    {
        public static List<Alunos> GetAlunos()
        {
            List<Alunos> alunos = new List<Alunos>()
            {
                new Alunos() {AlunoId = 1, Curso = "Física", Nome = "Vitor", Sexo = 'M', Idade = 18},
                new Alunos() {AlunoId = 2, Curso = "Quimica", Nome = "Jorge", Sexo = 'M', Idade = 21},
                new Alunos() {AlunoId = 3, Curso = "Engenharia", Nome = "Bernardo", Sexo = 'M', Idade = 18},
                new Alunos() {AlunoId = 4, Curso = "Moda", Nome = "Danusa", Sexo = 'F', Idade = 19},
                new Alunos() {AlunoId = 5, Curso = "Moda", Nome = "Carla", Sexo = 'F', Idade = 20},
                new Alunos() {AlunoId = 6, Curso = "Física", Nome = "Hélio", Sexo = 'M', Idade = 21},
                new Alunos() {AlunoId = 7, Curso = "Engenharia", Nome = "Bianca", Sexo = 'F', Idade = 19},
                new Alunos() {AlunoId = 8, Curso = "Quimica", Nome = "Vilma", Sexo = 'F', Idade = 20},
                new Alunos() {AlunoId = 9, Curso = "Engenharia", Nome = "Amanda", Sexo = 'F', Idade = 18},
                new Alunos() {AlunoId = 10, Curso = "Quimica", Nome = "Silvia", Sexo = 'F', Idade = 21}
            };
            return alunos;
        }
    }
}
