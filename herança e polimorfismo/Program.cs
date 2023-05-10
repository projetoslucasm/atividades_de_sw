namespace herança_e_polimorfismo;
class Program
{
    static void Main(string[] args)
    {
  Homem Juquinhazinho = new Homem();
    Cachorro Churrasco = new Cachorro();
    Gato Nevasca = new Gato();

    Console.WriteLine(Juquinhazinho.Fala());
    Console.WriteLine(Churrasco.Fala());
    Console.WriteLine(Nevasca.Fala());
    }
}

