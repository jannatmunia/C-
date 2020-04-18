using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            /*
             while(condition)
             {
                statements;
             }
             */
            while (count < x)
            {
                Console.Write("The value is {0} \n", x);
                if (x == 4)
                    break;
                x--;

            }
            Console.ReadKey();
        }
    
    }
}
