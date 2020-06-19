using System;
using System.IO;

class Portugues : ListaConteudos{
  private string conteudoPortugues;
  private string simuladoPortugues;
  
   public string ConteudoPortugues{
    get{
      return conteudoPortugues;
    }
    set{
      conteudoPortugues = value;
    }
  }

  public string SimuladoPortugues{
    get{
      return simuladoPortugues;
    }
    set{
      simuladoPortugues = value;
    }
  } 
}