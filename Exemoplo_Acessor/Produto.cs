namespace Exemoplo_Acessor;
class Produto
{
 private string? Nome;
 private double Preco;

 public void MostraDados(){
    Console.WriteLine("Nome: " + this.Nome);
    Console.WriteLine("Preço: " + this.Preco);
 }
 public void AlterarPreco(double preco){
    if(preco>=0){
    this.Preco = preco;
    }else{
        Console.WriteLine("Preço Inválido");
    }
 }
 public void AlterarNome(string nome){
    this.Nome = nome;
 }

}