using System;

class Program {
  public static void Main (string[] args) {
    double PR;
    int CO;
    Console.WriteLine("Digite o preço do produto: ");
    PR = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o código de origem do produto: ");
    CO = int.Parse(Console.ReadLine());
    if (CO == 1) {
      Console.WriteLine("Preço: R$"+PR+" Procedência: Sul");
    }
    else if (CO == 2) {
      Console.WriteLine("Preço: R$"+PR+" Procedência: Sudeste");
    }
    else if (CO == 3) {
      Console.WriteLine("Preço: R$"+PR+" Procedência: Centro-Oeste");
    }
    else if (CO == 4) {
      Console.WriteLine("Preço: R$"+PR+" Procedência: Norte");
    }
    else if (CO == 5) {
      Console.WriteLine("Preço: R$"+PR+" Procedência: Nordeste");
    }
    else {
      Console.WriteLine("Código Inválido");
    } 
  }
}