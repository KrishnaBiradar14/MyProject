using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional_Statement_ASS
{
    class Leapyear
    {
        public static void isLeapYear(int year)
        {
            // flag to take a non-leap year by default
            bool is_leap_year = false;

            // If year is divisible by 4
            if (year % 4 == 0)
            {
                is_leap_year = true;
                // To identify whether it
                // is a century year or
                // not
                if (year % 100 == 0)
                {
                    // Checking if year is divisible by 400
                    // therefore century leap year
                    if (year % 400 == 0)
                        is_leap_year = true;
                    else
                        is_leap_year = false;
                }
            }
            
            else
                // Flag dealing-  Non leap-year
                is_leap_year = false;
            if (!is_leap_year)
               Console.WriteLine(year + " : Non Leap-year");
            else
                Console.WriteLine(year + " : Leap-year");
        }
        public static void Main(String[] args)
        {
            isLeapYear(2000);

            // Calling our function by
            // passing Non-century year
            //isLeapYear(2002);
        }
    }
}
