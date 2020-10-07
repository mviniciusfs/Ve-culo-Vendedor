using System;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Vendedor carlos = new Vendedor("Carlos", 2000, 1.34);
    Veiculo uno = new Veiculo("Fiat", 2020, 0, 50000);

    Mostruario secaoA = new Mostruario(carlos);    
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);

    /*
    double soma = 0;
    for (int i=0; i<secaoA.carros.Count; i++)
    {
      soma += secaoA.carros[i].getValor();
    }
    */   

    secaoA.CalculaValor();
  }
}