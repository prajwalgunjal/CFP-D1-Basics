using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    internal class PrimeFactor
    {
        public void prime() {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                while (num % i == 0)
                {
                    num = num / i;
                    Console.WriteLine(i);
                }
            }
            if (num != 1)
            {
                Console.WriteLine(num);
            }
        }
    }
}