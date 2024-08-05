namespace QuintaAtividade.Entities;

public class Agendamento
{
    public DateTime DataDeVacinacao { get; set; }
    public Funcionario Profissional { get; set; }
    public Cidadao Cidadao { get; set; }
    
    public Agendamento() {}

    public Agendamento(Cidadao cidadao, DateTime dataDaVacinacao, Funcionario profissional)
    {
        Cidadao = cidadao;
        DataDeVacinacao = dataDaVacinacao;
        Profissional = profissional;
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Agendamento)) return false;
        
        Agendamento other = obj as Agendamento;
        return DataDeVacinacao.Equals(other.DataDeVacinacao);
    }

    public override int GetHashCode()
    {
        return DataDeVacinacao.GetHashCode() + DataDeVacinacao.GetHashCode();
    }
}