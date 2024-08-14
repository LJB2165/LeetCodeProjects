using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class RomanToIntegerConverter
    {
        public int RomanToInt(string s)
        {
            // Dictionary to store the value of each Roman numeral symbol
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int total = 0; // Initialize the total to 0
            int length = s.Length;

            // Iterate through each character in the string
            for (int i = 0; i < length; i++)
            {
                // Get the value of the current Roman numeral
                int value = romanValues[s[i]];

                // Check if we are not at the last character and the next character is larger
                if (i + 1 < length && romanValues[s[i + 1]] > value)
                {
                    // If next character is larger, subtract the current value
                    total -= value;
                }
                else
                {
                    // Otherwise, add the current value to the total
                    total += value;
                }
            }

            return total; // Return the computed integer value
        }
    }

}
