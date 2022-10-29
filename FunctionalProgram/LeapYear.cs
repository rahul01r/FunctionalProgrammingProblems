using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class LeapYear
    {
        public void yearcheck()
        {
            int year, n;


            Console.WriteLine("enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            string num = year.ToString();
            n = num.Length;
            // CHECK LENGTH CONDITION
            if (n != 4)
            {
                Console.WriteLine("enter year as 4 digit number");
                return;
            }
            // COMPUTATION
            {
                if (year % 400 == 0 && year % 100 == 0)
                    Console.WriteLine("year " + year + " is a leap year");

                if (year % 100 != 0 && year % 4 == 0)
                    Console.WriteLine("year " + year + " is a leap year");

                else
                    Console.WriteLine("year " + year + " is not a leap year");
            }
        }
    }
}
