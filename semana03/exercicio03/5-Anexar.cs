using System;
using System.IO;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
           string Teste = "documentos.txt";
           string conteudo = File.ReadAllText(Teste);
           Console.WriteLine("Conteudo do Arquivo");
           Console.WriteLine(conteudo);
           Console.WriteLine("\n");
           File.AppendAllText(Teste, "Um outro Arquivo");
           Console.ReadKey(true);
        }
    }
}
// Este comando serve para pegar um arquivo de texto, ler ele e adcionar em outro arquivo diferente