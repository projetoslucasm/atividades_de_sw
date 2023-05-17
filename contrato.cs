public class Contrato
{
    protected string descricao;
    protected double valor;
    protected int prazo;

    public Contrato(string descricao, double valor, int prazo)
    {
        this.descricao = descricao;
        this.valor = valor;
        this.prazo = prazo;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine("Descrição: " + descricao);
        Console.WriteLine("Valor: " + valor);
        Console.WriteLine("Prazo: " + prazo);
    }

    public virtual double CalcularPrestacao()
    {
        return valor / prazo;
    }
}