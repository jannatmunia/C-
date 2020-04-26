using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Enter the radius of circle:");
            radius = Convert.ToDouble(Console.ReadLine());

            /*Formula : Circle of a Area = PI*radius*radius
             Math class is class which avaible in c# which provides mathmatical related functionalities
             like PI,Round etc.
            */
            area = Math.PI * radius *radius;
            Console.WriteLine("Area of the circle with radius {0} is {1}", radius, area);
            Console.ReadKey();

        }
    }
}
