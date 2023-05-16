using System;

class Program {
  public static void Main (string[] args) {
    double H, P;
    string S;
    Console.WriteLine("Digite sua altura");
    H = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu sexo");
    S = Console.ReadLine();
    if (S == "masculino") {
      P = (H*72.7)-58;
      Console.WriteLine("Seu peso ideal é: "+P);
    }
    else if (S == "feminino") {
      P = (H*62.1)-44.7;
      Console.WriteLine("Seu peso ideal é: "+P);
    }
  }
}