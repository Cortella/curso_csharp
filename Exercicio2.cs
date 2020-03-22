using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do retangulo");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo");
            double h = double.Parse(Console.ReadLine());
            double area = b * h;
            Console.WriteLine("Area = " + area);
        }
    }
}
