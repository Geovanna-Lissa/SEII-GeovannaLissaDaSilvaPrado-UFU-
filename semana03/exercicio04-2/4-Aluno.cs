using System;

namespace 4-Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Alice";
            a.nota1 = 9;
            a.nota2 = 6;
            a.mensagem();
        }
    }
}