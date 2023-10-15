namespace _10LINQOperacaoJuncao;

public class FonteDados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno() {Id = 1, Nome = "Maria", EnderecoId = 1, CursoId = 10},
            new Aluno() {Id = 2, Nome = "Manoel", EnderecoId = 2, CursoId = 20},
            new Aluno() {Id = 3, Nome = "Amanda", EnderecoId = 3, CursoId = 30},
            new Aluno() {Id = 4, Nome = "Carlos", EnderecoId = 4, CursoId = 00},
            new Aluno() {Id = 5, Nome = "Jaime", EnderecoId = 5, CursoId = 30},
            new Aluno() {Id = 6, Nome = "Debora", EnderecoId = 6, CursoId = 40},
            new Aluno() {Id = 7, Nome = "Alicia", EnderecoId = 7, CursoId = 10},
            new Aluno() {Id = 8, Nome = "Sandra", EnderecoId = 8, CursoId = 00},
            new Aluno() {Id = 9, Nome = "Marta", EnderecoId = 3, CursoId = 20},
            new Aluno() {Id = 10, Nome = "Sueli", EnderecoId = 2, CursoId = 30}
        };
        return alunos;
    }

    public static List<Endereco> GetEnderecos()
    {
        List<Endereco> enderecos = new List<Endereco>()
        {
            new Endereco() {Id = 1, Local = "R. México, 1004"},
            new Endereco() {Id = 2, Local = "Pça Miranda, 12"},
            new Endereco() {Id = 3, Local = "Av. da Luz, 30"},
            new Endereco() {Id = 4, Local = "R. Projetada, 33"},
            new Endereco() {Id = 5, Local = "R. Mirassol, 11"},
            new Endereco() {Id = 6, Local = "Av. da Saudade, 43"},
            new Endereco() {Id = 7, Local = "Av. da Felixidade, 77"},
            new Endereco() {Id = 8, Local = "R. Equador, 90"}
        };
        return enderecos;
    }

    public static List<Curso> GetCurso()
    {
        List<Curso> cursos = new()
        {
            new Curso() {Id = 10, Nome = "CSharp"},
            new Curso() {Id = 20, Nome = "Node"},
            new Curso() {Id = 30, Nome = "Java"},
            new Curso() {Id = 40, Nome = "Python"},
        };
        return cursos;
    }
}
