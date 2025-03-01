using System;

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
}