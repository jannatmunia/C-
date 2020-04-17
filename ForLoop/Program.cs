using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             for(initialization;condition;increment/decrement)
             {
                statements;
             }
             */
            for (int z = 20; z > 0; z--)
            {
                Console.Write("Values are : {0}\n", z);
            }
            Console.ReadKey();

        }
    }
}
