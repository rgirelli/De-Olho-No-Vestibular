using System;
using System.IO;

class Artes : ListaConteudos{
  private string autor;
  private string conteudoArtes;
  private string simuladoArtes;
  
  public string Autor{
    get{
      return autor;
    }
    set{ 
      autor = value;
    }
  }

  public string ConteudoArtes{
    get{
      return conteudoArtes;
    }
    set{
      conteudoArtes = value;
    }
  }

  public string SimuladoArtes{
    get{
      return simuladoArtes;
    }
    set{
      simuladoArtes = value;
    }
  }
  public void ImprimirMateriasArtes(){
    Console.WriteLine("Confira as matérias de Artes que mais caem no Enem:-Música;\n-Grafite;\n-Artes marciais;\n-Cubismo;\n-Obras artísticas;\n-Renascimento;\n-Movimentos artísticos e culturais. ");
  }
}