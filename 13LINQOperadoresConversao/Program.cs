using _13LINQOperadoresConversao;
using System.Reflection.Emit;

Console.WriteLine("13 - Operação de Elementos - parte I\n");
//ParteII item 18

Console.WriteLine("ToList:\n");

string[] paises = { "Brasil", "EUA", "UK", "França", "Bélgica" };

var resultado = paises.ToList(); //transforma o array em lista
resultado.ForEach(pais => Console.WriteLine($"País: {pais}"));


Console.WriteLine();

var alunos = FonteDados.GetAlunos();
var listaAlunos = alunos.Where(a => a.Nome.Contains('M')).ToList(); //retorna uma lista de alunos que contem 'M' maíusculo no nome;

Console.WriteLine("Alunos com 'M' maiúsculo no nome:");
listaAlunos.ForEach(a => Console.WriteLine($"Nome: {a.Nome}"));

Console.WriteLine();

Console.WriteLine("\nToArray:\n");
var listaAlunosArray = alunos.Where(a => a.Nome.Contains('a')).ToArray(); //retorna uma lista de alunos que contem 'a' minúsculo no nome;

Console.WriteLine("Alunos com 'a' minúsculo no nome:");

foreach (var a in listaAlunosArray)
    Console.WriteLine($"Nome: {a.Nome}");

Console.WriteLine();

//List<Pacote> pacotes = new List<Pacote>()
//{
//    new Pacote {Empresa = "Google", Peso = 25.2},
//    new Pacote {Empresa = "JcmSoft", Peso = 18.7},
//    new Pacote {Empresa = "Twitter", Peso = 33.8}
//};
//ou
IEnumerable<Pacote> pacotes = new List<Pacote>()
{
    new Pacote {Empresa = "Google", Peso = 25.2},
    new Pacote {Empresa = "JcmSoft", Peso = 18.7},
    new Pacote {Empresa = "Twitter", Peso = 33.8}
}.AsEnumerable();

string[] empresas = pacotes.Select(pct => pct.Empresa).ToArray();

foreach (var empresa in empresas)
    Console.WriteLine($"Empresa: {empresa}");

Console.WriteLine("\nToDictionary:\n");

var listDic = alunos.ToDictionary<Aluno, int>(alunos => alunos.Id); //Não pode ter valores de chaves duplicados, pois gera uma ArgumentException

foreach (var chave in listDic.Keys)
    Console.WriteLine($"Chave: {chave}\t Valor: {(listDic[chave] as Aluno).Nome}"); //Cast da listdic na posição chave em tipo Aluno

Console.WriteLine();
Console.WriteLine("\nToLookUp:\n");

var funcionarios = FonteDados.GetFuncionarios();

//Agrupar por Cargo
Console.WriteLine("Funcionarios agrupados por cargo:");
var funcCargo = funcionarios.ToLookup(func => func.Cargo);//define a chave

foreach (var chave in funcCargo)
{
    Console.WriteLine($"\nCargo: {chave.Key}");//exibe a chave

    foreach (var item in funcCargo[chave.Key])
    {
        Console.WriteLine($"\tNome: {item.Nome}\tCidade: {item.Cidade}");
    }
}

Console.WriteLine();
//Agrupar por Cidade
Console.WriteLine("\nFuncionarios agrupados por Cidade:");
var funcCidade = funcionarios.ToLookup(func => func.Cidade);

foreach (var chave in funcCidade)
{
    Console.WriteLine($"\nCidade: {chave.Key}");

    foreach (var item in funcCidade[chave.Key])
    {
        Console.WriteLine($"\tNome: {item.Nome}\tCargo:{item.Cargo}");
    }
}


Console.ReadKey();