using System;
namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;
            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("y is less than x");
            }
            Console.ReadKey();
        }
    }
    }

