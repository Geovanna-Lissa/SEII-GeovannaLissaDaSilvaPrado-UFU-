using System;
using System.IO;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Teste = "documentos.txt";
            string [] documentos = File.ReadAllLines(Teste);
            foreach(string documento in documentos);
            Console.WriteLine("Documento");
            Console.ReadKey(true);
        }
    }
}
// Este comando serve para ler o conteudo do documento 