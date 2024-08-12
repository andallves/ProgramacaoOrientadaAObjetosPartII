using SextaAtividade.Entities;
using SextaAtividade.Contracts.Services;
using SextaAtividade.Validators;

namespace SextaAtividade.Services;

public class CadastroService : ICadastroService
{
    private readonly List<Cidadao> _todosOsCidadoes = new List<Cidadao>();
    private readonly List<Funcionario> _todosOsFuncionarios = new List<Funcionario>();

    public void AdicionarCidadao(Cidadao cidadao)
    {
        _todosOsCidadoes.Add(cidadao);
        Console.WriteLine("Cidadão cadastrado.");
    }

    public Cidadao BuscarCidadaoPorCpf(string cpf)
    {
        var cidadaoBuscado = _todosOsCidadoes.Find(cidadao => cidadao.Cpf == cpf);

        if (cidadaoBuscado == null)
        {
            throw new ArgumentException("CPF não localizado");
        }

        return cidadaoBuscado;
    }

    public List<Cidadao> BuscarTodosOsCidadoes()
    {
        return _todosOsCidadoes.ToList();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        if (!(funcionario is Funcionario))
        {
            throw new ArgumentException("Há uma inconsistência com os dados do funcionário.");
        }
        _todosOsFuncionarios.Add(funcionario);
        Console.WriteLine("Funcionario cadastrado.");
    }

    public Funcionario BuscarFuncionarioPorMatricula(string matricula)
    {
        var funcionarioBuscado =
            _todosOsFuncionarios.Find(funcionario => funcionario.Matricula == matricula);

        if (funcionarioBuscado == null)
        {
            throw new ArgumentException("Matricula não localizada");
        }

        return funcionarioBuscado;
    }

    public List<Funcionario> BuscarTodosOsFuncionarios()
    {
        return _todosOsFuncionarios.ToList();
    }
}