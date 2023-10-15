using _12LINQOperacaoElementosII;
using System;

Console.WriteLine("12 - Operação de Elementos - parte II\n");

Console.WriteLine("Last\n");
Console.WriteLine("Sem condicionante:\n");
/* Retorna o último elemento de uma coleção/sequência.
 * Lança "ArgumentNullException se a coleção for "null" e 
 "InvalidOperationException" se a coleção for vazia.*/

List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
List<int> numeros2 = new List<int>();

Console.WriteLine("Lista:");

numeros.ForEach(num => Console.Write($"{num} "));

Console.WriteLine();
try
{
    int num = numeros.Last();
    Console.WriteLine($"\nÚltimo elemento da lista: {num}");
    Console.WriteLine($"\nÚltimo elemento da lista, menor que 55: {numeros.Last(num => num < 55)}");
    Console.WriteLine($"\nÚltimo elemento da lista vazia: {numeros2.Last()}"); //InvalidOperationException
    
}
catch (Exception ex)
{
    Console.WriteLine("\nErro no 'Last':");
    Console.WriteLine($"{ex}: {ex.Message}\n");
    Console.WriteLine();
}

Console.WriteLine("\nLastOrDefault:");

Console.WriteLine($"\nÚltimo elemento da lista: {numeros.LastOrDefault()}");//retorna o último elemento da Lista
Console.WriteLine($"\nÚltimo elemento da lista, menor que 55: {numeros.LastOrDefault(num => num < 55)}");
Console.WriteLine($"\nÚltimo elemento da lista vazia: {numeros2.LastOrDefault()}"); //Retorna o "default", no caso "0" pois é uma lista de int

Console.WriteLine("\nSingle:\n");

numeros = new List<int>() { 10 };
//A lista foi substituida por um lista de um único elemento

Console.WriteLine("Lista: ");
numeros.ForEach(num => Console.Write(num));

Console.WriteLine();

try
{
    Console.WriteLine($"\nÚnico elemento da lista: {numeros.Single()}");//10
    
    numeros = new List<int> { 10, 20, 30 };
    Console.WriteLine("\nLista: ");
    numeros.ForEach(num => Console.Write($"{num} "));
    
    Console.WriteLine();
    Console.WriteLine($"\nÚnico elemento da lista, maior que 20: {numeros.Single(num => num > 20)}");
    Console.WriteLine($"\nÚnico elemento da lista, maior que 10 (mais de um elemento atende a condição): {numeros.Single(num => num > 10)}"); //InvalidOperationException

}
catch (Exception ex)
{
    Console.WriteLine("\nErro no 'Single':");
    Console.WriteLine($"{ex}: {ex.Message}\n");
    Console.WriteLine();
}

Console.WriteLine("\nSingleOrDefault:");

numeros = new List<int>() { 10 };
Console.WriteLine("\nLista: ");
numeros.ForEach(num => Console.Write(num));

Console.WriteLine();
try
{
    Console.WriteLine($"\nÚnico elemento da lista: {numeros.SingleOrDefault()}");//10

    numeros = new List<int> { 10, 20, 30 };
    Console.WriteLine("\nLista: ");
    numeros.ForEach(num => Console.Write($"{num} "));

    Console.WriteLine();
    Console.WriteLine($"\nÚnico elemento da lista, maior que 20: {numeros.SingleOrDefault(num => num > 20)}");
    Console.WriteLine($"\nÚnico elemento da lista, maior que 50 (nenhum elemento atende a condição): {numeros.SingleOrDefault(num => num > 50)}"); //Retorna o "default", no caso "0" pois é uma lista de int
    Console.WriteLine($"\nÚnico elemento da lista, maior que 10 (mais de um elemento atende a condição): {numeros.SingleOrDefault(num => num > 10)}"); //InvalidOperationException
}
catch (Exception ex)
{
    Console.WriteLine("\nErro no 'SingleOrDefault':");
    Console.WriteLine($"{ex}: {ex.Message}\n");
    Console.WriteLine();
}

Console.WriteLine("\nDefaultIfEmpty:");

numeros = new List<int>() { 10, 20, 30 };
IEnumerable<int> resultado = numeros.DefaultIfEmpty();
Console.WriteLine("\nLista:");
foreach (int numero in resultado)
{
    Console.Write($"{numero} "); //10, 20, 30
}

resultado = numeros2.DefaultIfEmpty();
Console.WriteLine("\nLista:");
foreach (int numero in resultado)
{
    Console.Write($"{numero} "); //0 (default de Int)
}

resultado = numeros2.DefaultIfEmpty(5);
Console.WriteLine("\nLista:");
foreach (int numero in resultado)
{
    Console.Write($"{numero} "); //5 (Valor definido para retornar no lugar do default)
}

//Uso do DefaultIfEmpty
Console.WriteLine("\n\nUso 'DefaultIfEmpty':");

var filmes = new List<Filme>()
{
    new Filme ("Titanic", 7),
    new Filme ("De Volta para o futuro", 8),
    new Filme ("Mulher Maravilha", 6)
};

var filmeFavorito = new Filme("Intocáveis", 10);

Console.WriteLine("\nLista de filmes:");
var filmesOrdenados = filmes.OrderBy(filme => filme.Avaliacao);
foreach (Filme filme in filmesOrdenados)
    Console.WriteLine($"Título: {filme.Titulo}\tNota: {filme.Avaliacao}");

Console.WriteLine();

var filmeAAssistir = filmesOrdenados.Where(filme => filme.Avaliacao > 9)//filtra filmes com avaliação maior que a definida
                           .DefaultIfEmpty(filmeFavorito)//caso a lista esteja vazia, ou não atenda a condição, é retornado o valor padrão definido
                           .First();//retorna o elemento de acordo com a condição

Console.WriteLine("\nFilme a assistir:");
Console.WriteLine($"Título: {filmeAAssistir.Titulo}\tAvaliação: {filmeAAssistir.Avaliacao}");


Console.ReadKey();