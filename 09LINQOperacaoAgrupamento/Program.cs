using _09LINQOperacaoAgrupamento;

Console.WriteLine("08 - Operações de Agrupamento\n");

Console.WriteLine("GroupBy\n");

var alunos = FonteDados.GetAlunos();

//Sintaxe de método - retorna sem ordenação
var grupos = alunos.GroupBy(a => a.Idade);

//Sintaxe de método - retorna ordenado
var gruposOrdenados = alunos.GroupBy(a => a.Idade).OrderBy(c => c.Key);//Ordena pela chave escolhida, no caso a idade

//sintaxe de consulta - retorna sem ordenação
var grupos2 = from a in alunos
              group a by a.Idade;

//sintaxe de consulta - retorna ordenado
var gruposOrdenados2 = from a in alunos
                       group a by a.Idade into aluno //into indica uma nova pesquisa, 'aluno' pode ser substituido por qualquer palavra
                       orderby aluno.Key
                       select aluno;

Console.WriteLine("Retorno padrão:");
//Itera em cada grupo
foreach (var grupo in grupos)
{
    Console.WriteLine($"\nIdade: {grupo.Key}\tAlunos: {grupo.Count()}");
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"ID: {aluno.AlunoId}\tNome: {aluno.Nome}\tCurso: {aluno.Curso}\tSexo: {aluno.Sexo}");
    }
}

Console.WriteLine("\nRetorno ordenado pela chave (idade):");
//Itera em cada grupo
foreach (var grupo in gruposOrdenados)
{
    Console.WriteLine($"\nIdade: {grupo.Key}\tAlunos: {grupo.Count()}");
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"ID: {aluno.AlunoId}\tNome: {aluno.Nome}\tCurso: {aluno.Curso}\tSexo: {aluno.Sexo}");
    }
}

//Ordenando os elementos dentro dos grupos
var grupoTotalmenteOrdenados = alunos.GroupBy(aluno => aluno.Curso)
                               //Primeiro ordena os dados baseados na chave escolhida (curso)
                               .OrderBy(c => c.Key)
                               .Select(std => new
                               {
                                   Key = std.Key,
                                   //Ordena os dados baseados no nome
                                   Alunos = std.OrderBy(x => x.Nome)
                               });

Console.WriteLine("\nOrdenando os elementos dentro dos grupos:");

foreach (var grupo in grupoTotalmenteOrdenados)
{
    Console.WriteLine($"\nCurso: {grupo.Key}\t(Alunos: {grupo.Alunos.Count()})");
    //itera cada grupo de alunos
    foreach (var aluno in grupo.Alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade} anos\tSexo: {aluno.Sexo}");
    }
}

Console.WriteLine("\nOrdenandos os elementos com duas chaves:");

var gruposComDuasChaves = alunos.GroupBy(x => new { x.Sexo, x.Curso })
                          .OrderBy(g => g.Key.Curso)
                          .ThenBy(g => g.Key.Sexo)
                          .Select(g => new
                          {
                              Curso = g.Key.Curso,
                              Sexo = g.Key.Sexo,
                              Alunos = g.OrderBy(x => x.Nome)
                          });

foreach (var grupo in gruposComDuasChaves)
{
    Console.WriteLine($"\nCurso: {grupo.Curso}\tSexo: {grupo.Sexo} (Alunos: {grupo.Alunos.Count()})");
    foreach (var aluno in grupo.Alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade} anos");
    }
}

Console.WriteLine("ToLookUp (execução imediata):\n");

var gruposLook = alunos.ToLookup(a => a.Curso);

foreach (var grupo in gruposLook)
{
    Console.WriteLine($"\nCurso: {grupo.Key} (Alunos: {grupo.Count()})");
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"Nome: {aluno.Nome}\tIdade: {aluno.Idade} anos\tSexo: {aluno.Sexo}");
    }


}
