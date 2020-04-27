using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double area,b,h;
            Console.WriteLine("Enter the base of triangle:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle:");
            h = Convert.ToDouble(Console.ReadLine());
            /* Formula of a Triangle
            Area = (b*h)/2  where b is the base and h is the height of the triangle.
            */
            area = (b * h) / 2;
            Console.WriteLine("Area of triangle with base and height is {0},{1} and area is {2}", b, h, area);
            Console.ReadKey();
        }
    }
}
