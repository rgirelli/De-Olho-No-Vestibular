using System;
using System.IO;

class Sociologia : ListaConteudos{
  private string areaSociologia;
  private string simuladoSociologia;
  private string sociologo;
  
   
  public string SimuladoSociologia{
    get{
      return simuladoSociologia;
    }
    set{
      simuladoSociologia = value;
    }
  }

  public string AreaSociologia{
    get{
      return areaSociologia;

    }
    set{
      areaSociologia = value;
    }
  }

  public string Sociologo{
    get{
      return sociologo;
    }
    set{
      sociologo = value;
    }
  }
}