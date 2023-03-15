namespace exercicioAluno;
class Aluno
{
    //media///
  public string nome="";
  public double nota1, nota2;
  public double obterMedia(){
     double Media = ( nota1+nota2)/2;
     return Media;

  }
  //situação//
  public string obterSituacao(double media){
    string situacao="";
    if(media>=6){
         situacao="Aprovado";     
    }else{
         situacao="Reprovado"; 
    }
    return situacao;
    
  }
  //mensagem//
  public void mensagem(){
    double mediaCalculada = obterMedia();
    string resultadoSituacao = obterSituacao(mediaCalculada);
    Console.WriteLine(nome+" ésta "+resultadoSituacao+" com média: "+mediaCalculada);
  }
}