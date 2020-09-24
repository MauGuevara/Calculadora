using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        public static double operation, firstNumber, secondNumber, result;

        static void Main(string[] args)
        {
            menu();
        }

		static void menu()
		{
            do
			{
                Console.Clear();
                Console.WriteLine("----------CALCULADORA----------");
                Console.WriteLine("1.- Sumar");
                Console.WriteLine("2.- Restar");
                Console.WriteLine("3.- Multiplicar");
                Console.WriteLine("4.- Dividir");
                Console.WriteLine("0.- Salir");
                Console.WriteLine("-------------------------------");
                operation = int.Parse(Console.ReadLine());

				switch (operation)
				{
					case 1:
                        enterNumber();
                        add();
                        showResult();
                        break;

					case 2:
                        enterNumber();
                        subtract();
                        showResult();
                        break;

                    case 3:
                        enterNumber();
                        multiply();
                        showResult();
                        break;

                    case 4:
                        enterNumber();
                        divide();
                        showResult();
                        break;
				}

			} while (operation != 0);

		}

        static void enterNumber()
        {
            Console.WriteLine("ingresa primer numero");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa segundo numero");
            secondNumber = int.Parse(Console.ReadLine());
        }

        static void add() 
        {
            result = firstNumber + secondNumber;
        }

        static void subtract()
        {
            result = firstNumber - secondNumber;
        }

        static void multiply()
        {
            result = firstNumber * secondNumber;
        }

        static void divide()
        {
            result = firstNumber / secondNumber;
        }

        static void showResult()
        {
            Console.WriteLine($"El resultado es: {result}");
            Console.ReadLine();
        }
    }
}
