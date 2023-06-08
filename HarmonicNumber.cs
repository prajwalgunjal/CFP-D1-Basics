using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class HarmonicNumber
    {
        public void HarmonicNumberr() {
            Console.WriteLine("Enter the value of n to find harmonic number ");
            int harmonicValue = int.Parse(Console.ReadLine());
            double harmonicNumber = 0.0;
            if (harmonicValue != 0)
            {
                for (int i = 1; i <= harmonicValue; i++) {
                    harmonicNumber = harmonicNumber+(double)1 / i;
                    Console.WriteLine(harmonicNumber);
                }
            }
            else
            {
                Console.WriteLine("Please enter values greater than 0 ");
            }
        }
    }
}
