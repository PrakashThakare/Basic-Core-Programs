namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** LOGICAL PROGRAMS ****************");
            Console.WriteLine("Enter Number :\n1.Flip Coin\n2.Leap Year\n3.Prime Number");
            int iValue = Convert.ToInt32(Console.ReadLine());
            switch(iValue)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.GetFlipCoin();
                break;
                case 2:
                    LeapYear obj = new LeapYear();
                    obj.GetLeapYear();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.GetPrimeNumber();
                    break;
                case 4:
                    default:
                    Console.WriteLine("Enter the Wrong Number Please Enter Again");
                    break;
                    
            }
            
        }
    }
}