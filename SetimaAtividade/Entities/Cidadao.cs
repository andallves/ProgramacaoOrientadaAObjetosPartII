using SetimaAtividade.Entities.Enums;

namespace SetimaAtividade.Entities;

public class Cidadao : Pessoa
{
    public StatusVacina Vacinado = StatusVacina.NãoVacinado;
    public Agendamento Agendamento = new Agendamento();
  

    public Cidadao(string nome, string cpf, int idade) : base (nome, idade, cpf)
    {}

    public Cidadao(string nome, string cpf, int idade, string telefone, string email) : base (nome, idade, cpf, telefone, email)
    {}

    public override void Vacinar()
    {
        Vacinado = StatusVacina.Vacinado;
    }
    
    public override string ToString()
    {
        return "================================\r\n"
               + "Nome: " + Nome + "\r\n"
               + "Cpf: " + Cpf + "\r\n"
               + "Vacinado: " + Vacinado + "\r\n"
               + "================================";
    }
}