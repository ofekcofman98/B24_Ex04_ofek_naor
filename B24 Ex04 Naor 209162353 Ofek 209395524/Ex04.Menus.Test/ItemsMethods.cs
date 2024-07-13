using System;

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
            Console.WriteLine("Current Time: " + time.ToString("HH:mm:ss"));
        }

        public static void ShowVersion()
        {
            int[] versionNumbers = { 24, 2, 4, 9504 };
            string formatted = string.Format("{0}.{1}.{2}.{3}", versionNumbers[0], versionNumbers[1], versionNumbers[2], versionNumbers[3]);
            Console.WriteLine("App Version " + formatted);
        }

        public static void CountCapitals()
        {
            Console.WriteLine("Please enter your sentence:");
            string userSentence = Console.ReadLine();

            int capitalLetterCount = 0;
            foreach (char c in userSentence)
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
