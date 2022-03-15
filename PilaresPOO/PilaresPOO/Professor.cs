using System;
using System.Collections.Generic;

namespace PilaresPOO
{
  public class Professor: Pessoa
  {

    public Professor(decimal salario, string nome,string documento, DateTime dataNascimento)
      : base(nome, documento, dataNascimento)
    {
      Salario = salario;
      Turmas = new List<string> { "a", "b" };
    }

    public List<string> Turmas { get; private set; }

    public decimal Salario { get; private set; }

    public override void seApresentar()
    {
      base.seApresentar();

      var turmas = string.Join(',', Turmas);

      Console.WriteLine($"meu salário é: {Salario}, tenho as turmas: { turmas }");
    }

  }
}
