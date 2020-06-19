using System;
using System.IO;

class Geografia : Areas{
  public string opcao;
  private string checkList;

  public string CheckList{
    get{
      return checkList;
    }
    set{
      checkList = value;
    }
  }
  /*
  public void ImprimirMenuGeografia(){
    Console.WriteLine("** G E O G R A F I A **");
    Console.WriteLine(">> Pressione 1 para exibir o checklist de conteúdos ou 2 para ver as demais opções: ");
    opcao = Console.ReadLine();
    if (opcao == "1"){
      Console.WriteLine("-Agricultura Brasileira;\n-Impactos no meio ambiente;\n-Planos e blocos econômicos;\n-Geopolítica mundial;\n-Migrações;\n-Desenvolvimento humano e social.");
    }*/

    public void ImprimirMateriasGeografia(){
      Console.WriteLine("Atente-se para os seguintes conteúdos:\n-Agricultura Brasileira;\n-Impactos no meio ambiente;\n-Planos e blocos econômicos;\n-Geopolítica mundial;\n-Migrações;\n-Desenvolvimento humano e social.");
    }
  }
