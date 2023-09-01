using _06LINQOperacaoAgregacaoI;

Console.WriteLine("06 - Operadores de Agregação - parte I\n");

Console.WriteLine("Aggregate\n");
string[] cursos = { "C#", "Java", "Python", "PHP", "JavaScript", "Go" };
string resultado = cursos.Aggregate((s1, s2) => s1 + ", " + s2);
Console.WriteLine(resultado);

Console.WriteLine();

int[] numeros = { 3, 5, 7, 9 };
int resultadoNumeros = numeros.Aggregate((n1, n2) => n1 * n2);
Console.WriteLine(resultadoNumeros);

Console.WriteLine("\nAggragate com valor de semente\n");

var alunos = FonteDados.GetAlunos();

string listaAlunos = alunos.Aggregate<Alunos, string>(
                     "Nomes: ",//Valor da semenete
                      (semente, aluno) => semente += aluno.Nome + ", ");

int indice = listaAlunos.LastIndexOf(","); //Encontra o último índice de ','
listaAlunos = listaAlunos.Remove(indice); //Remove o índice

Console.WriteLine(listaAlunos);

Console.WriteLine("\nAggragate com valor de semente inicial e seletor de resultado\n");

string listaAlunos2 = alunos.Aggregate<Alunos, string, string>( //tipo da coleção, tipo da semente, tipo do resultado
                      "Nomes: ", (semente, aluno) => semente += aluno.Nome + ", ",
                      removerVirgula => removerVirgula.Substring(0, removerVirgula.Length-2));

Console.WriteLine(listaAlunos2);

Console.WriteLine("\nAverage:\n");

var mediaIdades = alunos.Average(aluno => aluno.Idade);
Console.WriteLine($"Média de idade: {mediaIdades} anos");


