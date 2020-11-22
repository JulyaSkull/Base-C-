using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success;
            float first_number;
            float second_number;
            do
            {
                Console.WriteLine("Input float first number x");
                success = float.TryParse(Console.ReadLine(), out first_number);
                if (!success)
                {
                    Console.WriteLine("Incorrect value");
                }
            } while (!success);

            do
            {
                Console.WriteLine("Input float second number y");
                success = float.TryParse(Console.ReadLine(), out second_number);
                if (!success)
                {
                    Console.WriteLine("Incorrect value");
                }
            } while (!success);
            success = false;
            while (!success)
            {
                Console.WriteLine("Select the required action: +, -, /, *");
                string act = Console.ReadLine();
                switch (act)
                {
                    case "+":
                        float sum = first_number + second_number;
                        Console.WriteLine($"x + y = {sum}");
                        success = true;
                        break;
                    case "-":
                        float sub = first_number - second_number;
                        Console.WriteLine($"x - y = {sub}");
                        success = true;
                        break;
                    case "*":
                        float mult = first_number * second_number;
                        Console.WriteLine($"x * y = {mult}");
                        success = true;
                        break;
                    case "/":
                        if (second_number == 0)
                        {
                            Console.WriteLine("Divide by 0. You can't divide this.");
                            break;
                        }
                        float div = first_number / second_number;
                        Console.WriteLine($"x / y = {div}");
                        success = true;
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
