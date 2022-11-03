using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class HarmonicNumber
    {
        int n = 5;
        double value = 0.0;
        public void Number()
        {

            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                value += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, value);
        }
    }
}
