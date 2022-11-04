namespace FunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select program \n1.Flip Coin \n2.Leap Year\n3.Power of Two numbers\n4.Harmonic Number\n5.Factors of Number \n6.QuotientRemainder \n7.Swap Two Numbers \n8. check Given Number is Even or Odd \n9. Check an Alphabet is Vowel or Consonant \n10.Find the Largest Among Three Numbers");
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
                    case 7:
                        SwapTwoNumber swapTwoNumber = new SwapTwoNumber();
                        swapTwoNumber.Swap();
                        break;
                    case 8:
                        EvenOrOdd evenOrOdd = new EvenOrOdd();
                        evenOrOdd.EvenandOdd();
                        break;
                    case 9:
                        AlphabateIsVowelOrConsonant alphabateIsVowelOrConsonant = new AlphabateIsVowelOrConsonant();
                        alphabateIsVowelOrConsonant.Alphabet();
                        break;
                    case 10:
                        LargestNumber largestNumber = new LargestNumber();
                        largestNumber.LargestNum();
                        break;
                }
            }
        }
    }
}