using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class perfectNumber
    {
        public void perfectnumber() {
            Console.WriteLine("ENter a number");
            int number = int.Parse(Console.ReadLine());
            int sum=0;
            for(int i = 1; i < number; i++)
            {
                if(number%i==0)
                {
                    sum = sum + i;
                }
            }

            if(sum == number)
            {
                Console.WriteLine("it is perfect number");
            }
            else
            {
                Console.WriteLine("not a p[erfect number");
            }
        }
    }
}
