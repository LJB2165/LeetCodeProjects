using System;
using System.Linq;

public class AnagramChecker
{
    public bool IsAnagram(string s, string t)
    {
        // If lengths of the strings are different, they cannot be anagrams
        if (s.Length != t.Length)
        {
            return false;
        }

        // Sort both strings and compare the results
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        return sArray.SequenceEqual(tArray);
    }
}
