using System;
using System.IO;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] documentos = {"Documento 1.", "Documento 2."};
            string Teste = "documentos.txt";
            File.WriteAllLines(Teste, documentos);
            Console.WriteLine("O arquivo foi criado");
            Console.ReadKey(true);
        }
    }
}
// Este comando serve para criar um documento em txt