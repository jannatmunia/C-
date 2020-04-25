using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //swapping two numbers using third numbers
            int a, b, c;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapp: a = {0} and b = {1}", a, b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swapp: a = {0} and b = {1}", a, b);
            Console.ReadKey();

        }
    }
}
