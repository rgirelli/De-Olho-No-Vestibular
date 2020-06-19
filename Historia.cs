using System;
using System.IO;

class Historia : ListaConteudos{
  private string areaHistoria;
  private string simuladoHistoria;
  
   public string AreaHistoria{
    get{
      return areaHistoria;
    }
    set{
      areaHistoria = value;
    }
  }

  public string SimuladoHistoria{
    get{
      return simuladoHistoria;
    }
    set{
      simuladoHistoria = value;
    }
  }

  public void ImprimirMateriasHistoria(){
    Console.WriteLine("Para história é importante saber:\n>> História do Brasil\n-Período Colonial;\n-República;\n-Período de escravidão;\n-Era Vargas;\n-Ditadura Militar;\n-Era populista.\n\n>> História Geral\n-Período de Idade Média e Moderna;\n-Revolução industrial;\n-Primeira e Segunda Guerra Mundial;\n-Nazismo/Holocausto e Fascismo;\n-Liberalismo;\n-Guerra Fria. ");
  }
   
}