using System;

class Program {
  public static void Main (string[] args) {
    double CAIXA, QTD, PR, COMPRA, FINAL;
    Console.WriteLine("Informe o valor restante no caixa: ");
    CAIXA = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a quantidade de produtos: ");
    QTD = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o preço de cada unidade: ");
    PR = double.Parse(Console.ReadLine());
    COMPRA = (QTD*PR);
    if (COMPRA > (CAIXA*0.80)) {
      FINAL = ((COMPRA*1.10)/3);
       Console.WriteLine("Forma de pagamento: parcelado em 3x com 10% de juros. Valor total: R$"+FINAL);
    }
    else {
      FINAL = (COMPRA-(COMPRA*0.05));
      Console.WriteLine("Forma de pagamento: a vista com 5% de desconto. Valor total a ser pago: R$"+FINAL);
    }
  }
}