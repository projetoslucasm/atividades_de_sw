namespace exercicioAluno;
class Program
{
    static void Main(string[] args)
    {
        Aluno  aluno1 = new Aluno (); 
        aluno1.nome = " Lusquinha ";
        aluno1.nota1 = 4.3;
        aluno1.nota2 = 7.8;

        aluno1.mensagem();
    }
}
