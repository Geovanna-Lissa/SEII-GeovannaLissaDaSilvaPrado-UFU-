using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      List<string> list = new List<string>();   
      list.Add("Arroz");
      list.Add("Feijão");
      list.Add("Macarrão");
      list.Add("Carne");
      list.Add("Café");
      list.Add("Sabão");
      list.Add("Pão");

      for (int i=0; i < list.Count; i++)
      {
       Console.WriteLine(list[i]); 
      }

    }
}
//Este comando serve para criar uma lista, adicionar strings nela e printar tudo o que foi adicionado