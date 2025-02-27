using System;
using System.IO;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string arquivo = "arquivoaula.txt";
            string texto = File.ReadAllText(arquivo);
            Console.WriteLine("Conteudo do arquivo:" + texto);
            Console.ReadKey(true);
        }
    }
}
// Este comando serve para ler um arquivo de texto e imprimir o conteúdo 