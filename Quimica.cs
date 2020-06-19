using System;
using System.IO;

class Quimica : ListaConteudos{
  private string areaQuimica;
  private string simuladoQuimica;
  
   public string AreaQuimica{
    get{
      return areaQuimica;
    }
    set{
      areaQuimica = value;
    }
  }

  public string SimuladoQuimica{
    get{
      return simuladoQuimica;
    }
    set{
      simuladoQuimica = value;
    }
  }  
}