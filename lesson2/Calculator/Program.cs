using System;

namespace Calculator
{
   
    
        class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Введите певрое число");
                int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак");
                string operation = Console.ReadLine();
            Console.WriteLine("Введите второе число");
                int num2 = int.Parse(Console.ReadLine());
                int result = 0;
                if (operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else if (operation == "*")
                {
                    result = num1 * num2;
                }
                else if (operation == "/")
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine(" Oops...error");
                }


            Console.WriteLine("результат равен =");
                  Console.WriteLine (result);

            
            }

        }
    }

