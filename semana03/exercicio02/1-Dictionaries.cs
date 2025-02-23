using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      Dictionary<int, string> dictionary = new Dictionary<int, string>();
      dictionary[0] = "Arroz";
      dictionary[1] = "Feijão";
      dictionary[2] = "Macarrão";
      dictionary[3] = "Carne";
      dictionary[4] = "Café";
      dictionary[5] = "Sabão";
      dictionary.Add (6 = "Pão");

      for (int i=0; i < dictionary.Count; i++)
      {
    
       Console.WriteLine(dictionary[i]);
      }

    }
}
//Este comando é utilizado para armazenar dados que armazenam pares de chave-valor,onde cada chave é única, e está associada a um valor correspondente