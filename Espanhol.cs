using System;
using System.IO;

class Espanhol : ListaConteudos{
  private string conteudoEspanhol;
  private string simuladoEspanhol;

  public string ConteudoEspanhol{
    get{
      return conteudoEspanhol;
    }
    set{
      conteudoEspanhol = value;
    }
  }

  public string SimuladoEspanhol{
    get{
      return simuladoEspanhol;
    }
    set{
      simuladoEspanhol = value;
    }
  }

  public void ImprimirMateriasEspanhol(){
    Console.WriteLine("Estude principlamente: -Conjunções;\n-Advérbios;\n-Palavras homônimas em espanhol;\n-Artigos definidos e indefinidos\n-Substantivos e adjetivos;\n-Verbos ser, estar e haver.");


  }
}