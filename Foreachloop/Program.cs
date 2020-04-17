using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreachloop
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* 
             foreach (value in collection)
             {
              statement;
             }

             */
            string[] arr = new string[5];
            arr[0] = "jannatul Ferdous Munia";
            arr[1] = "age";
            arr[2] = "education";
            arr[3] = "religion";
            arr[4] = "family";
            foreach(string name in arr)
            {
                Console.WriteLine("Details:" + name);
            }
            Console.ReadKey();


        }
    }
}
