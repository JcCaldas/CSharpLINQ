using _01LINQConsultas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("01 - Consultas LINQ\n");

        //Sintaxe de Método
        Console.WriteLine("numeros: 1, 2, 4, 8, 16, 32, 64, 128, 256, 512\n");
        var numeros = FonteDados.GetNumeros();

        //Consultas utilizando método 'Where'
        //O compilador só executa as ações quando for feita a iteração dos dados. (Lazy Execution)
        Console.WriteLine("Números menores que 10:");
        var resultado1 = numeros.Where(num => num < 10); //retorna somente os números que atendem a expressão boleana como 'True'
        Console.WriteLine(String.Join(", ", resultado1));

        Console.WriteLine("\nNúmero maior que 1, não pode ser 4, menor que 20");
        var resultado2 = numeros.Where(num => num > 1 && num != 4 && num <20);
        Console.WriteLine(String.Join(", ", resultado2));

        
        Console.WriteLine("\nLista Negra: 16, 128, 512");
        var listaNegra = FonteDados.GetListaNegra();

        Console.WriteLine("\nExibe lista de números, sem os números da Lista Negra");
        var resultado3 = numeros.Where(num => !listaNegra.Contains(num));//retorna a lista de números sem os números da Lista Negra
        Console.WriteLine(String.Join(", ", resultado3));

        //Encadeamento de 'Where'
        Console.WriteLine("\nEncadeamento Where: Número maior que 1, não pode ser 4, menor que 20");
        var resultado4 = numeros.Where(num => num > 1)
                                .Where(num => num != 4)
                                .Where(num => num < 20);
        Console.WriteLine(String.Join(", ", resultado4));

        //Objetos Complexos
        Console.WriteLine("\nObjetos complexos:");
        var alunos = FonteDados.GetAlunos();
        
        Console.WriteLine("\nAlunos:");
        foreach (var aluno in alunos)
            Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade} anos");

        Console.WriteLine("\nExibe Aluno que tem o nome iniciado com 'A' e idade menor que 18 anos");
        var resultado5 = alunos.Where(al => al.Nome.StartsWith('A') && al.Idade < 18);

        foreach (var aluno in resultado5)
            Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}");

        //Sintaxe de Consulta - mesmo resultado da anterior
        Console.WriteLine("\nOutra sintaxe de consulta");
        var filtro = from al in alunos
                     where al.Nome.StartsWith('A') && al.Idade <18
                     select al;
        
        foreach (var aluno in  filtro)
            Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade}");
            





        Console.WriteLine();




        Console.ReadKey();
    }
}