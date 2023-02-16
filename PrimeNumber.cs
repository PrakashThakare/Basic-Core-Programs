using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PrimeNumber
    {
        public void GetPrimeNumber()
        {
            int i;
            Console.WriteLine("Enter Number For Check Prime Number Or Not");
            int iValue = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < iValue; i++) 
            {
                if(iValue % i == 0)
                {
                    Console.WriteLine("It is Not Prime Number");
                    return;
                }
            }
            Console.WriteLine("It Is Prime Number");
        }
    }
}
