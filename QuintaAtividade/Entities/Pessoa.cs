namespace QuintaAtividade.Entities;

public class Pessoa
{
    public string Nome { get; }
    public int Idade { get; set; }
    public string Cpf { get; set; }

    public string Endereco { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    
    public Pessoa() {}

    public Pessoa(string nome, int idade, string cpf)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
    }

    public Pessoa(string nome, int idade, string cpf, string endereco)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
        Endereco = endereco;
    }
    
    public Pessoa(string nome, int idade, string cpf, string endereco, string telefone)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
        Endereco = endereco;
        Telefone = telefone;
    }
    
    public Pessoa(string nome, int idade, string cpf, string endereco, string telefone, string email)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
    }

    public virtual void Vacinar() {}
    
    public virtual void AgendarVacinacao(string cpf, DateTime dataDaVacinacao) {}
}