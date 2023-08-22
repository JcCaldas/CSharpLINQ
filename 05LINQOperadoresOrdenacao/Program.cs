using _05LINQOperadoresOrdenacao;

Console.WriteLine("05 - Operadores de Ordenação\n");

Console.WriteLine("OrderBy:\n");
//Ordena de forma crescente

var nomes = FonteDados.GetNomes();

Console.WriteLine("Crescente\n");
var nomesCrescente = nomes.OrderBy(nome => nome).ToList();

nomesCrescente.ForEach(nome => Console.Write($"{nome} "));

Console.WriteLine("\nDecrescente:\n");
var nomesDecrescente = nomes.OrderByDescending(nome => nome).ToList();

nomesDecrescente.ForEach(nome => Console.Write($"{nome} "));

//Para Sintaxe de consulta:
//crescente
/*var nomesOrdenados = (from nome in nomes
                      orderby nome ascending
                      select nome).ToList();*/
//decrescente
/*var nomesOrdenados = (from nome in nomes
                      orderby nome descending
                      select nome).ToList();*/

Console.WriteLine("\nThenBy:\n");
//Utiliza-se para complementar a ordem que será feita. Ex: ordem crescente de nome, seguida de ordem crescente de idade.
//Primeiro gera a ordem crescente de nome, e após pega-se essa lista e gera a ordem crescente de idade.

var alunos = FonteDados.GetAlunos();

var lista1 = alunos.OrderBy(aluno => aluno.Nome).ToList(); //ordena de forma ascendente por nome
lista1.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}"));
Console.WriteLine("\nUtizando filtro (where) para nomes que contém 'r' e depois ordenando");
//Utizando filtro (where) para nomes que contém 'r' e depois ordenando
var lista2 = alunos.Where(aluno => aluno.Nome.Contains("r")).OrderBy(aluno => aluno.Nome).ToList();
lista2.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}"));
Console.WriteLine("\nUtilizando filtro, ordenando por nome e por idade");
//Utilizando filtro, ordenando por nome e por idade
var lista3 = alunos.Where(aluno => aluno.Nome.Contains("r")).OrderBy(aluno => aluno.Nome).ThenBy(aluno => aluno.Idade).ToList();
lista3.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}"));
Console.WriteLine("\nUtilizando filtro e ordenando por nome e por idade de forma decrescente");
//Utilizando filtro e ordenando por nome e por idade de forma decrescente
var lista4 = alunos.Where(aluno => aluno.Nome.Contains("r")).OrderByDescending(aluno => aluno.Nome).ThenByDescending(aluno => aluno.Idade).ToList();
lista4.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}"));

Console.WriteLine("\nReverse:\n");
//Inverte ela na mesma váriavel.
var listaNomes = FonteDados.GetNomes();
listaNomes.ForEach(nome => Console.WriteLine(nome));
Console.WriteLine();
listaNomes.Reverse();
listaNomes.ForEach(nome => Console.WriteLine(nome));

//voltar a ordem normal
listaNomes.Reverse();
//Se tentar armazenar a lista em outra variável, o Reverse da LINQ não será chamado e sim do System.Collections
//var listaInvertida = listaNomes.Reverse(); //Gera erro.

//Para armazenar em outra variável deve-se converter em IEnumerable<T> ou IQueryable<T>.
IEnumerable<string> listaIEnumerable = listaNomes.AsEnumerable().Reverse();
IQueryable<string> listaQueryable = listaIEnumerable.AsQueryable().Reverse();




Console.ReadKey();

