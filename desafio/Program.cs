namespace exercicioAluno;
class Program
{
    static void Main(string[] args)
    {
          Console.Write("Digite seu nome cabeça!!!: ");
      string? nomedacriatura = Console.ReadLine();
      Console.WriteLine("seu nome é: " + nomedacriatura);
      Console.Write("Digite um numero cabeça!!!: ");
      double numero1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("O número digitado foi: " +numero1);
       Console.Write("Digite outro numero meu Deus cabeça!!!: ");
      double numero2 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("O número digitado foi: " +numero2);
      Console.WriteLine("O aluno " + nomedacriatura + " teve a média de: " + (numero1+numero2)/2);
    string situacao="";
    if((numero1+numero2)/2>=6){
         situacao="Aprovado";     
    }else{
         situacao="Reprovado"; 
    }
      Console.WriteLine("A média do cabeça " + nomedacriatura + " foi de: " + (numero1+numero2)/2 + " e ele foi " + situacao);
    }
}
