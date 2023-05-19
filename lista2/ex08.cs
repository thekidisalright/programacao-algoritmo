using System;

class Program {
  public static void Main (string[] args) {
    string NOME, DEP;
    double SAL;
    Console.WriteLine("Insira o nome do funcionário: ");
    NOME = Console.ReadLine();
    Console.WriteLine("Insira departamento do funcionário (somente a primeira letra) exemplo: L para limpeza, P para produção");
    DEP = Console.ReadLine();
    Console.WriteLine("Insira o salário do funcionário: ");
    SAL = double.Parse(Console.ReadLine());
    if (SAL >= 1000 && SAL <= 1500) {
      if (DEP == "p" || DEP == "e") {
        Console.WriteLine("Nome: "+NOME+" Salário: "+SAL);
      }
      else {
      Console.WriteLine("FIM");
      }
    }
    else {
      Console.WriteLine("FIM");
    }
  }
}