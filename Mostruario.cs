using System.Collections.Generic;

class Mostruario {
  //TAD
  private Vendedor Representante;
        //EST  <TAD>    VARIAVEL 
  public List<Veiculo> carros;

  public Mostruario(){
    carros = new List<Veiculo>();

  }

  public void setRepresentante(Vendedor v){
    Representante = v;
  }


}