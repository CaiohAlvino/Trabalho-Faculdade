namespace ProgramacaoIV.Venda.Api.Entidades;

public sealed class Vendedor : AbstractEntity
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// To EF Core
    /// </summary>
    private Vendedor() : base() { }

    public Vendedor(string nome, string email)
    {
        Nome = nome.ToUpper() ?? throw new ArgumentNullException(nameof(nome));
        Email = email ?? throw new ArgumentNullException(nameof(email));

        //validar email
        if (!IsEmail(email))
        {
            throw new ArgumentException("Email inválido");
        }

    }

    private static bool IsEmail(string strEmail)
{
    string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
    if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
    {
        return true;
    }
    else
    {
        return false;
    }
}
}