using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Day2
{
    class Percentage
    {
        public static void Main(String[] args)
        {
            int marathi = 55;
            int Hindi = 66;
            int English = 88;
            int SocialScience = 77;
            int Science = 90;
            double percentage = (marathi + Hindi + English + Science + SocialScience) / 5;
            Console.WriteLine("Percentage of 5 subject" + percentage);
        }
    }
}
