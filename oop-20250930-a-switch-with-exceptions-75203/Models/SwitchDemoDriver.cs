using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20250930_a_switch_with_exceptions_75203.Models
{
    internal class SwitchDemoDriver
    {
        public static void Run()
        {
            SwitchDemo();
            SwitchExpressionDemo();
            DayOfweeek();
        }

        public static void SwitchDemo()
        { 
            Console.WriteLine("SwitchDemo");
            int number = 3;
            switch(number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 3.");
            }
        }

        public static void SwitchExpressionDemo()
        {
            Console.WriteLine("SwitchExpressionDemo");
            int number = 1;
            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other"
            };
            Console.WriteLine(result);
        }

        public static void DayOfweeek()
        { 
            Console.WriteLine("DayOfweek");
            int day = 3;
            string dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Other"
            };
            Console.WriteLine(dayName);

        }

     }
}
