using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class LargestNumber
    {
        public void LargestNum()
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                if (a >= c)
                    Console.WriteLine(a + " is the largest number.");
                else
                    Console.WriteLine(c + " is the largest number.");
            }
            else
            {
                if (b >= c)
                    Console.WriteLine(b + " is the largest number.");
                else
                    Console.WriteLine(c + " is the largest number.");
            }
        }
    }
}
