using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Day3
{
    class Divisibleby3_5
    {
        public static void Main(String[] args)
        {
            int a = 34;
            if (a / 3 == 0)
            {
                Console.WriteLine("Divisible by 3");
            }
            else if(a/5==0)
            {
                Console.WriteLine("Divisible by 5");
            }
            else
            {
                Console.WriteLine("Not divisible by any number");
            }


        }


    }
}
