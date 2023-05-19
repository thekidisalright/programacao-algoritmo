using System;

class Program {
  public static void Main (string[] args) {
    int CP;
    Console.WriteLine("Digite o código do produto: ");
    CP = int.Parse(Console.ReadLine());
    if (CP == 1) {
      Console.WriteLine("Alimento não perecível");
    }
    else if (CP == 2 || CP == 3 || CP == 4) {
      Console.WriteLine("Alimento perecível");
    }
    else if (CP == 5 || CP == 6) {
      Console.WriteLine("Vestuário");
    }
    else if (CP == 7) {
      Console.WriteLine("Higiene Pessoal");
    }
    else if (CP == 8 || CP == 9) {
      Console.WriteLine("Limpeza e Utensílios Domésticos");
    }
    else {
      Console.WriteLine("Inválido");
    }
  }
}