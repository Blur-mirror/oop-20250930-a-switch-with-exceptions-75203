using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_20250930_a_switch_with_exceptions_75203.Models
{
    internal class ExceptionDemoDriver
    {
        public static void Run()
        {
            ExceptionDemo();
        }

        public static void ExceptionDemo()
        {
            string filePath = "nonexistentfile.txt";
            try
            {
                string content = System.IO.File.ReadAllText(filePath);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"IOException caught: {ex.Message}");

            }
            finally
            {
                Console.WriteLine("This is the finally block. It always runs.");

            }
            Console.WriteLine("Continuing execution after the try-catch-finally block.");
        }

    }
}
