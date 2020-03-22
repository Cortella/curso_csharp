using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double Nota2 = double.Parse(Console.ReadLine());
            double Media = (Nota1 + Nota2) / 2;
           if((Media >= 7) && (Media != 10))
            {
                Console.WriteLine("Aprovado !!!");
            }
           if(Media < 7)
            {
                Console.WriteLine("Reprovado!");
            }
           if(Media == 10)
            {
                Console.WriteLine("Aprovado com Distincao");
            }
        }
    }
}
