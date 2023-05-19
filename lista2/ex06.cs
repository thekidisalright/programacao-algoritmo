using System;

class Program {
  public static void Main (string[] args) {
    double P;
    Console.WriteLine("Insira o valor do produto: ");
    P = double.Parse(Console.ReadLine());
    if (P >= 50.00 && P <= 100.00) {
      Console.WriteLine("Em promoção");
    }
    else {
      Console.WriteLine("Preço normal");
    }
  }
}