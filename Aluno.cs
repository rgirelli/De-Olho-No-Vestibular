using System;
using System.IO;

class Aluno{
  protected string nome;
  protected string cpf;
  protected DateTime dataNascimento;
  protected string email;
  protected string area;
  protected string curso;
  protected string escolaridade;

  public string Nome{

    get{
      return nome;
    }
    set{
      nome = value;
    }
  }

  public string Cpf{
    get{
      return cpf;
    }
    set{
      cpf = value;
    }
  }

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

  public void CadastrarAluno(){
    Console.WriteLine("**CADASTRO DE ALUNO**" );
    Console.WriteLine("Nome: ");
    Nome = Console.ReadLine();
    Console.WriteLine("Cpf: ");
    Cpf = Console.ReadLine();
    Console.WriteLine("Data de nascimento: ");
    DataNascimento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("E-mail: ");
    Email = Console.ReadLine();
    Console.WriteLine("Área: ");
    Area = Console.ReadLine();
    Console.WriteLine("Curso: ");
    Curso = Console.ReadLine();
    Console.WriteLine("Escolaridade: ");
    Escolaridade = Console.ReadLine();

    File.WriteAllText("CadastrarAluno.txt","*CADASTRO DO ALUNO*\nNome: " +Nome +"\nCpf: " +Cpf +"\nData de Nascimento: " +DataNascimento +"\nE-mail: " +Email +"Área: " +Area +"Curso: " +Curso +"Escolaridade: " +Escolaridade);
  }
}

