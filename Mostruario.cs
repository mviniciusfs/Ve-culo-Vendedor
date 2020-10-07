using System;
using System.Collections.Generic;

class Mostruario 
{
  //TAD
  private Vendedor Representante;
        //EST  <TAD>    VARIAVEL 
  public List<Veiculo> carros;

  public Mostruario(Vendedor v)
  {
    Representante = v;    
    carros = new List<Veiculo>();
  }

  public void setRepresentante(Vendedor v)
  {
    Representante = v;
  }

  public void CalculaValor()
  {
    double soma = 0;
    for (int i=0; i<carros.Count; i++)
    {
      soma += carros[i].getValor();
    }

    Console.WriteLine(soma);
  }


}