using System;
using System.IO;

class Ingles : ListaConteudos{
  private string conteudoIngles;
  private string simuladoIngles;
  
   public string ConteudoIngles{
    get{
      return conteudoIngles;
    }
    set{
      conteudoIngles = value;
    }
  }

  public string SimuladoIngles{
    get{
      return simuladoIngles;
    }
    set{
      simuladoIngles = value;
    }
  } 

  public void ImprimirMateriasIngles(){
    Console.WriteLine("Caso escolha o inglês como segundo idioma, é necessário saber: Leitura e interpretação de textos, Leitura e interpretação de cartuns, tirinhas e charges, Domínio lexical, Análise e interpretação de poemas e canções, Identificação da função do texto e Diversidade cultural;	 ");
  }
}