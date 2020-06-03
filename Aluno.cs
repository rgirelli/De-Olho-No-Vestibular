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





}