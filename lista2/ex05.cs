using System;

class Program {
  public static void Main (string[] args) {
    int num;
    Console.WriteLine("Digite um número inteiro: ");
    num = int.Parse(Console.ReadLine());
    if (num < 0) {
      num = (num*(-1));
      Console.WriteLine("Número: "+num);
    }
    else {
      Console.WriteLine("Número: "+num);
    }
  }
}