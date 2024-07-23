using CalculadoraUpper;
using System;

public class Calculadora
{
    public static void Main()
    {
        Console.WriteLine("Escolha uma operacao:");
        Console.WriteLine("1 - Adicao");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - multiplicacao");
        Console.WriteLine("4 - divisao");

        Console.Write("Opcao: ");
        int operador = Convert.ToInt32(Console.ReadLine());

        switch (operador)
        {
            case 1:
                var Adicao = new Adição();
                Adicao.RealizarAdicao();
                break;

            case 2:
                var Subtracao = new Subtração();
                Subtracao.RealizarSubtracao();
                break;

            case 3:
                var Multiplicacao = new Multiplicação();
                Multiplicacao.RealizarMultiplicacao();
                break;

            case 4:
                var Divisao = new Divisão();
                Divisao.RealizarDivisao();
                break;
            default:
                Console.WriteLine("Opcao invalida. Escolha uma opcao valida.");
                break;

        }
    }
}