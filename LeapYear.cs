using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public void GetLeapYear()
        {
            Console.WriteLine("Enter Number For Leap Year");
            int iValue = Convert.ToInt32(Console.ReadLine());
            if((iValue % 4 == 0 && iValue % 100 != 0) || (iValue %400 == 0))
            {
                Console.WriteLine("It is Leap Year");
            }
            else 
            {
                Console.WriteLine("It Is Not a Leap Year");
            }

        }
    }
}
