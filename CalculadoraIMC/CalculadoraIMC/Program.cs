using System;

public class HelloWorld
{
    public static void Main()
    {
        double quilos, metros, IMC;

        Console.WriteLine("Digite o seu peso em quilogramas: ");
        quilos = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a sua altura em metros: ");
        metros = Convert.ToDouble(Console.ReadLine());

        IMC = quilos / (metros * metros);

        Console.WriteLine("O seu IMC e:" + IMC);

    }
}