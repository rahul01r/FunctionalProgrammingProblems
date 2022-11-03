using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class PowerOfTwoNum
    {
        const int value = 2;
        public void Read() //Reading input from user
        {
            int n;
            Console.Write("Enter the Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            power(n);
        }
        private static void power(int n)
        {                                           // Check the Conditions of Power of two by using ForLoop
            for (int power = 0; power <= n; power++)
            {                                       // Appying the formula of Power by using Math.Pow Method   
                Console.WriteLine("{0}^{1} = {2:N0} ", value, power, (long)Math.Pow(value, power));
                Console.ReadLine();
            }
        }
    }
}
