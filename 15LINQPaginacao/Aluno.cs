
namespace _15LINQPaginacao;

internal class Aluno
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Curso { get; set; }

    public static List<Aluno> GetAlunos()
    {
        return new List<Aluno>
        {
            new Aluno() {Id = 1, Nome = "Pedro", Curso = "Java"},
            new Aluno() {Id = 2, Nome = "Amélia", Curso = "Node"},
            new Aluno() {Id = 3, Nome = "Marta", Curso = "C#"},
            new Aluno() {Id = 4, Nome = "Samara", Curso = "SQL"},
            new Aluno() {Id = 5, Nome = "Silvio", Curso = "Java"},
            new Aluno() {Id = 6, Nome = "Carlos", Curso = "SQL"},
            new Aluno() {Id = 7, Nome = "Helena", Curso = "C#"},
            new Aluno() {Id = 8, Nome = "Renato", Curso = "Python"},
            new Aluno() {Id = 9, Nome = "Tânia", Curso = "Node"},
            new Aluno() {Id = 10, Nome = "Bia", Curso = "Python"},
            new Aluno() {Id = 11, Nome = "José", Curso = "Java"},
            new Aluno() {Id = 12, Nome = "Ana", Curso = "C#"},
            new Aluno() {Id = 13, Nome = "Débora", Curso = "PHP"},
            new Aluno() {Id = 14, Nome = "Marcos", Curso = "Python"},
            new Aluno() {Id = 15, Nome = "Luis", Curso = "PHP"},
            new Aluno() {Id = 16, Nome = "Dina", Curso = "C#"}
        };
    }
}
