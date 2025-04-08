namespace ProgramacaoIV.Nota.Model;
public sealed class NotaC
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Aluno { get; set; } = string.Empty;
    public string Disciplina { get; set; } = string.Empty;
    public decimal Valor { get; set; } = 0;
    public DateTime Data { get; set; } = DateTime.UtcNow;
    }
