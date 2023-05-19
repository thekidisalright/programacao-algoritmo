using System;

class Program {
  public static void Main (string[] args) {
    int A, B, C;
    Console.WriteLine("Insira um número inteiro: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira outro número inteiro: ");
    B = int.Parse(Console.ReadLine());
    if (A == B) {
      C = A+B;
      Console.WriteLine(C);
    }
    else if (A > B) {
      C = A-B;
      Console.WriteLine(C);
    }
    else if (A < B) {
      C = B-A;
      Console.WriteLine(C);
    }
  }
}