using System;

class Program {
  public static void Main (string[] args) {
    string CL;
    Console.WriteLine("Insira o código do livro: ");
    CL = Console.ReadLine();
    if (CL == "A") {
      Console.WriteLine("Categoria: Ficção");
    }
    else if (CL == "B") {
      Console.WriteLine("Categoria: Não-Ficção");
    }
    else {
      Console.WriteLine("Código Inválido");
    }
  }
}