using _07LINQOperacaoAgregacaoII;

Console.WriteLine("07 - Operadores de Agregação - parte II\n");

Console.WriteLine("Count\n");

string[] cursos = { "C#", "Java", "Python", "PHP", "JavaScript", "Go" };
Console.WriteLine("Cursos:");
foreach (string s in cursos)
    Console.Write($"{s} ");

var resultado = cursos.Count(); //Exibe a quantidade de itens
Console.WriteLine($"\nExistem {resultado} cursos.");

Console.WriteLine("\nCursos com \"P\":");
var cursosComP = cursos.Count(c => c.Contains("P"));
Console.WriteLine(cursosComP);

Console.WriteLine("LongCount\n");
//Funciona da mesma forma que o count, porém retorna um int64, para números extremamente grandes

var resultadoLong = cursos.LongCount(); //Exibe a quantidade de itens
Console.WriteLine($"Existem {resultadoLong} cursos.");

Console.WriteLine("\nCursos com \"P\":");
var cursosComPLong = cursos.LongCount(c => c.Contains("P"));
Console.WriteLine(cursosComPLong);

Console.WriteLine("\nSum\n");
//Soma todos os números de uma coleção

int[] num = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
var resultSum = num.Sum();
Console.WriteLine("A soma dos números é: " + resultSum);

Console.WriteLine("\nSum com filtro\n");

var sumFiltro1 = num.Where(n => n > 10).Sum();

Console.WriteLine("Resultado com filtro maior que 10: " + sumFiltro1 + "\n");

var sumFiltro2 = num.Sum(n =>
{
    if (n > 10)
        return n;
    else
        return 0;
});
Console.WriteLine("Resultado com filtro2 maior que 10: " + sumFiltro2 + "\n");

Console.WriteLine("Max\n");

List<Funcionario> funcionarios = new List<Funcionario>()
{
    new Funcionario() {Nome = "Maria", Idade = 36, Salario = 3850.00m},
    new Funcionario() {Nome = "Manoel", Idade = 33, Salario = 2490.00m},
    new Funcionario() {Nome = "Amanda", Idade = 21, Salario = 5257.50m}
};

var maiorIdade = funcionarios.Max(f => f.Idade);
var maiorSalario = funcionarios.Max(f => f.Salario);

var maiorSalario30 = funcionarios.Max(f =>
{
    if (f.Idade > 30)
        return f.Salario;
    else
        return 0;
});

var maiorSalario302 = funcionarios.Where(f => f.Idade >30).Max( f=> f.Salario);

Console.WriteLine("Lista de funcionários:\n");

funcionarios.ForEach(f => Console.WriteLine($"Nome: {f.Nome}\tIdade: {f.Idade} anos\tSalário: {f.Salario.ToString("c")}"));

Console.WriteLine($"\nMaior idade: {maiorIdade} anos\tMaior Salário:{maiorSalario.ToString("c")}");
Console.WriteLine($"\nMaior Salário dos funcionários com mais de 30 anos:{maiorSalario30.ToString("c")}");
Console.WriteLine($"\nMaior Salário dos funcionários com mais de 30 anos 2:{maiorSalario302.ToString("c")}");

Console.WriteLine("\nMin");
//Mesma lógic do Max

var menorIdade = funcionarios.Min(f => f.Idade);
var menorSalario = funcionarios.Min(f => f.Salario);

Console.WriteLine($"\nMenor idade: {menorIdade} anos\tMenor Salário:{menorSalario.ToString("c")}");
