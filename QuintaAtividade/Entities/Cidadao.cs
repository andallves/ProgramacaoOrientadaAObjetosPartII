using QuintaAtividade.Entities.Enums;

namespace QuintaAtividade.Entities;

public class Cidadao : Pessoa
{
    private StatusVacina _vacinado = StatusVacina.NãoVacinado;
    public Agendamento Agendamento = new Agendamento();
  

    public Cidadao(string nome, string cpf, int idade) : base (nome, idade, cpf)
    {}

    public Cidadao(string nome, string cpf, int idade, string telefone, string email) : base (nome, idade, cpf, telefone, email)
    {}

    public override void Vacinar()
    {
        _vacinado = StatusVacina.Vacinado;
    }
    
    public override string ToString()
    {
        return "================================\r\n"
               + "Nome: " + Nome + "\r\n"
               + "Cpf: " + Cpf + "\r\n"
               + "Vacinado: " + _vacinado + "\r\n"
               + "================================";
    }
}