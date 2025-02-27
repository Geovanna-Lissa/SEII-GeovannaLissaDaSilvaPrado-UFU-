using System;
using System.IO;

namespace CSCourse2
{
    class Program
    {
        public static void Main(string[] args)
        {
           string pasta = "Nova pasta";
           Directory.CreateDIrectory(pasta);
           Console.ReadKey(true);
        }
    }
}
// Este comando serve para criar um diretorio  