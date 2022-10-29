using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class FlipCoin
    {
        public void Coin()
        {
            int n, h_cnt = 0, t_cnt = 0;
            Console.WriteLine("Enter no. of times you want to flip the coin");
            n = Convert.ToInt32(Console.ReadLine());
            double heads, tails;

            for (int j = 0; j <= n; j++)
            {
                Random rand = new Random();
                double random = rand.Next(0, 2);
                if (random < 0.5)
                    t_cnt++;
                else
                    h_cnt++;
            }
            heads = h_cnt / (double)n * 100;
            tails = t_cnt / (double)n * 100;
            Console.WriteLine("Percentage of heads: " + heads + "%");
            Console.WriteLine("Percentage of tails: " + tails + "%");
        }
    }
}

