using System;
using System.IO;

class Redacao : ListaConteudos{
  private string tipos;
  private string simuladoRedacao;
  
   public string Tipos{
    get{
      return tipos;
    }
    set{
      tipos = value;
    }
  }

  public string SimuladoRedacao{
    get{
      return simuladoRedacao;
    }
    set{
      simuladoRedacao = value;
    }
  }

  public void ImprimirRedacao(){
    Console.WriteLine(" ");
  }
}