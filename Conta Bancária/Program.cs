namespace Conta_Bancária;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício conta bancária - EtecMCM");
        Conta conta = new Conta();

        conta.nomeCliente = "Luiz Antônio";

        conta.limite = 500;

        conta.depositar(200);

        conta.sacar(50);


        //Vamos chamar o método ConsultaSaldo  receber em uma variável local chamada saldo  valor disponível em saldo dese cliente
        double saldo = conta.ConsultaSaldo();
        //Agora para visualizar
        Console.WriteLine("Seu saldo é de: " + saldo);

    }
}
