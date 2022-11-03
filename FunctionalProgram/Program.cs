namespace FunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select program \n1.Flip Coin \n2.Leap Year\n3.Power of Two numbers");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Coin();
                    break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.yearcheck();
                    break;
                    case 3:
                        PowerOfTwoNum powerOfTwoNum = new PowerOfTwoNum();
                        powerOfTwoNum.Read();
                        break;
                }
            }
        }
    }
}