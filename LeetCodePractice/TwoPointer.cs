using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class TwoPointer
    {
        public bool IsSubsequence(string s, string t)
        {
            int a = 0;
            int b = 0;
            while (a < s.Length && b < t.Length)

            {
            if (s[a] == t[b])
                {
                    a++;
                }
            
                b++;
            
            }
            return a == s.Length; 


        }
        

    }
}
