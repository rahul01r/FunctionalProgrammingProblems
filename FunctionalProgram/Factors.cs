using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class Factors
    {
        public void Fact()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + "");
                    num = num / i;
                }
            }
        }
    }
}
