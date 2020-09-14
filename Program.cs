using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double q, w, r;
            r = 0;
            string p;
            Console.WriteLine("ingresa primer numero");
            q= int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa segundo numero");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa operador");
            p = Console.ReadLine();

            switch (p)
            {
                case "+":
                    r = q + w;
                    break;
                case "-":
                    r = q - w;
                    break;
                case "*":
                    r = q * w;
                    break;
                case "/":
                    r = q / w;
                    break;
                default:
                    Console.WriteLine("ingresar datos validos");
                    break;
            }

            Console.WriteLine($"el resultado es {r}");
        }
    }
}
