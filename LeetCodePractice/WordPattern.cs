using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class WordPattern
    {
        public bool WordPatterns(string pattern, string s)
        {
            // Split the input string into words
            string[] words = s.Split(' '); //so that we pick up the whole word as a single index during iteration 

            //initialize empty dictionaries
            Dictionary<char, string> charToWord = new Dictionary<char, string>(); //maps each character in the pattern to a word in 's'
            Dictionary<string, char> wordToChar = new Dictionary<string, char>(); //maps each word in 's' back to a character in the pattern


            for (int i = 0; i < pattern.Length; i++) // Iterate over the pattern and corresponding words
            {
                char c = pattern[i]; //receives the 'i'th character  from the pattern
                string word = words[i]; // receives the ith word from words


                if (charToWord.ContainsKey(c)) // Checks if the dictionary charToWord already has an entry for the character c
                {
                    if (charToWord[c] != word) // checks if the word currently associated with 'c' in the dictionary is the same as the current word being processed
                    // checking whether a character in the pattern corresponds to more than one word
                    {
                        return false;
                    }
                }

                else
                {
                    charToWord.Add(c, word);
                }
            }
            return true;
        }

    }
}



                     
   

                
