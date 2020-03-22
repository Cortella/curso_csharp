using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em metros");
            double metros = double.Parse(Console.ReadLine());
            double centimetros = metros * 100;
            Console.WriteLine(metros + "metros  são " + centimetros + " centimetros");
        }
    }
}
