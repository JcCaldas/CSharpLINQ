using _04LINQOperacoesConjuntosII;

Console.WriteLine("04 - LINQ Operações com Conjuntos parte II\n");

List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

Console.WriteLine("Intersect:\n");
//Exibe os elementos iguais das duas fontes de dados

//Sintaxe de Método
//var resultadoIntersect = fonte1.Intersect(fonte2).ToList();

//Sintaxe de Consulta LINQ
var resultadoIntersect = (from num in fonte1
                          select num).Intersect(fonte2).ToList();

resultadoIntersect.ForEach(x => Console.Write($"{x} "));

Console.WriteLine("\nIntersect com sobrecarga:\n");

List<string> paises = new() { "Brasil", "USA", "UK", "Argentina", "China" };
List<string> paises2 = new() { "Brasil", "uk", "Argentina", "França", "Japão" };

//Caso não utilize a sobrecarga do método, o item "uk" não será reconhecido como igual ao "UK", pois o comparador é Case Sentive

var resultado = paises.Intersect(paises2, StringComparer.OrdinalIgnoreCase).ToList();
resultado.ForEach(pais => Console.WriteLine($"{pais} "));

Console.WriteLine("\nIntersectBy:\n");
//Retornar os alunos que tem o mesmo ano de nascimento

var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();

var resultadoIntersectTurmas = turmaA.IntersectBy(turmaB.Select(aluno => aluno.Nascimento.Year), aluno => aluno.Nascimento.Year);

Console.WriteLine("Alunos da Turma A com o mesmo ano de nascimento dos alunos da Turma B:\n");

foreach (var aluno in resultadoIntersectTurmas)
{
    Console.WriteLine($"Nome: {aluno.Nome}\t Ano de nascimento: {aluno.Nascimento.Year}");

}
Console.WriteLine($"\nQuantidade de alunos com o mesmo ano de nascimento: {resultadoIntersectTurmas.Count()}");