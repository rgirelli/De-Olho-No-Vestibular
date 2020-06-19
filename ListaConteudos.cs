//checklist
using System;
using System.IO;
class ListaConteudos{
  public void ImprimirLista(){
    string[] lines = File.ReadAllLines("ConteudosGerais.txt");
     
    foreach(var line in lines) Console.WriteLine(line);
  }
  
}