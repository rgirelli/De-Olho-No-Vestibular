using System;
using System.IO;

class Literatura : ListaConteudos{
  private string autores;
  private string generoLiterario;
  private string livro;
  string opcao;

  public string Autores{
    get{
      return autores;
    }
    set{  
      autores = value;
    }
  }

  public string GeneroLiterario{
    get{
      return generoLiterario;
    }
    set{
      generoLiterario = value;
    }
    
  }

  public string Livro{
    get{
      return livro;
    }
    set{
      livro = value;
    }
  }

  public void ListarLivros(){
    Console.WriteLine("A seguir a lista dos livros que caem com mais frequência na prova:\n1 - A Hora da Estrela\n2 - Dom Casmurro\n3 - Iracema\n4 - Memórias Póstumas de Brás Cubas\n5 - O Cortiço\n6 - Os Sertões\n7 - Quincas Borbas ");
  }



}