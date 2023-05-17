public class ContratoPessoaJuridica : Contrato
{
    private string cnpj;
    private string inscricaoEstadual;

    public ContratoPessoaJuridica(string descricao, double valor, int prazo, string cnpj, string inscricaoEstadual)
        : base(descricao, valor, prazo)
    {
        this.cnpj = cnpj;
        this.inscricaoEstadual = inscricaoEstadual;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine("CNPJ: " + cnpj);
        Console.WriteLine("Inscrição Estadual: " + inscricaoEstadual);
    }

    public override double CalcularPrestacao()
    {
        double prestacao = base.CalcularPrestacao();
        return prestacao + 3.0;
    }
}