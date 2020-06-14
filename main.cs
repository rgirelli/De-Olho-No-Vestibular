using System;

class MainClass {
  public static void Main (string[] args){
  string opcao;
  Aluno aluno = new Aluno();
  ListaConteudos lista = new ListaConteudos();
  Areas areas = new Areas();
  Geografia geo = new Geografia();
  //Areas geo = new Areas();
  aluno.ImprimirBoasVindas();
  Console.WriteLine("\n>> ESCOLHA UMA DAS OPÇÕES ACIMA: ");

  opcao = Console.ReadLine();
  if (opcao == "1"){
    aluno.CadastrarAluno();
  }
  if (opcao == "2"){
    Console.WriteLine("\n>> ESCOLHA UMA DAS OPÇÕES A SEGUIR:   ");
    Console.WriteLine("1 - Escolher área de conhecimento\n2 - Guia do livro\n3 - Simulados\n4 - Portifólio de Redação\n5 - Dicas\n6 - EXTRA: fórmulas úteis");
    opcao = Console.ReadLine();
    if (opcao == "1"){
      //areas.SelecionarArea();
      Console.WriteLine("\n>> QUAL ÁREA GOSTARIA DE CONSULTAR? ");
      areas.ImprimirAreas();
      opcao = Console.ReadLine();
      if (opcao == "1"){
        Console.WriteLine("\n>> SELECIONE A DISCIPLINA DESEJADA:  ");
        opcao = Console.ReadLine();
      } 
    }
    
    
  }
  
  //areas.SelecionarArea();
  //geo.ImprimirMenuGeografia();
  
  }
}

