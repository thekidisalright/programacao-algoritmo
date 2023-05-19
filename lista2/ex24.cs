using System;

class Program {
  public static void Main (string[] args) {
    double PAG, HP;
    int HE, ME, HS, MS;
    PAG = 0;
    HP = 0;
    Console.WriteLine("Insira a hora de entrada: ");
    HE = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o minuto de entrada: ");
    ME = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira a hora de saída: ");
    HS = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o minuto de saída: ");
    MS = int.Parse(Console.ReadLine());
    if (MS > ME && HS > HE) {
      HP = (HS-HE+1);
    }
    if (MS < ME && HS > HE) {
      HP = (HS+1-HE);
    }
    if (HE == HS && MS > ME) {
      HP = (HS-HE+1);
    }
    if (HE == HS && MS == ME) {
      HP = (HS-HE);
    }
    PAG = (HP*4);
    Console.WriteLine("Valor a pagar: R$"+PAG);
  }
}