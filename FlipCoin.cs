using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoin
    {
        public void GetFlipCoin()
        {
            int iTail = 0, iHead = 0;
            Console.WriteLine("Enter Number of times to Flip Coins");
            int iValue = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i <= iValue; i++)
            {
                Double iInput = random.NextDouble();
                if (iInput < 0.5)
                {
                    iTail++;
                }
                else
                {
                    iHead++;
                }

            }
            int iTailPercetage = ((iTail * 100) / iValue);
            int iHeadPercentage = ((iHead * 100) / iValue);
            Console.WriteLine("Percentage of Tail :" + iTailPercetage);
            Console.WriteLine("Percentage of Head :" + iHeadPercentage);
        }
    }
}
