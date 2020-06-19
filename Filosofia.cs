using System;
using System.IO;

class Filosofia : ListaConteudos{
  private string filosofo;
  private string simuladoFilosofia;
  
   public string Filosofo{
    get{
      return filosofo;
    }
    set{
      filosofo = value;
    }
  }

  public string SimuladoFilosofia{
    get{
      return simuladoFilosofia;
    }
    set{
      simuladoFilosofia = value;
    }
  }

  public void ImprimirMateriasFilosofia(){
    Console.WriteLine("Fique por dentro de: Ética e justiça, Democracia e cidadania, Filosofia Contemporânea, Filosofia Moderna, Filosofia Antiga, Relações de Poder, Surgimento da Filosofia, Intolerância e Filosofia Medieval.");
  }
   
}