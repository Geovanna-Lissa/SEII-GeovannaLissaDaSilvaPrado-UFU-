///Classe Pessoa

using System;

class Pessoa
{
    // Atributos
    public string nome;

    public int idade;

    //Métodos ou funções;

    public void mensagem()
    {
        Console.WriteLine("Olá" +nome+ "você tem quantos anos" +idade+);
    }

    //Criar objeto
    static void Main(string[] args)
    {

        Pessoa obj = new Pessoa();
        obj.nome = "Geovanna";
        obj.idade = 22;
        obj.mensagem();
    }

}