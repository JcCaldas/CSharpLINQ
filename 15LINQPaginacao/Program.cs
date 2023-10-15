using _15LINQPaginacao;

Console.WriteLine("15 - Paginação\n");

int RegistrosPorPagina = 4;
int NumeroPagina;

do
{

    Console.Write("\nInforme o nº da página, entre 1 e 4: ");
    if (int.TryParse(Console.ReadLine(), out NumeroPagina)) //transforma uma representação de string em int. out é a variavel que recebe o valor
    {
        if (NumeroPagina > 0 && NumeroPagina < 5) //intervalo do número de página.
        {
            var alunos = Aluno.GetAlunos()
                         .Skip((NumeroPagina - 1) * RegistrosPorPagina) //pula de acordo com a fórmula
                         .Take(RegistrosPorPagina) //Exibe a quantidade de registros definidos após a fórmula
                         .ToList();

            Console.WriteLine("\nPag.: " + NumeroPagina);

            alunos.ForEach(a => Console.WriteLine($"ID: {a.Id}\tNome: {a.Nome}\tCurso: {a.Curso}"));
        }
        else
            Console.WriteLine("Informe um nº da página válido.");
    }
    else
        Console.WriteLine("Informe um nº da página válido.");

} while (true);


Console.ReadKey();