 namespace herança_e_polimorfismo;
class Cachorro:Animal
{
    public override string Fala()
{
    return base.Fala() + "Au Au ";
}
}