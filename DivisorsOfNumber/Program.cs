using System;

namespace DivisorsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a natural number:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The divisors for the number {0} are ", number);

            for(int divisor = 1;divisor<= number; divisor++)
            {
                if((number%divisor)==0)
                {
                    Console.WriteLine("{0}", divisor);
                }
            }
            Console.ReadKey();
        }
    }
}
