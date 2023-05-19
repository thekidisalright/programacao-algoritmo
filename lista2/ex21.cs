using System;

class Program {
  public static void Main (string[] args) {
    int ID;
    Console.WriteLine("Digite a idade do nadador: ");
    ID = int.Parse(Console.ReadLine());
    if (ID >= 5 && ID <= 7) {
      Console.WriteLine("Categoria: Infantil A");
    }
    else if (ID >= 8 && ID <= 10) {
      Console.WriteLine("Categoria: Infantil B");
    }
    else if (ID >= 11 && ID <= 13) {
      Console.WriteLine("Categoria: Juvenil A");
    }
    else if (ID >= 14 && ID <= 17) {
      Console.WriteLine("Categoria: Juvenil B");
    }
    else if (ID >= 18) {
      Console.WriteLine("Categoria: Adulto");
    }
    else {
      Console.WriteLine("Idade inválida");
    }
  }
}