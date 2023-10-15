using _10LINQOperacaoJuncao;

Console.WriteLine("10 - Operação de Junção\n");


var consulta = from aluno in FonteDados.GetAlunos() //define a fonte de dados base
               join endereco in FonteDados.GetEnderecos() //junção com a segunda fonte de dados
               on aluno.EnderecoId equals endereco.Id //Critério da junção
               join curso in FonteDados.GetCurso() //após faz junção na terceira fonte de dados
               on aluno.CursoId equals curso.Id //Crutério da segunda junção
               select new // projeção do resultado com base nas junções
               {
                   ID = aluno.Id,
                   AlunoNome = aluno.Nome,
                   CursoNome = curso.Nome,
                   EndecoLocal = endereco.Local,
               };

//Caso algum aluno não esteja matriculado em algum curso, ele não será retornado na junção
//Ex: alunos Id 4 e 8
foreach (var aluno in consulta)
{
    Console.WriteLine($"ID = {aluno.ID}\tNome = {aluno.AlunoNome}\t" +
                      $"Endereço = {aluno.EndecoLocal}\tCurso = {aluno.CursoNome}");
}


Console.ReadKey();