using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional_Statement_ASS
{
    class Alphabetvowel
    {
        public static void Main(String[]args)
        {
           
            Console.WriteLine("Enter a alphabet");
            Char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("consontant");
            }

        }
    }
}
