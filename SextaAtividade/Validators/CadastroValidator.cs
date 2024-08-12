using System.Text.RegularExpressions;

namespace SextaAtividade.Validators;

public static class CadastroValidator
{
    private static readonly Regex NomeRegex = new Regex(@"^[a-zA-Z\s]+$", RegexOptions.Compiled);

    private static readonly Regex EmailRegex =
        new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public static bool NomeValidator(this string nome)
    {

        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O campo de nome é obrigatório.");
        }

        if (nome.Length < 3)
        {
            throw new ArgumentException("O nome deve conter mais de 3 caracteres.");
        }

        if (!NomeRegex.IsMatch(nome))
        {
            throw new ArgumentException("O nome não pode conter caracteres especiais.");
        }

        return true;
    }

    public static bool CpfValidator(this string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
        {
            throw new ArgumentException("O campo de CPF é obrigatório.");
        }

        if (cpf.Trim().Length != 11)
        {
            throw new ArgumentException("O cpf fornecido não é válido, por favor verifique.");
        }

        return true;
    }

    public static bool IdadeValidator(this int idade)
    {
        if (idade <= 0)
        {
            throw new ArgumentException("A idade precisa ser um número positivo.");
        }

        if (idade > 200)
        {
            throw new ArgumentException("A idade não pode ser superior a 200 anos.");
        }

        return true;
    }

    public static bool EnderecoValidator(this string endereco)
    {
        if (endereco.Length <= 10)
        {
            throw new ArgumentException("Endereço inválido, por favor verifique.");
        }

        return true;
    }

    public static bool TelefoneValidator(this string telefone)
    {
        if (telefone.Trim().Length != 11)
        {
            throw new ArgumentException("O telefone é inválido, por favor verifique.");
        }

        return true;
    }

    public static bool EmailValidator(this string email)
    {
        if (!EmailRegex.IsMatch(email))
        {
            throw new ArgumentException("O endereço de email é inválido.");
        }

        return true;
    }

    public static bool CnpjValidator(this string cnpj)
    {
        if (cnpj.Length <= 3)
        {
            throw new ArgumentException("CNPJ é inválido, por favor verifique.");
        }

        return true;
    }

    public static bool MatriculaValidator(this string matricula)
    {
        if (matricula.Length <= 6)
        {
            throw new ArgumentException("Matricula invália, por favor verifique.");
        }

        return true;
    }

    public static bool isFutureData(this DateTime data)
    {
        DateTime now = DateTime.Now;
        TimeSpan time = data.Subtract(now);
        if (time.TotalSeconds < 50)
        {
            throw new ArgumentException("Forneça uma data que seja válida.");
        }
        return true;
    }

}