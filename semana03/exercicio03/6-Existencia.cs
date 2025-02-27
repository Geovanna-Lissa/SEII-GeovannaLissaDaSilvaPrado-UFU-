using System;
using System.IO;

namespace CSCourse2
{
    class Program
    {
        public static void Main(string[] args)
        {
           string Teste = "arquivo.txt";
           Console.WriteLine(File.Exists(AAAA));
           File.WriteAllText(Teste, "AAAA")
           Console.WriteLine(File.Exists(AAAA));
           Console.ReadKey(true);
        }
    }
}
// Este comando serve para verificar se existe um arquivo 