using System;

class Vendedor
{

  double Salario, Comissao;

  string Nome;
  public void setNome(string n)
  {
    Nome = n;
  }
  public string getNome()
  {
    return Nome;
  }

  public double receber_relatorio(double valor_vendas){
    return (Salario + Comissao*valor_vendas);
  }

  public Vendedor(string n, double s, double c)
  {
    Nome = n;
    Salario = s;
    Comissao = c;
    

  }
}