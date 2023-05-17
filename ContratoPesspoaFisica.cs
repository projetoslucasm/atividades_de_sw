public class ContratoPessoaFisica : Contrato
{
    private string cpf;
    private int idade;

    public ContratoPessoaFisica(string descricao, double valor, int prazo, string cpf, int idade)
        : base(descricao, valor, prazo)
    {
        this.cpf = cpf;
        this.idade = idade;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine("CPF: " + cpf);
        Console.WriteLine("Idade: " + idade);
    }

    public override double CalcularPrestacao()
    {
        double prestacao = base.CalcularPrestacao();
        double adicional = 0.0;

        if (idade <= 20)
            adicional = 1.0;
        else if (idade <= 30)
            adicional = 2.0;
        else if (idade <= 60)
            adicional = 3.0;
        else if (idade > 60)
            adicional = 4.0;

        return prestacao + adicional;
    }
}