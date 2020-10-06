using System;

class Vendedor{
  double Salario, Comissao;

  public double receber_relatorio(double valor_vendas){
    return (Salario + Comissao*valor_vendas);
  }
}