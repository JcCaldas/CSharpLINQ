using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LINQOperadoresOrdenacao;

public class FonteDados
{
    public static List<string> GetNomes()
    {
        var nomes = new List<string>()
        {"Paulo", "Tarcisio", "Alice", "Pedro", "Débora", "Helena", "Percival", "Manoel", "Rute", "José"};
        return nomes;
    }

    public static List<Alunos> GetAlunos()
    {
        List<Alunos> alunos = new List<Alunos>()
        {
            new Alunos() {Nome = "Maria", Idade = 20},
            new Alunos() {Nome = "Maria", Idade = 19},
            new Alunos() {Nome = "Manoel", Idade = 22},
            new Alunos() {Nome = "Miriam", Idade = 21},
            new Alunos() {Nome = "Mathias", Idade = 21}
        };
        return alunos;
        
    }
}