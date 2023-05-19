using System;

class Program {
  public static void Main (string[] args) {
    double SAL_NOVO, SAL;
    Console.WriteLine("Insira o salário: ");
    SAL = double.Parse(Console.ReadLine());
    if (SAL < 500) {
      SAL_NOVO = (SAL*0.15)+SAL;
      Console.WriteLine("Reajuste de 15%. Novo salário: "+SAL_NOVO);
    }
    else if (SAL >= 500 && SAL <= 1000) {
      SAL_NOVO = (SAL*0.10)+SAL;
      Console.WriteLine("Reajuste de 10%. Novo salário: "+SAL_NOVO);
    }
    else if (SAL > 1000) {
      SAL_NOVO = (SAL*0.05)+SAL;
      Console.WriteLine("Reajuste de 5%. Novo salário: "+SAL_NOVO);
    }
  }
}