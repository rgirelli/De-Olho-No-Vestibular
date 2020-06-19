using System;
using System.IO;

class Atualidades{
  public void ImprimirAtualidades(){
    string[] lines = File.ReadAllLines("Atualidades.txt");
   
    foreach(var line in lines) Console.WriteLine(line);
  }
}