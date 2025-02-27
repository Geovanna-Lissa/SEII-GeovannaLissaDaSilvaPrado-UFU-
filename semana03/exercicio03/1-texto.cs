using System;
using System.IO;

namespace CSCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Teste = "arquivoaula.txt";
            string texto = "Estou escrevendo um textoo.";
            File.WriteAllText(Teste, texto);
            Console.WriteLine("Arquivo criado com sucesso!");
            Console.ReadKey(true);
        }
    }
}
// Este comando serve para escrever um texto, imprimi-lo e salva-lo no arquivo desejado 