using QuintaAtividade.Contracts.Services;

namespace QuintaAtividade.Entities;

public class Admin : Funcionario
{
    const string Senha = "Admin123";
    private readonly ICadastroService _cadastroService;
    
    public Admin(ICadastroService cadastroService) : base (cadastroService)
    {
        _cadastroService = cadastroService;
    }
    
    public Admin(ICadastroService cadastroService, string nome, string cpf, int idade, string matricula, string cnpj) : base (cadastroService, nome, cpf, idade, matricula, cnpj)
    {
        _cadastroService = cadastroService;
    }
    
    public Admin(ICadastroService cadastroService, string nome, string cpf, int idade, string matricula, string cnpj, string endereco) 
        : base (cadastroService, nome, cpf, idade, matricula, cnpj, endereco)
    {
        _cadastroService = cadastroService;
    }
    
    public Admin(ICadastroService cadastroService, string nome, string cpf, int idade, string matricula, string cnpj, string endereco,
        string telefone) : base (cadastroService, nome, cpf, idade, matricula, cnpj, endereco, telefone)
    {
        _cadastroService = cadastroService;
    }

    public void AlterarCpf(string cpfAtual, string novoCpf)
    {
        if (!ESenhaCorreta())
        {
            return;
        }

        var cidadaoBuscado = _cadastroService.BuscarCidadaoPorCpf(cpfAtual);
        cidadaoBuscado.Cpf = novoCpf;
    }

    public void AlterarMatricula(string matriculaAtual, string novaMatricula)
    {
        if (!ESenhaCorreta())
        {
            return;
        }
        var funcionarioBuscado = _cadastroService.BuscarFuncionarioPorMatricula(matriculaAtual);
        funcionarioBuscado.Matricula = novaMatricula;
    }
    
    public void CadastrarFuncionario(Funcionario funcionario) {
        _cadastroService.AdicionarFuncionario(funcionario);
    }

    private bool ESenhaCorreta()
    {
        for (int i = 1; i <= 3; i++) {
            Console.Write("Informe a sua senha: ");
            string? senha = Console.ReadLine();
            if (senha == Senha) return true;
        }
        Console.WriteLine("Senha errada! Operação cancelada");
        return false;
    }
}