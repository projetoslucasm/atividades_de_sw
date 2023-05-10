 namespace herança_e_polimorfismo;
class Gato:Animal
{
    public override string Fala()
{
    return base.Fala() + "Miau ";
}
}