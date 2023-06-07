using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class vowel
    {
        public void Checkvowel() {
            Console.WriteLine("Enter a character to check");
            string a = Console.ReadLine();
            if (a == "a" || a == "e" || a == "i" ||a == "o" || a=="u") {
                Console.WriteLine("its a vowel");
            }
            else
            {
                Console.WriteLine("not vowel");
            }
        }
    }
}
