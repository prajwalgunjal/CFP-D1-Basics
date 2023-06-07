using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class Powerof2
    {
        public void power() {
            Console.WriteLine("Enter the number till that you want to print the table of 2 : - ");
            int a = int.Parse(Console.ReadLine());
            int ans;
            if (a <= 37)
            {
                for (int i = 0; i <= a; i++)
                {
                    ans = 2 * i;
                    Console.WriteLine("2^" + i + "=" + ans);
                }        
            }
        }
    }
}
