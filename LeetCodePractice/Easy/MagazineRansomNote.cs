using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class MagazineRansomNote
    {

        public bool CanConstruct(string ransomNote, string magazine)
        {
            // key-value pair using char and int to store the letters and their counts
            Dictionary<char, int> magazineCount = new Dictionary<char, int>();

            foreach (char c in magazine) // iterate through magazine 
            {
                if (magazineCount.ContainsKey(c)) //check to see if "c" is already a key in the magazinecount using ContainsKey
                {
                    magazineCount[c]++; // if it does exist increment by 1
                }
                else
                {
                    magazineCount[c] = 1; // if it is not then we add the char + 1
                }
            }

            // Check if each character in ransomNote can be found in magazine
            foreach (char c in ransomNote) // iterate through each char c in ransomeNote
            {
                if (magazineCount.ContainsKey(c) && magazineCount[c] > 0) // checking if c from ransomeNote exists with a value from dict
                {
                    magazineCount[c]--; // decrement if it does because char has now been used
                }
                else
                {
                    return false; // if c in ransomenote doesnt exist or has zero usability left then it returns false and ransomNote cannot be constructed from dictionary
                }
            }

            return true;
        }
    }
}

