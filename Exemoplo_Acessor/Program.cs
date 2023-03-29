namespace Exemoplo_Acessor;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();

        p1.AlterarNome("Parafuso");
        p1.AlterarPreco(50);
        p1.MostraDados();
    }
}
