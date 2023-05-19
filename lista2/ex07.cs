using System;

class Program {
  public static void Main (string[] args) {
    double VM;
    string NOME;
    Console.WriteLine("Informe o valor das vendas do mês: ");
    VM = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o nome do vendedor: ");
    NOME = Console.ReadLine();
    if (VM >= 10000.00 && VM <= 50000.00) {
      Console.WriteLine("Vendedor: "+NOME);
    }
  }
}