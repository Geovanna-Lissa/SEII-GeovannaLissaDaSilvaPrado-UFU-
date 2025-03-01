using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Sara";
            a.nota1 = 3;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}