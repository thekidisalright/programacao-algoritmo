using System;

class Program {
  public static void Main (string[] args) {
    double HP;
    int HE, ME, HS, MS, PRECO;
    Console.WriteLine("Insira a hora de entrada: ");
    HE = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o minuto de entrada: ");
    ME = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira a hora de saída: ");
    HS = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o minuto de saída: ");
    MS = int.Parse(Console.ReadLine());
    if (MS > ME && HS > HE) {
      HP = HS - HE + 1;
      if (HP == 1) {
        PRECO = 4;
      }
      else if (HP == 2) {
        PRECO = 6;
      }
      else {
        PRECO = 6 + (int)HP - 2;
      }
      Console.WriteLine("Valor a pagar: R$" + HP * PRECO);
    }
    else if (MS < ME && HS > HE) {
      HP = HS + 1 - HE;
      if (HP == 1) {
        PRECO = 4;
      }
      else if (HP == 2) {
        PRECO = 6;
      }
      else {
        PRECO = 6 + (int)HP - 2;
      }
      Console.WriteLine("Valor a pagar: R$" + HP * PRECO);
    }
    else if (HE == HS && MS > ME) {
      HP = HS - HE + 1;
      if (HP == 1) {
        PRECO = 4;
      }
      else if (HP == 2) {
        PRECO = 6;
      }
      else {
        PRECO = 6 + (int)HP - 2;
      }
      Console.WriteLine("Valor a pagar: R$" + HP * PRECO);
    }
    else if (HE == HS && MS == ME) {
      HP = HS - HE;
      if (HP == 1) {
        PRECO = 4;
      }
      else if (HP == 2) {
        PRECO = 6;
      }
      else {
        PRECO = 6 + (int)HP - 2;
      }
      Console.WriteLine("Valor a pagar: R$" + HP * PRECO);
    }
  }
}