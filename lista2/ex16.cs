using System;

class Program {
  public static void Main (string[] args) {
    double PE;
    int CP;
    double PAGAR;
    Console.WriteLine("Insira o preço do produto: ");
    PE = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira o código da condição do pagamento, por exemplo: 1");
    CP = int.Parse(Console.ReadLine());
    if (CP == 1) {
      PAGAR = (PE - (PE*0.1));
      Console.WriteLine("Pagamento à vista, 10% de desconto. Valor a pagar: R$"+PAGAR);
    }
    else if (CP == 2) {
      PAGAR = (PE - (PE*0.05));
      Console.WriteLine("Pagamento à vista, 5% de desconto. Valor a pagar: R$"+PAGAR);
    }
    else if (CP == 3) {
      PAGAR = PE/2;
      Console.WriteLine("Pagamento parcelado em 2x. Valor a pagar: R$"+PAGAR);
    }
    else if (CP == 4) {
      PAGAR = ((PE*1.1)/3);
      Console.WriteLine("Pagamento parcelado em 3x, 10% de juros. Valor a pagar: R$"+PAGAR);
    }
  }
}