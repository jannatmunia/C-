using System;
namespace MultipleTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Print Multiplication Table 
             */
            int factor1, factor2;
            Console.WriteLine("Enter a number:");
            factor1 = Convert.ToInt32(Console.ReadLine());

            for(factor2 = 1; factor2 <= 25; factor2++)
            {
                Console.WriteLine("{0}*{1} = {2}",factor1,factor2,(factor1*factor2));
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
