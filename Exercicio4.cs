using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Farenheit: ");
            double farenheit = double.Parse(Console.ReadLine());
            double celcius = (5 * (farenheit - 32) / 9);
            Console.WriteLine("Celcius = " + celcius);
        }
    }
}
