namespace FunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select program \n1.Flip Coin \n2.Leap Year\n3.Power of Two numbers\n4.Harmonic Number\n5.Factors of Number \n6.QuotientRemainder");
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
                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.Number();
                        break;
                    case 5:
                        Factors factors = new Factors();
                        factors.Fact();
                        break;
                    case 6:
                        QuotientRemainder quotientRemainder = new QuotientRemainder();      
                        quotientRemainder.QuoRem();
                        break;
                }
            }
        }
    }
}