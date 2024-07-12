using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ItemsMethods
    {
        public static void ShowDate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Current Date: " + date.ToString("dd.MM.yyyy"));
        }

        public static void ShowTime()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("Current Date: " + time.ToString("HH:mm:ss"));
        }

        public static void ShowVersion()
        {
            int[] versionNumbers = { 24, 2, 4, 9504 };
            string formated = string.Join(".", versionNumbers);
            Console.WriteLine($"Version", formated);
        }

        public static void CountCapitals()
        {
            Console.WriteLine("Please enter your sentence:");
            string input = Console.ReadLine();

            int capitalLetterCount = 0;
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    capitalLetterCount++;
                }
            }

            Console.WriteLine($"The are {capitalLetterCount} capital letters in your sentence.");
        }
    }
}
