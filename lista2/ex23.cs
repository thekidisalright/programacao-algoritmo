using System;

class Program {
  public static void Main (string[] args) {
    string CS;
    double DC;
    Console.WriteLine("Digite a cor do semáforo:");
    Console.WriteLine("V = vermelho, A = amarelo, D = verde");
    CS = Console.ReadLine();
    Console.WriteLine("Digite a distância do cruzamento:");
    DC = double.Parse(Console.ReadLine());
    if (CS == "V") {
      Console.WriteLine("Pare");
    }
    else if (CS == "A" && DC < 5) {
      Console.WriteLine("Passe com cuidado");
    }
    else if (CS == "A" && DC >= 5) {
      Console.WriteLine("Pare");
    }
    else if (CS == "D") {
      Console.WriteLine("Passe");
    }
  }
}