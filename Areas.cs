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
  public string opcao;
  
  public string AreaConhecimento{
    get{
      return areaConhecimento;
    }
    set{
      areaConhecimento = value;
    }
  }

  public void ImprimirAreas(){
    //herança multinivel
    Console.WriteLine(">> ESCOLHA A OPÇÃO REFERENTE A ÁREA DE CONHECIMENTO DESEJADA: ");
    Console.WriteLine("1 - Ciências Humanas e suas Tecnologias\n2 - Matemática e suas Tecnologias\n3 - Linguagens, Códigos e suas Tecnologias\n4 - Ciências da Natureza e suas Tecnologias");
    opcao = Console.ReadLine();
    if (opcao == "1"){
      Console.WriteLine(">> SELECIONE A OPÇÃO DESEJADA: ");
      Console.WriteLine("1 - Geografia\n2 - História\n3 - Sociologia\n4 - Filosofia  ");
      opcao = Console.ReadLine();
    }
    if (opcao == "2"){
      Console.WriteLine(">> AQUI TRABALHAREMOS COM CÁLCULOS, FÓRMULAS E RACIOCÍNIO LÓGICO");
    }
    if (opcao == "3"){
      Console.WriteLine(" >>SELECIONE A OPÇÃO DESEJADA: ");
      Console.WriteLine("1 - Português\n2 - Artes\n3 - Inglês\n4 - Espanhol");
    }
    if (opcao == "4"){
      Console.WriteLine(">> SELECIONE A OPÇÃO DESEJADA: ");
      Console.WriteLine("1 - Biologia\n2 - Química\n3 - Física");
    }



  }

  
}