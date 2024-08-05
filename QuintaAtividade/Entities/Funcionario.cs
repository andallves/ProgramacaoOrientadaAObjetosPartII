using System.Text;
using QuintaAtividade.Contracts.Services;

namespace QuintaAtividade.Entities;

public class Funcionario : Pessoa
{
    public static int Identificador { get; private set; }

    public string Matricula { get; set; }

    public string Cnpj { get; private set; }
    public HashSet<Agendamento> Agendamentos { get; private set; } = new HashSet<Agendamento>();
    private readonly ICadastroService _cadastroService;

    public Funcionario(ICadastroService cadastroService)
    {
        Identificador++;
        _cadastroService = cadastroService;
    }

    public Funcionario(ICadastroService cadastroService, string nome, string cpf, int idade, string matricula, string cnpj) : base (nome, idade, cpf)
    {
        Matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
        _cadastroService = cadastroService;
    }

    public Funcionario(ICadastroService cadastroService, string nome, string cpf, int idade, string matricula, string cnpj, string endereco) : base (nome, idade, cpf, endereco)
    {
        if (cadastroService == null) throw new ArgumentNullException(nameof(cadastroService));
        Matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
        _cadastroService = cadastroService;
    }
    
    public Funcionario(ICadastroService cadastroService, string nome, string cpf, int idade, string matricula, string cnpj, string endereco,
        string telefone) : base (nome, idade, cpf, endereco, telefone)
    {
        Matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
        _cadastroService = cadastroService;
    }
    
    public Funcionario(ICadastroService cadastroService, string nome, string cpf, int idade, string matricula, string cnpj, string endereco, string telefone,
        string email) : base (nome, idade, cpf, endereco, telefone, email)
    {
        Matricula = matricula;
        Cnpj = cnpj;
        Identificador++;
        _cadastroService = cadastroService;
    }
    

        public void CadastrarCidadao(Cidadao cidadao) {
            _cadastroService.AdicionarCidadao(cidadao);
        }
   
    public override void AgendarVacinacao(string cpf, DateTime dataDaVacinacao)
    {
        var cidadao = _cadastroService.BuscarCidadaoPorCpf(cpf);
        Agendamento agendamento = new Agendamento(cidadao, dataDaVacinacao, this);
        cidadao.Agendamento = agendamento;
        Agendamentos.Add(agendamento);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Funcionario: com Idenficador: ");
        sb.Append(Identificador);
        sb.Append(", ");
        sb.AppendLine(Nome);
        sb.Append("Matricula: ");
        sb.AppendLine(Matricula);
        sb.AppendLine("Paciêntes cadastrados: ");
        return sb.ToString();
    }
}