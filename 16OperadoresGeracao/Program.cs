Console.WriteLine("16 - Operadores de Geração\n");

Console.WriteLine("Range:\n");

/*Gera uma sequência de números inteiros dentro do intervalo definido.
 Lança "ArgumentOuOfRangeException" se o valor limite for menor que zero ou 
quando o valor inicial + limite-1 for maior que o "MaxValue"
Cria uma sequência de números começando em start e indo até count (start + count - 1)*/

Console.WriteLine("Números de 01 (inicial) a 10 (limite):\n");

IEnumerable<int> numeros = Enumerable.Range(1, 10);

foreach (int numero in numeros)
    Console.Write(numero + " ");

List<int> numerosLista = Enumerable.Range(1, 10).ToList(); //Lista
var numerosArray = Enumerable.Range(1, 10).ToArray(); //Array

Console.WriteLine("\n\nNúmeros invertidos (método 'Reverse'):\n");

numeros = Enumerable.Range(1, 10).Reverse();

foreach (int numero in numeros)
    Console.Write(numero + " ");

Console.WriteLine("\n\nFiltros:");
Console.WriteLine("Números pares entre 10 e 30:\n");

var pares = Enumerable.Range(10, 30).Where(num => num % 2 == 0);

foreach (int numero in pares)
    Console.Write(numero + " ");


Console.WriteLine("\n\nQuadrado de números entre 1 e 10:\n");

var quadrados = Enumerable.Range(1, 10).Select(num => num * num);

foreach (int numero in quadrados)
    Console.Write(numero + " ");


Console.WriteLine("\n\nRepeat:\n");

Console.WriteLine("Repetir 'Jessé' 5x:\n");

var nome = Enumerable.Repeat("Jessé", 5);
foreach (var n in nome)
    Console.Write(n + " ");

Console.WriteLine("\n\nRepetir número '7' 3x:\n");

var numeroRepetido = Enumerable.Repeat(7, 3);
foreach(var num in numeroRepetido)
    Console.Write(num + " ");


Console.WriteLine("\n\nEmpty:\n");
//Retorna uma coleção vazia do tipo definido

Console.WriteLine("Coleção vazia do tipo Int32:\n");

var vazio = Enumerable.Empty<int>(); //coleção vazia do tipo Int
foreach(var num in vazio)
    Console.Write(num + " -");
Console.WriteLine("Concluido");

Console.WriteLine("\nColeção vazia do Tipo 'String':\n");

var colecaoVazia1 = Enumerable.Empty<string>();
Console.WriteLine("Count: {0} ", colecaoVazia1.Count()); //O valor de Count é colocado no lugar de {0} (marcador de posição)
Console.WriteLine($"Tipo: {colecaoVazia1.GetType().Name} ");

Console.WriteLine("\nColeção vazia do Tipo 'Aluno':\n");

var colecaoVaziaAluno =Enumerable.Empty<Aluno>();
Console.WriteLine($"Count: {colecaoVaziaAluno.Count()}");
Console.WriteLine($"Tipo: {colecaoVaziaAluno.GetType().Name}");


Console.ReadKey();


public class Aluno
{
    public int ID { get; set; }
    public string? Nome { get; set; }
}