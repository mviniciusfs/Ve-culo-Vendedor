using System;

class Veiculo{
  string Marca;
  int Ano, Km;
  double Valor;

  public void Relatorio(){
    Console.WriteLine("Informações do Veículo");
    Console.WriteLine("Marca:{0} | Ano:{1}", Marca, Ano);
    Console.WriteLine("Valor:{0} | Kilometragem:{1}",Valor, Km);
  }

  public void Atualiza_valor(int ano_base){
    Valor = Valor - (ano_base - Ano)*2.05;
  }
}