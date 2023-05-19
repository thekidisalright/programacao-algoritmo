using System;

class Program {
  public static void Main (string[] args) {
    int T;
    Console.WriteLine("Digite a temperatura do termômetro em graus Celsius. Exemplo: 50");
    T = int.Parse(Console.ReadLine());
    if (T < 100) {
      Console.WriteLine("A temperatura está muito baixa");
    }
    else if (T >= 100 && T <= 200) {
      Console.WriteLine("A temperatura está baixa");
    }
    else if (T > 200 && T < 500) {
      Console.WriteLine("A temperatura está normal");
    }
    else {
      Console.WriteLine("A temperatura está muito alta");
    }
  }
}