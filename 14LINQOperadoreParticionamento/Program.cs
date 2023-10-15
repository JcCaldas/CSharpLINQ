Console.WriteLine("14 - Operadores de Particionamento\n");

List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine("Lista:");
numeros.ForEach(x => Console.Write(x + " "));

Console.WriteLine("\n\nTake:\n");

Console.WriteLine("4 primeiro elementos:");
var resultado = numeros.Take(4).ToList(); //Pega os 4 primeiros elementos.
resultado.ForEach(num => Console.Write(num + " "));

Console.WriteLine("\n\n4 primeiros elementos após ordenação descedente:");
var resultado2 = numeros.OrderByDescending(num => num).Take(4).ToList(); //pega os 4 primeiros elementos, após a lista ser ordenada
resultado2.ForEach(num => Console.Write(num + " "));

Console.WriteLine("\n\n4 primeiros elementos após ordenação descedente e filtro aplicado (num < 6):");
var resultado3 = numeros.OrderByDescending(num => num).Where(num => num < 6).Take(4).ToList(); //pega os 4 primeiros elementos, após a lista ser ordenada e ter passado pelo filtro
resultado3.ForEach(num => Console.Write(num + " "));

Console.WriteLine("\n\n4 primeiros elementos após ordenação descedente e filtro aplicado nos 4 elementos (num < 8):");
var resultado4 = numeros.OrderByDescending(num => num).Take(4).Where(num => num < 8).ToList(); //pega os 4 primeiros elementos, após a lista ser ordenada e depois aplica o filtro
resultado4.ForEach(num => Console.Write(num + " "));


Console.WriteLine("\n\nTakeWhile:\n");
//Lê cada elemento até que a condição seja falsa, então para, mesmo que outros elementos atendam a condição.

numeros = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };

Console.WriteLine("Lista:");
numeros.ForEach(x => Console.Write(x + " "));

Console.WriteLine("\n\nPega os elementos que atendem a condição (num < 6):");
var resultado5 = numeros.TakeWhile(num => num < 6).ToList();
resultado5.ForEach(num => Console.Write(num + " "));

Console.WriteLine("\n\nComparando com Where (percorre a lista inteira):");
var resultado6 = numeros.Where(num => num < 6).ToList();
resultado6.ForEach(num => Console.Write(num + " "));

//Sobrecarga do método (usando índice na lógica da condição)
                        //Indice:  0       1       2       3       4
var nomes = new List<string>() { "Sara", "Raul", "José", "Ana", "Pedro" };
Console.WriteLine("\n\nLista de nomes:");
nomes.ForEach(nomes => Console.Write(nomes + " "));

Console.WriteLine("\n\nExibindo os elementos que tem a quantidade de letras maiores que o índice:");
var resultado7 = nomes.TakeWhile((nome, index) => nome.Length > index).ToList();
resultado7.ForEach(nome => Console.Write(nome + " "));


Console.WriteLine("\n\nSkip:\n");
//funciona de forma similar ao "take", mas ao invés de pegar o número de elementos definido, ele salta.

Console.WriteLine("Lista:");
numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3 };
numeros.ForEach(x => Console.Write(x + " "));

Console.WriteLine("\n\nSalta os 4 primeiros elementos da lista:");
var resultado8 = numeros.Skip(4).ToList();
resultado8.ForEach(num => Console.Write(num + " "));

Console.WriteLine("\n\nSalta os 4 primeiros elementos da lista, após a filtragem (num > 3):");
var resultado9 = numeros.Where(num => num > 3 ).Skip(4).ToList();
resultado9.ForEach(num => Console.Write(num + " "));

Console.WriteLine("\n\nSalta os 4 primeiros elementos da lista e após isso faz a filtragem (num > 6)");
var resultado10 = numeros.Skip(4).Where(num => num > 6).ToList();
resultado10.ForEach(num => Console.Write(num + " "));

Console.WriteLine("\n\nSkipWhile:\n");
//Mesma lógica do "TakeWhile", verifica até que a condição seja falsa, e retorna o resto dos elementos independente da condição

Console.WriteLine("Ignora os elementos < 5:");
var resultado11 = numeros.SkipWhile(num => num < 5).ToList();
resultado11.ForEach(numm =>  Console.Write(numm + " "));

//Sobrecarga do método (usando índice na lógica da condição)
Console.WriteLine("\n\nLista de nomes:");
nomes.ForEach(nomes => Console.Write(nomes + " "));

Console.WriteLine("\n\nExibindo os elementos que tem a quantidade de letras maiores que o índice:");
var resultado12 = nomes.SkipWhile((nome, index) => nome.Length > index).ToList();
resultado12.ForEach(nome => Console.Write(nome + " "));


Console.ReadKey();