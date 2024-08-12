using SextaAtividade.Validators;

namespace SextaAtividade.Entities;

public class Pessoa
{
    private string _nome;
    private int _idade;
    private string _cpf;
    private string _endereco;
    private string _telefone;
    private string _email;

    public string Nome
    {
        get => _nome;
        set
        {
            if (value.NomeValidator())
            {
                _nome = value;
            }
        }
    }

    public int Idade
    {
        get => _idade;
        set
        {
            if (!value.IdadeValidator())
            {
                throw new ArgumentException("Idade invalida");
            }
            _idade = value;
        }
    }

    public string Cpf
    {
        get => _cpf;
        set
        {
            if (!value.CpfValidator())
            {
                _cpf = value;
            }
        }
    }

    public string Endereco
    {
        get => _endereco;
        set
        {
            if (!value.EnderecoValidator())
            {
                _endereco = value;
            }
        }
    }
    public string? Telefone 
    { 
        get => _telefone;
        set
        {
            if (!value.TelefoneValidator())
            {
                _telefone = value;
            }
        } }

    public string? Email
    {
        get => _email;
        set
        {
            if (!value.EmailValidator())
            {
                _email = value;
            }
        }
    }
    
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