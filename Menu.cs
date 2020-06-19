using System;
using System.IO;

class Menu{

  public void ImprimirMenu(){
  string[] lines = File.ReadAllLines("Menu.txt");
   
  foreach(var line in lines) Console.WriteLine(line);
  }

  

  
}