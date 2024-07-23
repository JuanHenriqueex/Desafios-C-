namespace CalculadoraUpper
{
    public class Divisão
    {
        public void RealizarDivisao()
        {
            Console.Write("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 / num2;
            Console.WriteLine("O resultado da divisao de " + num1 + " e " + num2 + " sera " + resultado);
        }
    }
}
