using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LINQOperacaoQuantificacao
{
    public class FonteDados
    {
        public static List<Funcionario> GetFuncionarios ()
        {
            List<Funcionario> funcionarios = new()
            {
                new Funcionario() { Nome = "Maria", Idade = 22, Salario = 3290.55m},
                new Funcionario() { Nome = "Manoel", Idade = 24, Salario = 2480.45m},
                new Funcionario() { Nome = "Amanda", Idade = 21, Salario = 5123.99m},
                new Funcionario() { Nome = "Carlos", Idade = 18, Salario = 6200.50m},
                new Funcionario() { Nome = "Alicia", Idade = 17, Salario = 4099.11m},

            };
            return funcionarios;
        }

        public static List <Pessoa> GetPessoa ()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa {Nome = "Maria",
                            Cachorros = new Cachorro[]
                            {
                                new Cachorro { Nome = "Bilu", Idade = 10},
                                new Cachorro { Nome = "Pipoca", Idade = 14},
                                new Cachorro { Nome = "Negão", Idade = 6}
                            }
                },
                new Pessoa {Nome = "Fernando",
                            Cachorros = new Cachorro[]
                            {
                                new Cachorro { Nome = "Canelinha", Idade = 1}
                            }
                },
                new Pessoa {Nome = "Amanda",
                            Cachorros = new Cachorro[]
                            {
                                new Cachorro { Nome = "Bisteca", Idade = 8}
                            }
                },
                new Pessoa {Nome = "Patrícia",
                            Cachorros = new Cachorro[]
                            {
                                new Cachorro { Nome = "Acerola", Idade = 2},
                                new Cachorro { Nome = "Mel", Idade = 13}
                            }
                }
            };
            return pessoas;
        }

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() {Nome = "Maria", Pontos = 275},
                new Aluno() {Nome = "Marta", Pontos = 235},
                new Aluno() {Nome = "Pedro", Pontos = 299}
            };
            return alunos;
        }
    }
}
