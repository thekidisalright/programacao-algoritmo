using System;

class Program {
  public static void Main (string[] args) {
    float CL = 0;
    Console.WriteLine("Digite o valor da conta de luz:");
    CL = float.Parse(Console.ReadLine());
    if (CL > 50) {
      Console.WriteLine("Você está gastando muito");
    }
    
  }
}