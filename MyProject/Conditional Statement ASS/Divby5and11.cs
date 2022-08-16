using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional_Statement_ASS
{
    class Divby5and11
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0) 
            {
                Console.WriteLine("Divisible by 5");
            }
            else if(num%11==0)
            {
                Console.WriteLine("Divisible by 11");
            }
            else
            {
                Console.WriteLine("Not divisible 5 and 11");
            }

        }
    }
}
