namespace Conta_Bancária;
class Conta
{
    public string? nomeCliente {get;set;}
    public int numeroConta {get;set;}
    public double saldo {get;set;}
    public double limite {get;set;}

    //Método para realizar um dpósito
    public void depositar (double valor){
        this.saldo += valor;
    }

    //Método para realizar um saque
    public void sacar (double valor){
        this.saldo -= valor;
    }


    //Método ConsultaSaldo - retorna um saldo disponível + limite
    public double ConsultaSaldo(){
        return this.saldo + this.limite;
    }
}