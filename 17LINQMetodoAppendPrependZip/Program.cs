Console.WriteLine("17 - Métodos Append<T>, Prepend<T> e Zip<T>\n");

Console.WriteLine("Append<T>:\n");
//Anexa um novo valor ao final da sequência

Console.WriteLine("Lista:");
var numeros = new List<int>() { 1, 2, 3, 4 };
numeros.ForEach(num => Console.Write(num + " "));

//cria uma cópia e adiciona o número "5", somente isso é uma maneira desnecessária
numeros.Append(5);

//Se for colocado apenas a lista, não será exibido o valor que foi adicionado, pois foi feitouma cópia com esse novo valor.
Console.WriteLine("\n\nLista informada e exibida de maneira errônea:");
Console.WriteLine(String.Join(", ", numeros));

//Maneira correta de exibir a lista
Console.WriteLine("\nLista informada e exibida de maneira correta:");
Console.WriteLine(String.Join(", ", numeros.Append(5)));

//Outra maneira é colocar a cópia da lista em uma variável
Console.WriteLine("\nLista informada e exibida de maneira correta através do armazenamentona variável:");
var resultado = numeros.Append(5);
Console.WriteLine(String.Join(", ", resultado));

//Criando uma nova sequência explicitamente
Console.WriteLine("\nNova sequência explicita:");
var novosNumeros = numeros.Append(5).ToList();
Console.WriteLine(String.Join(", ", novosNumeros));

//Strings
Console.WriteLine("\nStrings:\n");
var frutas = new List<string>() { "Uva", "Banana", "Laranja" };
Console.WriteLine("Lista original:");
Console.WriteLine(String.Join(", ", frutas));

Console.WriteLine("\nNova lista com adição de 'Abacaxi':");
var novasFrutas = frutas.Append("Abacaxi").ToList();
Console.WriteLine(String.Join(", ", novasFrutas));


Console.WriteLine("\nPrepend<T>:\n");
//Similar ao 'Append<T>', porém anexa o elemento ao início da lista

Console.WriteLine("Lista:");
var numeros2 = new List<int>() { 1, 2, 3, 4 };
numeros2.ForEach(num => Console.Write(num + " "));

//cria uma cópia e adiciona o número "5", somente isso é uma maneira desnecessária
numeros2.Prepend(5);

//Se for colocado apenas a lista, não será exibido o valor que foi adicionado, pois foi feitouma cópia com esse novo valor.
Console.WriteLine("\n\nLista informada e exibida de maneira errônea:");
Console.WriteLine(String.Join(", ", numeros2));

//Maneira correta de exibir a lista
Console.WriteLine("\nLista informada e exibida de maneira correta:");
Console.WriteLine(String.Join(", ", numeros2.Prepend(5)));

//Outra maneira é colocar a cópia da lista em uma variável
Console.WriteLine("\nLista informada e exibida de maneira correta através do armazenamentona variável:");
var resultado2 = numeros2.Prepend(5);
Console.WriteLine(String.Join(", ", resultado2));

//Criando uma nova sequência explicitamente
Console.WriteLine("\nNova sequência explicita:");
var novosNumeros2 = numeros2.Prepend(5).ToList();
Console.WriteLine(String.Join(", ", novosNumeros2));

//Strings
Console.WriteLine("\nStrings:\n");
var frutas2 = new List<string>() { "Uva", "Banana", "Laranja" };
Console.WriteLine("Lista original:");
Console.WriteLine(String.Join(", ", frutas2));

Console.WriteLine("\nNova lista com adição de 'Abacaxi':");
var novasFrutas2 = frutas2.Prepend("Abacaxi").ToList();
Console.WriteLine(String.Join(", ", novasFrutas2));

Console.WriteLine("\nZip<T>:\n");
/*Mescla duas sequências. Índice por índice (Índice 0 com índice 0, índice 1 com índice 1...)
 * Retornará uma sequência com a quantidade de índices da menor sequência.
 Pode-se misturar tipos diferentes, caso aja necessidade.*/

Console.WriteLine("Mistura de números com string:\n");

int[] numeros3 = Enumerable.Range(1, 5).Select(num => num * 10).ToArray();
Console.WriteLine("Lista numérica:");
Console.WriteLine(String.Join(", ", numeros3));

string[] numerosExtenso = { "Dez", "Vinte", "Trinta", "Quarenta" };
Console.WriteLine("\nLista de números por extenso:");
Console.WriteLine(String.Join(", ", numerosExtenso));

Console.WriteLine("\nListas unidas:");
var resultadoZip = numeros3.Zip(numerosExtenso, (prim, seg) => prim + " - " + seg);

foreach (var item in resultadoZip)
    Console.WriteLine(item);

Console.WriteLine("\n\nOperações com Zip:\n");

Console.WriteLine("Sequência 1:");
var seq1 = Enumerable.Range(1, 5).ToArray();
foreach (var num in seq1)
    Console.Write(num + " ");

Console.WriteLine("\n\nSequência 2:");
var seq2 = Enumerable.Range(1, 3).Select(num => num * 10).ToArray();
foreach (var num in seq2)
    Console.Write(num + " ");

Console.WriteLine("\n\nItem da sequência 1 * Item da sequência 2:");
var resultadoSequencias = seq1.Zip(seq2, (s1, s2) => s1 * s2);
foreach(var num in resultadoSequencias)
    Console.Write(num + " ");

Console.WriteLine("\n\nUtilização com Strings:\n");

Console.WriteLine("Lista de Estados:");
var estados = new[] { "São Paulo", "Espírito Santo", "Rio Grande do Sul" };
foreach (var estado in estados)
    Console.Write(estado + " ");

Console.WriteLine("\n\nLista Siglas:");
var siglas = new[] { "SP", "ES", "RS" };
foreach (var sigla in siglas)
    Console.Write(sigla + " ");

Console.WriteLine("\n\nJunção das listas com Zip:");
var estadosSiglas = estados.Zip(siglas, (est, sigl) => est + " - " + sigl);
foreach (var est in estadosSiglas)
    Console.Write(est + ", ");



Console.ReadKey();