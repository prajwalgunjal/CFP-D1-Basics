using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class evenodd
    {
        public void oodeven()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("odd");
        }
    }
}
