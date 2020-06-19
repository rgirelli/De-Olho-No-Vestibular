using System;
using System.IO;

class Aluno : Areas{
 
  protected string nome;
  //protected string cpf;
  protected DateTime dataNascimento;
  protected string email;
  protected string area;
  protected string curso;
  protected string escolaridade;
  string opcao;

  public string Nome{

    get{
      return nome;
    }
    set{
      nome = value;
    }
  }

  /*
  public string Cpf{
    get{
      return cpf;
    }
    set{
      cpf = value;
    }
  }
  */

  public DateTime DataNascimento{
    get{
      return dataNascimento;
    }
    set{
      dataNascimento = value;
    }
  }
  public string Email{
    get{
      return email;
    }
    set{
      email = value;
    }
  }

  public string Area{
    get{
      return area;
    }
    set{
      area = value;
    }
  }

  public string Curso{
    get{
      return curso;
    }
    set{
      curso = value;
    }
  }

  public string Escolaridade{
    get{
      return escolaridade;
    }
    set{
      escolaridade = value;
    }
  }

  public void ImprimirBoasVindas(){
    Console.WriteLine(">> OLÁ, ALUNO(A)! SEJA BEM VINDO(A)!!" );
    }

    public void EfetuarCadastro(){
      Console.WriteLine("\n>> Antes de começarmos gostaríamos de saber mais sobre você. Para isso responda as perguntas a seguir: \n" );
    Console.WriteLine("Qual o seu nome? ");
    Nome = Console.ReadLine();
    Console.WriteLine("Qual a sua data de nascimento? (ano mês dia)");
    DataNascimento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Qual seu e-mail? ");
    Email = Console.ReadLine();
    Console.WriteLine("Qual a área de conhecimento de seu maior interesse?\n1- Ciências da Natureza\n2- Ciências Humanas\n3- Linguagens, Códigos e suas Tecnologias\n4- Matemática e suas Tecnologias\n5- Redação ");
    Area = Console.ReadLine();
      if(Area=="1"){
        Area = ("Ciências da Natureza");
      }
      if(Area=="2"){
        Area = ("Ciências Humanas");
      }
      if(Area=="3"){
        Area = ("Linguagens, Códigos e suas Tecnologias");
      }
      if(Area=="4"){
        Area = ("Matemática e suas Tecnologias");
      }
      if(Area=="5"){
        Area = ("Redação");
      }
    Console.WriteLine("Qual o curso pretendido? ");
    Curso = Console.ReadLine();
    Console.WriteLine("Você já acabou o ensino médio? (s/n)");
    Escolaridade = Console.ReadLine();
      if(Escolaridade == "s"){
        Escolaridade = ("Ensino médio concluído.");
      }
      if(Escolaridade== "n"){
        Escolaridade = ("Ensino médio incompleto.");
      }
      
    using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"Registro.txt", true))
        {
            file.WriteLine("\n** SOBRE VOCÊ **\n>> Nome: "+Nome+ "\n>> Data de nascimento: "+DataNascimento+ "\n>> E-mail: "+Email+"\n>> Área de conhecimento: "+Area+"\n>> Curso escolhido: "+Curso+"\n>> Escolaridade: "+Escolaridade );
        }


   }
    }
    