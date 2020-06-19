using System;
using System.IO;

class Biologia : ListaConteudos{
  private string areaBiologia;
  private string simuladoBiologia;

  public string AreaBiologia{
    get{
      return areaBiologia;
    }
    set{
      areaBiologia = value;
    }
  }

  public string SimuladoBiologia{
    get{
      return simuladoBiologia;
    }
    set{
      simuladoBiologia = value;
    }
  }
  public void ImprimirMateriasBiologia(){
    Console.WriteLine("Os conteúdos que caem com mais frequência são: -Ecologia e Sustentabilidade, bem como problemas ambientais;\n-Evolução;\n-Imunização;\n-Genética e mutações;\n-Citologia;\n-Ciclos de carbono, nitrogênio e água.");
  }
  
}