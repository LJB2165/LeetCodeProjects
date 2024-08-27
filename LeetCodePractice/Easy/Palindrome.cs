using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class Palindrome
    {
        public bool IsPalindrome(string s)
        {
            // Initialize two pointers
            int left = 0;
            int right = s.Length - 1;

            while (left < right) //As long as left is less than right the loop will continue
            {
                // Move the left pointer to the next alphanumeric character
                while (left < right && !Char.IsLetterOrDigit(s[left])) //nested while loop // both have to be true//checks if character in not a digit or letter
                {
                    left++;
                }

                // Move the right pointer to the previous alphanumeric character
                while (left < right && !Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                // Compare the characters at the left and right pointers
                if (Char.ToLower(s[left]) != Char.ToLower(s[right])) //converted characters to lowercase
                {
                    return false; // If they don't match, it's not a palindrome
                }

                //else

                // Move the pointers inward
                left++; // left is incremented and right is decremented if characters match
                right--;
            }

            // If all characters match, it is a palindrome
            return true;
        }
    }
}