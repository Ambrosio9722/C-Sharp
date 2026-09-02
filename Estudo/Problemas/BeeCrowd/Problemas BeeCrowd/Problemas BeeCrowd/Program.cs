using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    double n = 3.14159;

            //    double area = double.Parse(Console.ReadLine());

            //    double resultado = 0.0;

            //     resultado = n * (area * area);

            //    Console.WriteLine("A="+resultado.ToString("F4"));
            //////////////////////////////////////////////////////////////////////////////////////
            //  int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            //  int   soma = a + b;

            //  Console.WriteLine("SOMA = "+soma);
            // int a = int.Parse(Console.ReadLine());
            //  int b = int.Parse(Console.ReadLine());
            //  int PROD = a * b;

            //  Console.WriteLine("PROD = "+PROD);

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            a = a * 3.5;
            b = b * 7.5;

            double MEDIA = 0.0;
            MEDIA = (a + b) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));

           
        }
    }
}