using System;

class MainClass {
  public static void Main (string[] args){
  string opcao;
  Aluno aluno = new Aluno();
  Menu menu = new Menu();
  ListaConteudos checklist = new ListaConteudos();
  Areas areas = new Areas();
  Aplicativos app = new Aplicativos();
  Literatura literatura = new Literatura();
  Redacao redacao = new Redacao();
  Dicas dicas = new Dicas();
  Artes artes = new Artes();
  aluno.ImprimirBoasVindas();
  

  Console.WriteLine("\nEscolha uma opção: \n1 - Sobre mim \n2 - Acessar conteúdo ");
  opcao = Console.ReadLine();
  if (opcao == "1"){
    aluno.EfetuarCadastro();
  }
  if (opcao == "2"){
    Console.WriteLine("\nInforme a opção desejada para continuar: ");
    menu.ImprimirMenu();
    opcao = Console.ReadLine();
      
    switch (opcao){
      case "1":
        checklist.ImprimirLista();
        break;
      case "2":
        Console.WriteLine("Informe a opção desejada para continuar: ");
        areas.ImprimirAreas();
        opcao = Console.ReadLine();
        if (opcao == "1"){
          areas.ImprimirHumanas();
        }
        if (opcao == "2"){
          areas.ImprimirMatematica();
        }
        if (opcao == "3"){
          areas.ImprimirLinguagens();
        }
        if (opcao == "4"){
          areas.ImprimirCiencias();
        }
        break;
      case "3":
        app.ImprimirAplicativos();
        break;
      case "4":
        literatura.ListarLivros();
        //voltar e adicionar resumo
        break;
      case "5":
        Console.WriteLine();
        //adicionar simulado nan classe simulado
        break;
      case "6":
        redacao.ImprimirRedacao();
        break;
      case "7":
        dicas.ImprimirDicasGerais();
        break;
      default:
        Console.WriteLine("Comando inválido.");
        break;

        




        
        
    }



  }

  
  }
} 