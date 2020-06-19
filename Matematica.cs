using System;
using System.IO;

class Matematica : ListaConteudos{
  private string areaMatematica;
  private string simuladoMatematica;
  
   public string AreaMatematica{
    get{
      return areaMatematica;
    }
    set{
      areaMatematica = value;
    }
  }

  public string SimuladoMatematica{
    get{
      return simuladoMatematica;
    }
    set{
      simuladoMatematica = value;
    }
  }  
}