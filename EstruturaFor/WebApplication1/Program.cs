using System;

public class HelloWorld
{
    public static void Main()
    {
        int soma = 0;
        for (int contador = 1; contador <= 10; contador++)
        {
            soma += contador;
        }

        Console.WriteLine("A soma dos numeros de 1 a 10 e: " + soma);
    }
}