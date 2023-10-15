using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LINQOperacaoQuantificacao
{
    public class AlunoComparer : IEqualityComparer<Aluno>
    {
        //Alunos são iguais se os nomes e os pontos forem iguais
        public bool Equals (Aluno x, Aluno y)
        {
            //Se ambas referências dos objetos forem iguais retorna true
            if (object.ReferenceEquals (x, y))
                return true;

            //Se uma das referências for null retorna false
            if (x is null || y is null)
                return false;

            return x.Nome == y.Nome && x.Pontos == y.Pontos;
        }

        //Se Equals() retornar true para o par de objetos
        //GetHashCode() tem que retornar os mesmo valores para os objetos
        public int GetHashCode (Aluno obj)
        {
            //Se o objeto for null retorna 0
            if (obj == null)
                return 0;

            int NomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
            int PontosHashCode = obj.Pontos.GetHashCode();
            return NomeHashCode ^ PontosHashCode;
        }
    }
}
