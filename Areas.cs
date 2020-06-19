/*As provas são separadas por áreas de conhecimento:

Ciências da Natureza: Biologia, Química e Física;
Ciências Humanas: História, Geografia, Filosofia e Sociologia;
Linguagens, Códigos e suas Tecnologias: Português, Literatura, Língua Estrangeira, Artes, Educação Física e Tecnologias da Informação e Comunicação;
Matemática e suas tecnologias;
Redação.*/
using System;
using System.IO;
class Areas{
  
  private string areaConhecimento;
  private string simuladoGeral;
  public string opcao;
  
    
  public string AreaConhecimento{
    get{
      return areaConhecimento;
    }
    set{
      areaConhecimento = value;
    }
  }

  public string SimuladoGeral{
    get{
      return simuladoGeral;
    }
    set{
      simuladoGeral = value;
    }
  }

  public void ImprimirAreas(){
    
    
    Console.WriteLine("1 - Ciências Humanas e suas Tecnologias\n2 - Matemática e suas Tecnologias\n3 - Linguagens, Códigos e suas Tecnologias\n4 - Ciências da Natureza e suas Tecnologias");
  }

  public void ImprimirHumanas(){
     Console.WriteLine(">> As matérias abordadas serão: História, Geografia, Filosofia e Sociologia");
  }

  public void ImprimirMatematica(){
    Console.WriteLine(">> Nesta área, serão cobrados conhecimentos de matemática aplicados ao cotidiano.");
  }

  public void ImprimirLinguagens(){
    Console.WriteLine(">> Nesta área, a prova vai cobrar conhecimento de português, literatura, artes, educação física e línguas. O aluno poderá optar entre inglês e espanhol.");
  }

  public void ImprimirCiencias(){
    Console.WriteLine(">> Nesta área, a prova vai cobrar conhecimentos de química, física e biologia.");
  }
  //public void SelecionarArea(){
    //Console.WriteLine("\n>> SELECIONE A ÁREA DE CONHECIMETO QUE DESEJA CONSULTAR: ");
  //}

  /*public void SelecionarArea(){
    Console.WriteLine("\n>> SELECIONE A ÁREA: ");
    opcao = Console.ReadLine();
    if (opcao == "1"){
      Console.WriteLine("\n>> ESCOLHA A DISCIPLINA QUE DESEJA ACESSAR: ");
      Console.WriteLine("1 - Geografia\n2 - História\n3 - Sociologia\n4 - Filosofia  ");
      opcao = Console.ReadLine();
    }
      /*if (opcao == "1"){
        
      }


    }

  }*/

  
  public void SelecionarArea(){
   
    
      Console.WriteLine("1 - Geografia\n2 - História\n3 - Sociologia\n4 - Filosofia  ");
      opcao = Console.ReadLine();
        //geografia
        /*if (opcao=="1"){
          geo.ImprimirMenuGeografia();
        }
    }
    /*if (opcao == "2"){
      Console.WriteLine(">> AQUI TRABALHAREMOS COM CÁLCULOS, FÓRMULAS E RACIOCÍNIO LÓGICO");
    }
    /*if (opcao == "3"){
      Console.WriteLine(" >>SELECIONE A OPÇÃO DESEJADA: ");
      Console.WriteLine("1 - Português\n2 - Artes\n3 - Inglês\n4 - Espanhol");
      opcao = Console.ReadLine();
    }
    if (opcao == "4"){
      Console.WriteLine(">> SELECIONE A OPÇÃO DESEJADA: ");
      Console.WriteLine("1 - Biologia\n2 - Química\n3 - Física");
      opcao = Console.ReadLine();
    }



  } */ 
   
    

  }

}
