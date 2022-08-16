using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Day3
{
    class Greatestbetween3
    {
        public static void Main(String[]args)
        {
            int a = 12;
            int b = 34;
            int c = 32;
            if(a>b && a>c)
            {
                Console.WriteLine("A is greater");
            }
            else if(b>c && b>a)
            {
                Console.WriteLine("B is greater");
            }
            else
            {
                Console.WriteLine("C is greater");
            }
        }
    }
}
