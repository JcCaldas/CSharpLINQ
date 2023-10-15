using _08LINQOperacaoQuantificacao;

Console.WriteLine("08 - Operação Quantificação\n");


Console.WriteLine("All\n");
//Verifica se todos os elementos de uma coleção satisfazem uma condição

int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };

//sintaxe de método
Console.WriteLine("Sintaxe de método:");
var resultado = numeros.All(n => n % 2 == 0);
Console.WriteLine($"Resultado: {resultado}\n{(resultado ? "Todos são pares\n" : "Nem todos são pares\n")}");

//sintaxe de consulta
Console.WriteLine("Sintaxe de consulta:");
var resultado2 = (from n in numeros select n).All(n => n % 2 == 0);
Console.WriteLine($"Resultado: {resultado}\n{(resultado2 ? "Todos são pares\n" : "Nem todos são pares\n")}");


Console.WriteLine("Consulta em uma fonte de Dados de Funcionários:\n");
var funcionarios = FonteDados.GetFuncionarios();

Console.WriteLine("Salários acima de R$2500:");
var salariosacima2500 = funcionarios.All(f => f.Salario > 2500.00m);
Console.WriteLine($"Resultado: {salariosacima2500}\n{(salariosacima2500 ? "Todos os salários são acima de R$2500\n" : "Nem todos os salários são acima de R$2500\n")}");

Console.WriteLine("Funcionários com mais de 21 anos:");
var funcionariosMaior21 = funcionarios.All(f => f.Idade > 21);
Console.WriteLine($"Resultado: {funcionariosMaior21}\n{(funcionariosMaior21 ? "Todos os funcionários tem mais de 21 anos\n" : "Nem todos os funcionários tem mais de 21 anos\n")}");

Console.WriteLine("Funcionários com 'A' no nome:");
var funcionariosComA = funcionarios.All(f => f.Nome.Contains("a"));
Console.WriteLine($"Resultado: {funcionariosComA}\n{(funcionariosComA ? "Todos os funcionários tem 'A' no nome\n" : "Nem todos os funcionários tem 'A' no nome\n")}");

Console.WriteLine("Consulta em uma fonte de Dados de Pessoas com Cachorros:\n");
var pessoas = FonteDados.GetPessoa();
//Em 'pessoas' seleciona a pessoa cujo a idade de todos os cachorros é maior que 5 e guarda o nome
//sintaxe de consulta
var nomes = from pessoa in pessoas
            where pessoa.Cachorros.All(pet => pet.Idade > 5)
            select pessoa.Nome;

Console.WriteLine("Sintaxe de Consulta");
Console.WriteLine("Pessoas com cachorros acima de 5 anos:");
if (nomes.Count() > 0)
{
    Console.WriteLine($"Resultado: {nomes.Count()}");
    foreach (var nome in nomes)
    {

        Console.WriteLine($"Nome: {nome}");

    }
    Console.WriteLine();

}
else
{
    Console.WriteLine("Nenhma pessoa tem algum cachorro acima de 5 anos.\n");
}

//sintaxe de método
var nomes2 = pessoas.Where(pessoa => pessoa.Cachorros.All(pet => pet.Idade > 5)).Select(pessoa => pessoa.Nome);

Console.WriteLine("Sintaxe de Método");
Console.WriteLine("Pessoas com cachorros acima de 5 anos:");
if (nomes.Count() > 0)
{
    Console.WriteLine($"Resultado: {nomes.Count()}");
    foreach (var nome in nomes)
    {

        Console.WriteLine($"Nome: {nome}");

    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Nenhma pessoa tem algum cachorro acima de 5 anos.\n");
}

Console.WriteLine("Any:\n");

string[] cursos = { "C#", "Java", "Python", "PHP", "ASP.NET", "Node" };
Console.Write("Lista de cursos: ");
foreach (var curso in cursos)
    Console.Write($"- {curso} ");
Console.WriteLine();

//1º sobrecarga - verifica se existe algum elemento
var existemCursos = cursos.Any(); //retorna bool
Console.WriteLine($"Existe curso? {existemCursos}");

//2º sobrecarga - verifica se existe algum nome de curso com tamanho maior que 3 caracteres
var existemCursosMaior3 = cursos.Any(curso => curso.Length > 3);
Console.WriteLine($"Existe curso com mais de 3 caracteres no nome? {existemCursosMaior3}\n");


Console.WriteLine("ListaCachorros:");

var cachorros = new List<Cachorro>()
{
    new Cachorro() {Nome = "Bilu", Idade = 6, Vacinado = true},
    new Cachorro() {Nome = "Canelinha", Idade = 3, Vacinado = false},
    new Cachorro() {Nome = "Pipoca", Idade = 8, Vacinado = true}
};

cachorros.ForEach(cachorro => Console.WriteLine($"Nome: {cachorro.Nome}\tIdade: {cachorro.Idade}\tVacinado: {(cachorro.Vacinado ? "Sim" : "Não")}\n"));

bool semVacina = cachorros.Any(c => c.Idade > 2 && c.Vacinado == false);
Console.WriteLine($"Existem cachorros com mais de 2 anos sem vacina: {(semVacina ? "Sim" : "Ñão")}\n");

Console.WriteLine("Contains:\n");

Console.Write("Lista de números: ");
int[] num = { 3, 5, 7, 9, 10, 12, 15, 20, 30, 39 };

foreach (int n in num)
    Console.Write($"{n} ");
Console.WriteLine();

var resultadoContains = num.Contains(12);
Console.WriteLine($"Na lista contém o número 12: {(resultadoContains ? "Sim" : "Não")}\n");

Console.WriteLine("Lista de alunos:");
var alunos = FonteDados.GetAlunos();
alunos.ForEach(aluno => Console.WriteLine($"Nome: {aluno.Nome}\tPontos: {aluno.Pontos}"));
Console.WriteLine();

//1ª Sobrecarga compara a referência na memória e não os valores
var aluno1 = new Aluno() { Nome = "Maria", Pontos = 275 }; //cria uma nova referência na memória
Console.WriteLine($"Aluno1\nNome: {aluno1.Nome}\tPontos: {aluno1.Pontos}\n");

var resultadoContainsAluno = alunos.Contains(aluno1); //retorna false pois compara a referência na memória
Console.WriteLine($"Aluno1 está contido na lista: {(resultadoContainsAluno ? "Sim" : "Não")}\n");


//2ª Sobrecarga utliza um comparador implementado
AlunoComparer alunoComparador = new AlunoComparer();
Console.WriteLine("Com comparador:");
var resultadoContainsAluno1 = alunos.Contains(aluno1, alunoComparador); //retorna true
Console.WriteLine($"Aluno1 está contido na lista: {(resultadoContainsAluno1 ? "Sim" : "Não")}");









