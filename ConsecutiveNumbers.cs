using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Section_8_Working_With_Text_Coding_Exercises
{
    public class ConsecutiveNumbers
    {
        public static bool AreNumbersConsecutive(string input)
        {
            var numbers = input.Split('-');


            for (var i = 1; i < numbers.Length; i++)
            {

                var current = Convert.ToInt32(numbers[i]);
                var previous = Convert.ToInt32(numbers[i-1]);

                if (Math.Abs(current - previous) != 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
