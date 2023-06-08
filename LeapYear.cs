using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BasicCode
{
    public class LeapYear
    { 
        public void leapyear()
        {
            Console.WriteLine("Enter year to check wether it is leap year or not");
            int year = int.Parse(Console.ReadLine());
            // int year3= Convert.ToInt32(Console.ReadLine()); 
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("this is leap year");
                    }
                    else
                    {
                        Console.WriteLine("it is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("it is leap year ");
                }
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }

    }
}