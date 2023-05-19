using System;

class Program {
  public static void Main (string[] args) {
    double A, B, C;
    Console.WriteLine("Insira o comprimento do lado A: ");
    A = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira o comprimento do lado B: ");
    B = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira o comprimento do lado C: ");
    C = double.Parse(Console.ReadLine());
    if (A == B && A == C) {
      Console.WriteLine("O triângulo é do tipo Equilátero");
    }
    else if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A)) {
      Console.WriteLine("O triângulo é do tipo Isósceles");
    }
    else if (A != B && A != C && B != C) {
      Console.WriteLine("O triângulo é do tipo Escaleno");
    }
  }
}