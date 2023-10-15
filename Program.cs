using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;


namespace Section_8_Working_With_Text_Coding_Exercises
{
    class Program
    {
        static int CountVowels(string word)
        {
            int count = 0;
            foreach (char letter in word.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    count++;
                }
            }
            return count;
        }
        private static bool IsValidHour(int hour)
        {
            return hour >= 0 && hour <= 23;
        }

        private static bool IsValidMinute(int minute)
        {
            return minute >= 0 && minute <= 59;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by hyphens (e.g. 5-6-7-8-9):");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided. Exiting...");
                return;
            }

            Console.WriteLine(ConsecutiveNumbers.AreNumbersConsecutive(input) ? "Consecutive" : "Not Consecutive");

            Console.Write("Enter a few numbers separated by a hyphen (-): ");

            var inputNumber = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(inputNumber))
            {
                Console.WriteLine("No input provided. Exiting...");
                return;
            }

            var numbers = inputNumber.Split('-');
            Console.WriteLine(numbers.Length != numbers.Distinct().Count() ? "Duplicate" : "No duplicates found.");

            Console.WriteLine("Type in a time value between 00:00 and 23:59");
            var userTimeInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userTimeInput))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                var hour = Convert.ToInt32(userTimeInput?.Split(':')[0]);
                var minute = Convert.ToInt32(userTimeInput?.Split(':')[1]);

                if (IsValidHour(hour) && IsValidMinute(minute))
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }

            Console.WriteLine("Ask the user to enter a few words separated by a space. For example, if the user types: 'number of students', display 'NumberOfStudents'. Make sure that the program is not dependent on the input. So, if the user types 'NUMBER OF STUDENTS', the program should still display 'NumberOfStudents'.");
            var userWordInput = Console.ReadLine();

            var wordsList = new List<string>();
            var words = userWordInput.ToLower().Split(' ');

            foreach (var word in words)
            {
                var titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);
                wordsList.Add(titleCase);
            }

            var PascalCase = string.Join("", wordsList);
            Console.WriteLine("PascalCase: {0}",PascalCase);

            Console.Write("Enter an English word: ");
            string userInput = Console.ReadLine();

            int vowelCount = CountVowels(userInput);

            Console.WriteLine($"The number of vowels in '{userInput}' is: {vowelCount}");
        }
    }
}

/*
 using System;
   
   class Program
   {
   static void Main()
   {
   Console.Write("Enter a time value in 24-hour format (e.g. 19:00): ");
   string input = Console.ReadLine();
   
   if (IsValidTime(input))
   {
   Console.WriteLine("Ok");
   }
   else
   {
   Console.WriteLine("Invalid Time");
   }
   }
   
   static bool IsValidTime(string input)
   {
   return DateTime.TryParseExact(input, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _);
   }
   }


using System;
   using System.Text.RegularExpressions;
   
   class Program
   {
   static void Main()
   {
   Console.Write("Enter an English word: ");
   string userInput = Console.ReadLine();
   
   int vowelCount = CountVowels(userInput);
   
   Console.WriteLine($"The number of vowels in '{userInput}' is: {vowelCount}");
   }
   
   static int CountVowels(string word)
   {
   string pattern = "[aeiouAEIOU]";
   Regex regex = new Regex(pattern);
   MatchCollection matches = regex.Matches(word);
   return matches.Count;
   }
   }
   
    
 
 */