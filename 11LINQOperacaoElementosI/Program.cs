using _11LINQOperacaoElementosI;

Console.WriteLine("11 - Operação de Elementos - parte I\n");


Console.WriteLine("ElementoAt\n");
/*Caso o elemento esteja vazio ou o índice esteja fora do intervalo
 ira retornar um "ArgumentOutOfRangeException"*/
Console.WriteLine("Elementos simples:\n");

List<int> numeros = new List<int>()
{
    10, 20, 30, 50, 60, 70, 80, 90, 100
};

Console.Write($"Lista: ");
numeros.ForEach(num => Console.Write($"{num} "));

Console.WriteLine();

Console.WriteLine($"\n'ElementAt' no índice 5: {numeros.ElementAt(5)}\n");

Console.WriteLine("Elementos complexos:\n");

Console.WriteLine("Lista de alunos:");
var alunos = FonteDados.GetAlunos();
alunos.ForEach(alunos => Console.WriteLine($"ID: {alunos.Id}\tNome: {alunos.Nome}\tCursoID: {alunos.CursoId}"));


Console.WriteLine("\n'ElementAt' no índice 8 (retorno objeto):");
var aluno = FonteDados.GetAlunos().ElementAt(8); //retorna um objeto
Console.WriteLine($"ID: {aluno.Id}\tNome: {aluno.Nome}\tCursoID: {aluno.CursoId}");

Console.WriteLine("\nRetorno de string do índice 9");
var nome = FonteDados.GetAlunos().Select(aluno => aluno.Nome).ElementAt(9); //retorna uma string
Console.WriteLine($"Nome: {nome}");

Console.WriteLine("\n'ElementAtOrDefault\n");
/*Caso o elemento esteja vazio ou o índice esteja fora do intervalo
 ira retornar o valor padrão do tipo*/

Console.Write($"Lista: ");
numeros.ForEach(num => Console.Write($"{num} "));

Console.WriteLine();
Console.WriteLine($"\n'ElementAtOrDefault' no índice 5: {numeros.ElementAtOrDefault(5)}\n");
Console.WriteLine($"\n'ElementAtOrDefault' no índice 15: {numeros.ElementAtOrDefault(15)}\n");

Console.WriteLine("Elementos complexos:\n");

Console.WriteLine("Lista de alunos:");
var alunos2 = FonteDados.GetAlunos();
alunos2.ForEach(alunos => Console.WriteLine($"ID: {alunos.Id}\tNome: {alunos.Nome}\tCursoID: {alunos.CursoId}"));


Console.WriteLine("\n'ElementAtOrDefault' no índice 8 (retorno objeto):");
var aluno2 = FonteDados.GetAlunos().ElementAtOrDefault(8); //retorna um objeto
Console.WriteLine($"ID: {aluno2.Id}\tNome: {aluno2.Nome}\tCursoID: {aluno2.CursoId}");

Console.WriteLine("\nRetorno de string do índice 9");
var nome2 = FonteDados.GetAlunos().Select(aluno => aluno.Nome).ElementAt(9); //retorna uma string
Console.WriteLine($"Nome: {nome2}\n");

Console.WriteLine("First\n");

Console.Write($"Lista: ");
numeros.ForEach(num => Console.Write($"{num} "));

Console.WriteLine();
Console.WriteLine($"\nPrimeiro número da lista: {numeros.First()}");
Console.WriteLine($"\nPrimeiro número da lista que seja maior que 20: {numeros.First(n => n > 20)}");
//Caso o resultado não atenda a condição será retornado um 'IvalidOperationException'

Console.WriteLine("Elementos complexos:\n");

Console.WriteLine("Lista de alunos:");
var alunos3 = FonteDados.GetAlunos();
alunos3.ForEach(alunos => Console.WriteLine($"ID: {alunos.Id}\tNome: {alunos.Nome}\tCursoID: {alunos.CursoId}"));

Console.WriteLine("\nPrimeiro aluno com Id Curso igual a 30\n");
var primeiroAluno = alunos3.First(aluno => aluno.CursoId == 30);
Console.WriteLine($"ID: {primeiroAluno.Id}\tNome: {primeiroAluno.Nome}\tCursoID: {primeiroAluno.CursoId}");

Console.WriteLine("FirstOrDefault\n");

Console.Write($"Lista: ");
numeros.ForEach(num => Console.Write($"{num} "));

Console.WriteLine();
Console.WriteLine($"\nPrimeiro número da lista: {numeros.FirstOrDefault()}");
Console.WriteLine($"\nPrimeiro número da lista que seja maior que 110: {numeros.FirstOrDefault(n => n > 110)}");
//Caso o resultado não atenda a condição será retornado um 'IvalidOperationException'


Console.ReadKey();