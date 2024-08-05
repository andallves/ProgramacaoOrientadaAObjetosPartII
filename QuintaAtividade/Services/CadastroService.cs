using QuintaAtividade.Entities;

using System.Linq;
using QuintaAtividade.Contracts.Services;

namespace QuintaAtividade.Services;

public class CadastroService : ICadastroService
{
    private readonly HashSet<Cidadao> _todosOsCidadoes = new HashSet<Cidadao>();
    private readonly HashSet<Funcionario> _todosOsFuncionarios = new HashSet<Funcionario>();

    public void AdicionarCidadao(Cidadao cidadao)
    {
        _todosOsCidadoes.Add(cidadao);
    }

    public Cidadao BuscarCidadaoPorCpf(string cpf)
    {
        var cidadaoBuscado = _todosOsCidadoes.FirstOrDefault(cidadao => cidadao.Cpf == cpf);

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
        _todosOsFuncionarios.Add(funcionario);
    }

    public Funcionario BuscarFuncionarioPorMatricula(string matricula)
    {
        var funcionarioBuscado =
            _todosOsFuncionarios.FirstOrDefault(funcionario => funcionario.Matricula == matricula);

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