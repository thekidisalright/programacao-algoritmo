using System;

class Program {
  public static void Main (string[] args) {
    int AN, DN, MN, AH, DH, MH, ANO, MES, DIA;
    Console.WriteLine("Digite o dia de nascimento: ");
    DN = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o mês de nascimento: ");
    MN = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano de nascimento: ");
    AN = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o dia de hoje: ");
    DH = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o mês de hoje: ");
    MH = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano de hoje: ");
    AH = int.Parse(Console.ReadLine());
    if (DH < DN) {
      MES = ((MH-MN)-1);
      DIA = (31-(DN-DH));
    }
    else {
      MES = (MH-MN);
      DIA = (DH-DN);
    }
    ANO = (AH-AN);
    if (MES < 0) {
      ANO = (ANO-1);
      MES = (MES+12);
    }
    Console.WriteLine("Você tem "+ ANO+ " anos, "+ MES+ " meses e "+ DIA+ " dias");
  }
}