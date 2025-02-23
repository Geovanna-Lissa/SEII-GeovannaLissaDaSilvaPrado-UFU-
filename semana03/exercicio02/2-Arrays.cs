using System;

class Program
{
    static void Main()
    {
      string [] myArray = new string[7];
      myArray[0] = "Segunda";
      myArray[1] = "Terça";
      myArray[2] = "Quarta";
      myArray[3] = "Quinta";
      myArray[4] = "Sexta";
      myArray[5] = "Sabado";
      myArray[6] = "Domingo";

      for (int i=0; i < myArray.Length; i++)
      {
       Console.WriteLine(myArray[i]); 
      }

     //Neste codigos eu dei valores a minha Array e estou pedindo para printar todos os valores por meio do for.  
    }
}

