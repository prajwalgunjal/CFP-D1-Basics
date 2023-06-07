using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    internal class QuotientRemainder
    {
        public void findQuotient()
        {
            Console.WriteLine("Enter the value of the dividend");
            int dividend = int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter the value of the divisor");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = dividend / divisor;
            int reminder = dividend % divisor;
            Console.WriteLine("Your remainder is "+reminder);
            Console.WriteLine("Your quotient is " +quotient);
        }
    }
}
