using SextaAtividade.Entities;

namespace SextaAtividade.Contracts.Services;

public interface ICadastroService
{
    public void AdicionarCidadao(Cidadao cidadao);
    public void AdicionarFuncionario(Funcionario funcionario);
    public Cidadao BuscarCidadaoPorCpf(string cpf);
    public Funcionario BuscarFuncionarioPorMatricula(string matricula);
    public List<Cidadao> BuscarTodosOsCidadoes();
    public List<Funcionario> BuscarTodosOsFuncionarios();
}