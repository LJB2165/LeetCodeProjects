public class WordPattern
{
    public bool WordPatterns(string pattern, string s)
    {
        // Split the input string into words
        string[] words = s.Split(' '); // Split the string 's' into words

        // Check if the pattern length matches the number of words
        if (pattern.Length != words.Length)
        {
            return false; // If lengths don't match, return false
        }

        // Initialize empty dictionaries
        Dictionary<char, string> charToWord = new Dictionary<char, string>(); // Maps each character in the pattern to a word in 's'
        Dictionary<string, char> wordToChar = new Dictionary<string, char>(); // Maps each word in 's' back to a character in the pattern

        for (int i = 0; i < pattern.Length; i++) // Iterate over the pattern and corresponding words
        {
            char c = pattern[i]; // Get the 'i'th character from the pattern
            string word = words[i]; // Get the 'i'th word from words

            // Check if the character is already mapped to a word
            if (charToWord.ContainsKey(c))
            {
                // Check if the current word matches the mapped word for the character
                if (charToWord[c] != word)
                {
                    return false; // If not, return false
                }
            }
            else
            {
                // Add the new character-to-word mapping
                charToWord.Add(c, word);
            }

            // Check if the word is already mapped to a character
            if (wordToChar.ContainsKey(word))
            {
                // Check if the current character matches the mapped character for the word
                if (wordToChar[word] != c)
                {
                    return false; // If not, return false
                }
            }
            else
            {
                // Add the new word-to-character mapping
                wordToChar.Add(word, c);
            }
        }

        return true; // If all checks pass, return true
    }
}








