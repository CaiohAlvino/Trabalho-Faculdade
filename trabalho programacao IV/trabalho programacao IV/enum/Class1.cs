using System.ComponentModel;

namespace trabalho.programacao.IV
{
    public enum TipoUsuario
    {
        [Description("Administrador do sistema")]
        Administrador,
        [Description("Usuário Comum")]
        UsuarioComum,
        [Description("Visitante")]
        Visitante
    }
}
