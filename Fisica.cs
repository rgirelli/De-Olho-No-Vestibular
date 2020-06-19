using System;
using System.IO;

class Fisica : ListaConteudos{
  //mecanica, termodinamica, optica, eletromagnetismo, fisica nuclear e astronomia;
  private string areaFisica;
  private string materia;
  

  public string AreaFisica{
    get{
      return areaFisica;
    }
    set{ 
      areaFisica = value;
    }
  }

  public string Materia{
    get{
      return materia;
    }
    set{
      materia = value;
    }
  }

  public void ImprimirMateriasFisica(){
    Console.WriteLine("Fique de olho em:\n-Eletricidade;\n-Hidrostática;\n-Ondas;\n-Óptica;\n-Usinas / instalações residenciais;\n-Calorimetria;\n-Acústica;\n-Mecânica.");
  }
}