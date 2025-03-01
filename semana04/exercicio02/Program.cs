using System;

namespace Exercicio02

{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto a partir do pessoa
            Pessoa obj = new Pessoa();
            obj.nome = "Geovanna";
            obj.idade = 22;
            obj.mensagem();
        
        }
    }
}