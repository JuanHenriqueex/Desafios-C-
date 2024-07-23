namespace CalculadoraUpper
{
    public class Multiplicação
    {
        public void RealizarMultiplicacao()
        {
            Console.Write("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 * num2;
            Console.WriteLine("O resultado da multiplicacao de " + num1 + " e " + num2 + " sera " + resultado);
        }
    }
}
