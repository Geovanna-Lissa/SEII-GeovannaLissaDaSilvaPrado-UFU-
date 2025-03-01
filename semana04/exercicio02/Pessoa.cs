using System;

namespace Exercicio02 
// O mesmo namespace de Program.cs
{
    class Pessoa
    {
        public string nome="";
        public int idade;

        public void mensagem()
        {
            Console.WriteLine("Meu nome é "+nome+" minha idade é "+idade+" anos");
        }
    }
}