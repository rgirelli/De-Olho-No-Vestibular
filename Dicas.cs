using System;
using System.IO;

class Dicas{
  public void ImprimirDicasGerais(){
    string[] lines = File.ReadAllLines("Dicas.txt");
   
    foreach(var line in lines) Console.WriteLine(line);
  }
}