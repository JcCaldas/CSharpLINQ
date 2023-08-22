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

Console.WriteLine("\nUnion:\n");
//Exibe os elementos de dois conjuntos, exibindo apenas 1x os repetidos

List<int> fonteNumeros1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
List<int> fonteNumeros2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

//Sintaxe de método
var resultadoNumeros = fonteNumeros1.Union(fonteNumeros2).ToList();

//Sintaxe de Consulta
//var resultadoNumeros = (from num in fonteNumeros1 select num).Union(fonteNumeros2).ToList();

resultadoNumeros.ForEach(num => Console.Write($"{num} "));


Console.WriteLine("\nUnion com sobrecarga de método:\n");

var listaPaises = FonteDados.GetPaises();
var listaPaisess2 = FonteDados.GetPaises2();

var resultadoUniaoPaises = listaPaises.Union(listaPaisess2, StringComparer.OrdinalIgnoreCase).ToList();

resultadoUniaoPaises.ForEach(pais => Console.Write($"{pais} "));

Console.WriteLine("\n\nUnionBy:\n");
//Lista de alunos turma A e B juntando os nomes distintos

var alunosMesmoNome = turmaA.UnionBy(turmaB, aluno => aluno.Nome).ToList();

alunosMesmoNome.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}\tNasc.: {aluno.Nascimento.ToShortDateString()}"));