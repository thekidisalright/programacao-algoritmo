using System;

class Program {
  public static void Main (string[] args) {
    int AN, AGE;
    Console.WriteLine("Digite o ano de nascimento: ");
    AN = int.Parse(Console.ReadLine());
    AGE = (2023 - AN);
    if (AGE >= 16 && AGE <=17) {
      Console.WriteLine("Você tem "+AGE+" anos, pode tirar o Título Eleitoral.");
    }
    else if (AGE >= 18) {
      Console.WriteLine("Você tem "+AGE+" anos, pode tirar o Título Eleitoral e a CNH.");
    }
    else {
      Console.WriteLine("Você tem "+AGE+" anos");
    }
  }
}