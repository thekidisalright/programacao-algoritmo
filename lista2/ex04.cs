using System;

class Program {
  public static void Main (string[] args) {
    double VG, PG, PA, CT;
    string TC;
    PG = 1.80;
    PA = 1;
    Console.WriteLine("Digite o tipo de carro: ");
    TC = Console.ReadLine();
    Console.WriteLine("Digite a capacidade do tanque: ");
    CT = double.Parse(Console.ReadLine());
    if (TC == "gasolina") {
      VG = (CT*PG);
      Console.WriteLine("O valor gasto para encher o tanque será: "+VG);
    }
    else if (TC == "alcool") {
      VG = (CT*PA);
      Console.WriteLine("O valor gasto para encher o tanque será: "+VG);
    }
  }
}