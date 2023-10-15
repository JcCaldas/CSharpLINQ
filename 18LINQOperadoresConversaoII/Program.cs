using System.Collections;
using System.Linq.Expressions;

Console.WriteLine("18 - Operação de Elementos - parte II\n");
//ParteI item 13

Console.WriteLine("AsEnumerable:\n");
//converte o tipo específico de uma lista ou array em equivalente de IEnumerable()

Console.WriteLine("Arrays:");
Console.WriteLine("Array de números:");
int[] numeros = Enumerable.Range(1, 5).ToArray();
foreach (int numero in numeros)
    Console.Write(numero + " ");

Console.WriteLine("\n\nIEnumerable convertido do Array:");
var numerosConvertidos = numeros.AsEnumerable();
//converte o Array em IEnumerable()
foreach (int numero in numerosConvertidos)
    Console.Write(numero + " ");

Console.WriteLine("\n\nListas:");
Console.WriteLine("Lista de Países:");
var paises = new List<string>() { "US", "Índia", "UK", "Austrália", "Canadá" };
paises.ForEach(pais => Console.Write(pais + " "));

Console.WriteLine("\n\nIEnumerable convertido da Lista:");
var paisesConvertidos = paises.AsEnumerable();
foreach (var pais in paisesConvertidos)
    Console.Write(pais + " ");


Console.WriteLine("\n\nAsQueryable:\n");
//Transforma uma lista ou array em um Queryable

Console.WriteLine("Lista números:");
var numeros2 = new List<int>() { 78, 92, 100, 37, 81 };
numeros2.ForEach(num => Console.Write(num + " "));

var numeros2Queryable = numeros2.AsQueryable(); //conversão

Expression expressionTree = numeros2Queryable.Expression;

Console.WriteLine($"\n\nNodeTyde da árvore de expressão: {expressionTree.NodeType.ToString()}");
Console.WriteLine($"\nTipo da árvores de expressão: {expressionTree.Type.Name}");

Console.WriteLine("\nLista Queryable:");
foreach (var num in numeros2Queryable)
    Console.Write(num + " ");

Console.WriteLine("\n\nArray de números:");
var numeros3 = new int[] { 5, 10, 20, 60, 72, 90, 102, 114};
foreach (var num in numeros3 )
    Console.Write(num + " ");

var numeros3Queryable = numeros3.AsQueryable(); //conversão

var media = numeros3Queryable.Average();
// ou
var media2 = Queryable.Average(numeros3Queryable);

Console.WriteLine($"\n\nMédia: {media}");
Console.WriteLine($"\n\nMédia: {media2}");

var soma = numeros3Queryable.Sum();
//ou
var soma2 = Queryable.Sum(numeros3Queryable);

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Soma: " + soma2);

var quantidade = numeros3Queryable.Count();
//ou
var quantidade2 = Queryable.Count(numeros3Queryable);

Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("Quantidade: " + quantidade2);

var maximo = numeros3Queryable.Max();
//ou
var maximo2 = Queryable.Max(numeros3Queryable);
Console.WriteLine("Maior valor: " + maximo);
Console.WriteLine("Maior valor: " + maximo2);

var minimo = numeros3Queryable.Min();
//ou
var minimo2 = Queryable.Min(numeros3Queryable);
Console.WriteLine("Menor valor: " + minimo);
Console.WriteLine("Menor valor: " + minimo2);

Console.WriteLine("\nCast:\n");
/*Tenta converter todos os itens de uma coleção em outro tipo e retorná-los
 * em uma nova coleção com os elementos convertidos no tipo especificado*/
try
{

    ArrayList lista = new ArrayList() { 10, 20, 30 };
    IEnumerable<int> lista2 = lista.Cast<int>();

    //lista.Add("10"); //lança "InvalidCastException"

    foreach (int i in lista2)
        Console.Write(i + " ");
    Console.WriteLine();
}
catch (Exception ex)
{
    Console.WriteLine("\n");
    Console.WriteLine(ex);
    Console.WriteLine("\n" + ex.Message);
}

Console.WriteLine("\nOfType:\n");
/*Cria um "filtro" que retorna apenas os elementos do tipo indicado*/

Console.WriteLine("Lista de objetos completa:\n");
List<object> dados = new List<object>()
{
    "Tânia", 35, "Maria", 50, "Manoel", 20, "Thiago", 40, 60, 70, 3, 300
};
dados.ForEach(item => Console.Write(item + ", "));

Console.WriteLine("\n\nLista de objetos com 'OfType' de Int (retorna somente 'int'):");
var dadosInt = dados.OfType<int>().ToList();
dadosInt.ForEach(item => Console.Write(item + " "));

Console.WriteLine("\n\nLista de objetos com 'OfType' de String (retorna somente 'string'):");
var dadosString = dados.OfType<string>().ToList();
dadosString.ForEach(item => Console.Write(item + " "));

Console.WriteLine("\n\nLista de objetos com 'OfType' de Int e filtro de número >= 30:");
var dadosMaior30 = dados.OfType<int>().Where(num => num >= 30).ToList();
dadosMaior30.ForEach(item => Console.Write(item + " "));


Console.ReadKey();