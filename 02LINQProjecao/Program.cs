using _02LINQProjecao;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("02 - LINQ Projeção\n");

        Console.WriteLine("Select\n");
        //Seleciona todos os dados orginais
        //retorna uma lista (ToList()), do tipo 'Aluno', com todos os objetos da lista de alunos
        IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList();

        Console.WriteLine("Nomes e Notas:");

        foreach (var aluno in alunos)
            Console.WriteLine($"Nome: {aluno.Nome}\tNota: {aluno.Nota}");

        //Seleciona apenas um dado, a escolha
        //retorna uma lsita, do tipo string, somente do que está sendo solicitado na expressão lâmbida.
        Console.WriteLine();
        
        IEnumerable<string> nomesAlunos = FonteDados.GetAlunos().Select(a => a.Nome);

        foreach (var nome in nomesAlunos)
            Console.WriteLine($"Nome: {nome}");

        //Seleciona um novo formato do mesmo tipo obtendo apenas o Nome e a Idade
        //retorna uma lista do tipo informado
        List<Aluno> lista = FonteDados.GetAlunos().Select(aluno => new Aluno()
                                                                    {
                                                                        Nome = aluno.Nome,
                                                                        Idade = aluno.Idade,
                                                                    }).ToList();

        Console.WriteLine("\nNome e Idade:");
        foreach (var aluno in lista)
            Console.WriteLine($"Nome: {aluno.Nome}\tIdade:{aluno.Idade}");


        //Cria uma projeção para um tipo anônimo
        //retorna uma lista de objetos do tipo anônimo
        var alunosTipoAnonimo = FonteDados.GetAlunos().Select(aluno => new
        {
            NomeAluno = aluno.Nome,
            IdadeAluno = aluno.Idade,
            NotaAluno = aluno.Nota
        }).ToList();

        Console.WriteLine("\nNome e Idade (tipo anônimo):");
        foreach (var aluno in alunosTipoAnonimo)
            Console.WriteLine($"Nome: {aluno.NomeAluno}\tIdade: {aluno.IdadeAluno}");


        //Realizar cálculos com o operador Select
        //retorna uma lista de objetos do tipo anônimo conforme orientado na expressão lâmbida
        var funcionariosTipoAnonimo = FonteDados.GetFuncionarios().Select( f=> new
        {
            NomeFuncionario = f.Nome,
            IdadeFuncionario = f.Idade,
            SalarioAnual = f.Salario * 12
        }).ToList();

        Console.WriteLine("\nCálculo salário anual (tipo anônimo)");
        foreach (var funcionario in funcionariosTipoAnonimo)
            Console.WriteLine($"Nome: {funcionario.NomeFuncionario}\tIdade: {funcionario.IdadeFuncionario}\tSalário Anual: {funcionario.SalarioAnual.ToString("c")}");

        Console.WriteLine("\nSelectMany\n");

        //Projeta cada elemento das sequências em um IEnumerable<T>
        List<List<int>> listas = new List<List<int>>
        {
            new List<int> { 1, 2,3 },
            new List<int> { 12 },
            new List<int> { 5, 6, 5, 7},
            new List<int> { 10, 12, 12, 13 }
        };

        //retorna todas as listas em sequência, no mesmo objeto
        IEnumerable<int> resultado = listas.SelectMany(lista => lista);

        foreach( var num in resultado )
            Console.Write($"{num} ");

        Console.WriteLine("\nDistinct\n");
        resultado = listas.SelectMany(lista => lista.Distinct()); //caso tenha um objeto repetido, dentro da lista, o método "Distinct()" faz com que ele seja retornado apenas uma vez

        foreach (var num in resultado)
            Console.Write($"{num} ");


        //Comparação 'Select' e 'SelectMany'
        //Select - Neste caso vai retornar uma Lista, com outra Lista dentro
        Console.WriteLine("\nSelect\n");
        IEnumerable<List<String>> retornoSelect = FonteDados.GetAlunos().Select(c => c.Cursos);

        foreach (List<String> listasCursos in retornoSelect)
        {
            foreach (string curso in listasCursos)
            {
                Console.Write($"{curso} ");
            }
            Console.WriteLine();
        }

        //SelectMany - Neste caso vai retornar uma única Lista com todos os cursos
        Console.WriteLine("\nSelectMany\n");
        IEnumerable<string> retornoSelectMany = FonteDados.GetAlunos().SelectMany(c => c.Cursos);

        foreach (string curso in retornoSelectMany)
            Console.Write($"{curso} ");


        Console.ReadKey();
    }
}