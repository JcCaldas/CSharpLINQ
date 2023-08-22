using _03LINQOperacoesConjuntosI;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("03 - LINQ Operações em Conjuntos parte I\n");

        Console.WriteLine("Distinct:\n");
        Console.WriteLine("Array de idades: 30, 33, 35, 36, 40, 30, 33, 35, 36, 40\n");
        //Com o método 'Distinct', é retirado do conjunto os termos duplicados.

        var idades = FonteDados.GetIdades().Distinct(); //Pode ser em formato de List ou Array, caso precise ser mais específico.

        Console.WriteLine("Idades únicas:");
        foreach (var idade in idades)
        {
            Console.Write($"{idade} ");
        }

        Console.WriteLine("\n\nArray de nomes: \"Paulo\", \"MARIA\", \"paulo\", \"Amanda\", \"maria\", \"amanda\"\n");

        //O comparador padrão do método 'Distinct' é case sensitive, ou seja, ele diferencia maíusculas de minúsculas.
        //Para que o método funcione, deve-se utilizar a sobrecarga.
        var nomes = FonteDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);//Ignora caixa alta e baixa.

        Console.WriteLine("Nomes Distintos:");
        foreach (var nome in nomes)
        {
            Console.Write($"{nome} ");
        }

        Console.WriteLine("\nDistinctBy:\n");

        Console.WriteLine("Lista de alunos:");
        var listaAlunos = FonteDados.GetAlunos().ToList();
        foreach(var alunos in listaAlunos)
        {
            Console.WriteLine($"Nome: {alunos.Nome}\tIdade: {alunos.Idade}");
        }

        Console.WriteLine("\nAlunos com idades Distintas:");
        var alunosIadesDistintas = listaAlunos.DistinctBy(a => a.Idade);

        foreach (var aluno in alunosIadesDistintas)
        {
            Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}");
        }


        Console.WriteLine("\nExcept\n");

        Console.WriteLine("Lista de paises 1:");
        var listaPaises1 = FonteDados.GetPaises().ToList();
        foreach (var pais in listaPaises1)
            Console.Write($"{pais} ");

        Console.WriteLine("\n\nLista de paises 2:");
        var listaPaises2 = FonteDados.GetPaises2().ToList();
        foreach(var pais in listaPaises2)
            Console.Write($"{pais} ");

        //utiliza-se a sobrecarga 'StringComparer.OrdinalIgnoreCase', para que o comparador ignore o case sensitive
        var paisesDistintos = FonteDados.GetPaises().Except(FonteDados.GetPaises2(), StringComparer.OrdinalIgnoreCase).ToList();

        Console.WriteLine("\n\nPaises distintos:");
        foreach (var pais in paisesDistintos)
        {
            Console.Write($"{pais} ");
        }

        Console.WriteLine("\n\nExceptBy");

        Console.WriteLine("Lista com nome de alunos:");
        var listaAlunosTotal = FonteDados.GetAlunos().ToList();
        listaAlunosTotal.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}"));

        Console.WriteLine("\nLista com nomes de alunso reprovados:");
        var nomesAlunosReprovados = new List<string>() {"Amanda", "Alicia", "Jaime" };
        nomesAlunosReprovados.ForEach(aluno => Console.WriteLine($"Nome: {aluno}"));

        Console.WriteLine("\nLista com alunos APROVADOS:");
        var nomesAlunosAprovados = listaAlunosTotal.ExceptBy(nomesAlunosReprovados, a => a.Nome).ToList();
        nomesAlunosAprovados.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}"));


    }
}