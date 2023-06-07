using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class FindLargest
    {
        public void FindLargestNumber() {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());  
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + "is a biggest number ");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is a biggest number");
            }
            else
            {
                Console.WriteLine(c + "is a biggest number");
            }
        }
    }
}
