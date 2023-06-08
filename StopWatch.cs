using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    public class StopWatch
    {
        public void stopwatch()
        {
            int UserChoice;
            DateTime StartTime;
            DateTime StopTime;
            long TimeElapsed;
            while (true)
            {
                Console.WriteLine("Enter your choice \t 1) Start \t 2) stop \t 3) Exit");
                UserChoice = int.Parse(Console.ReadLine());
                switch (UserChoice)
                {

                    case 1:
                        {
                            StartTime = DateTime.Now;
                            Console.WriteLine("Stopwatch started.");
                            break;

                        }
                        case 2:
                        {
                            StopTime = DateTime.Now;

                            TimeSpan elapsed = StartTime - StopTime;
                            Console.WriteLine("Elapsed time " + elapsed);
                            break;
                        }
                        case 3:
                        {
                            break;
                        }
                }
            }
        }
    }
}
