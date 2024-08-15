using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class Isomorphic
    {
        public bool AreStringsIsomorphic(string str1, string str2)
        {
            
            if (str1.Length != str2.Length) //cant be isomorphic if not the same length 
                return false;

            
            Dictionary<char, char> mapStr1ToStr2 = new Dictionary<char, char>(); //both key and values are type char
            Dictionary<char, char> mapStr2ToStr1 = new Dictionary<char, char>();

            
            for (int i = 0; i < str1.Length; i++) //for loop that iterates through each char in strings // less than the length//increments
            {
                char charFromStr1 = str1[i]; //characters are stored in variables 
                char charFromStr2 = str2[i];

                // Check if charFromStr1 is already mapped to a character in str2
                if (mapStr1ToStr2.ContainsKey(charFromStr1))
                {
                    // If the mapped character is not charFromStr2, return false
                    if (mapStr1ToStr2[charFromStr1] != charFromStr2)
                        return false;
                }
                else
                {
                    // Add the mapping from charFromStr1 to charFromStr2
                    mapStr1ToStr2[charFromStr1] = charFromStr2;
                }

                // Check if charFromStr2 is already mapped to a character in str1
                if (mapStr2ToStr1.ContainsKey(charFromStr2))
                {
                    // If the mapped character is not charFromStr1, return false
                    if (mapStr2ToStr1[charFromStr2] != charFromStr1)
                        return false;
                }
                else
                {
                    // Add the mapping from charFromStr2 to charFromStr1
                    mapStr2ToStr1[charFromStr2] = charFromStr1;
                }
            }

            // If all character mappings are consistent, return true
            return true;
        }
    }
}

