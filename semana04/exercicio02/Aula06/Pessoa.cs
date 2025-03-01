using System;

class Pessoa
{
    public double peso, altura;

    public double calculo()
    {
        return peso/(altura*altura);
    }

    public string situacao(double imc)
    {
        string retorno;
        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        if (imc < 25)
        {
            retorno = "Peso normal";
        }
        if(imc < 30)
        {
            retorno= "Acima do peso";
        }
        if(imc < 35)
        {
            retorno= "Obesidade 1";
        }
        if(imc < 40)
        {
            retorno= "Obesidade 2";
        }
        else 
        {
            retorno= "Obesidade 3";
        }

        return retorno;
    }

    public void mensagem()
    {
        double obterCalculo = calculo();

        string obterSituacao = situacao(obterCalculo);

        Console.WriteLine("Meu IMC é de "+obterCalculo);
        Console.WriteLine("Minha situcao é"+obterSituacao);
    }

}