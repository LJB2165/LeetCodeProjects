using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class LengthofLastWord
    {

        public int LengthOfLastWord(string s)
        {
            
            s = s.Trim();

            
            int lastSpaceIndex = s.LastIndexOf(' ');

            
            return s.Length - lastSpaceIndex - 1;
        }
    }
}

