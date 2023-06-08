using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class FibonacciSeries
    {
        public void Fibonacciseries() {
            Console.WriteLine("Enter a number till that number series will print");
            int num = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i <= num; i++) {
                sum = a + b;
                Console.WriteLine(sum+" ");
                a = b;
                b = sum;
            }
        }
    }
}
