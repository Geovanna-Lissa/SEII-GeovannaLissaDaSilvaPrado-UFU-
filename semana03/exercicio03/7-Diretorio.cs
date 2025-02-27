using System;
using System.IO;

namespace CSCourse2
{
    class Program
    {
        public static void Main(string[] args)
        {
           string diretorio = "pasta";
           if(Directory.Exists(diretorio))
           {
            Console.WriteLine("Ele existe");
           }
           else 
           {
            Console.WriteLine("Não existe");
           }
           Console.ReadKey(true);
        }
    }
}
// Este comando serve para verificar se existe um diretorio ou não  