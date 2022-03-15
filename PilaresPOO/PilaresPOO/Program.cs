using System;
using System.Collections.Generic;

namespace PilaresPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      var professor = new Professor(5000m, "Joao", "123456", new DateTime(1987, 1, 1));
      var estudante = new Estudante("A", "Maria", "654321", new DateTime(1892, 2, 2));

      var pessoas = new List<Pessoa> { estudante, professor };

      foreach (var pessoa in pessoas)
      {
        pessoa.seApresentar();
      }

      Console.Read();
    }
  }
}
