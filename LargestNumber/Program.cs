using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4,largest;
            Console.WriteLine("Enter the number 1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 3:");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 4:");
            n4 = Convert.ToInt32(Console.ReadLine());

            if(n1>n2 && n1 > n3 && n1>n4)
            {
                largest = n1;
            }
            else if(n2>n1 && n2>n3 && n2>n4)
             {
                largest = n2;
            }
            else if(n3>n1 && n3>n2 && n3 > n4)
            {
                largest = n3;
            }
            else
            {
                largest = n4;
            }
            Console.WriteLine("Largest among: {0},{1},{2},{3} is {4}", n1, n2, n3, n4, largest);
            Console.ReadKey();
        }
    }
}
