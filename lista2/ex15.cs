using System;

class Program {
  public static void Main (string[] args) {
    double HT, VH, SB, INSS, IR, ALQ, VD;
    Console.WriteLine("Digite suas horas trabalhadas:");
    HT = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite valor de horas trabalhadas:");
    VH = double.Parse(Console.ReadLine());
    SB = (HT*VH);
    if (SB <= 800.45) {
      ALQ = 0.0765;
    }
    if (SB >= 800.46 && SB <= 900) {
      ALQ = 0.0865;
    }
    if (SB >= 900.01 && SB <= 1334.07) {
      ALQ = 0.09;
    }
    if (SB >= 1334.08 && SB <= 2668.15) {
      ALQ = 0.11;
    }
    
    if (SB <= 1257.12) {
      ALQ = 0;
      VD = 0;
    }
    else if (1257.13 <= SB && SB <= 2512.08) {
      ALQ = 0.15;
      VD = 188.57;
    }
    else {
      ALQ = 0.275;
      VD = 502.58;
    }
    INSS = (ALQ*SB);
    IR = (ALQ*(SB-INSS)-VD);
    Console.WriteLine("Seu salário líquido é: R$ "+(SB-SB*0.11-IR));
  }
}