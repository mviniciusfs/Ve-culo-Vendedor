using System;

class MainClass {
  public static void Main (string[] args) {
    Vendedor carlos = new Vendedor();
    Veiculo uno = new Veiculo();

    Mostruario secaoA = new Mostruario();
    secaoA.setRepresentante(carlos);

    secaoA.carros.Add(uno);



  }
}