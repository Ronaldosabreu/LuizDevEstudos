using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO
{
  /// <summary>
  /// abstract nao será instancia e sim herdada
  /// </summary>
  public abstract class Pessoa
  {
  
    public Pessoa(String nome, String documento, DateTime dataNascimento)
    {
      Nome = nome;
      Documento = documento;
      DataNascimento = dataNascimento;
    }


    //protected: fora da classe ou da filha nao altera
    //private : só dentro da classe pessoas
    public string Nome { get;  protected set; }
    public string  Documento { get; protected set; }
    public DateTime DataNascimento { get; protected set; }


    ///polimorfismo
    public virtual void seApresentar()
    {
      Console.WriteLine($"ola meu nome é {Nome}, doc {Documento}, data{DataNascimento}");
    }
    


  }
}
