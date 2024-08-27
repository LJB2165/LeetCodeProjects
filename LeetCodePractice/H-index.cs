using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class hfile
    {
        //[9,3,1] sort > [1,3,9] iterate > i=0 h=n-i = 3-0

        public int HIndex(int[] citations) //takes an array of integers as inputs and returns an int (h-index)
        {
                Array.Sort(citations); //smallest to largest number of citations
                int n = citations.Length; //stores the length

                for (int i = 0; i < n; i++) //iterates through each element of the array 
                {
                    int h = n - i; // Number of papers with at least citations[i] citations
                    if (citations[i] >= h) //checks if current citation count is greater than or equal to candidate h-index
                    {
                        return h;
                    }
                }

                return 0;
            }

        }
    }

