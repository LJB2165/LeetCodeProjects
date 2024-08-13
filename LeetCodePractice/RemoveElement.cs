using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class RemoveElement
    {
     public int RemoveElements(int[] nums, int val)
            {
                int k = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[k] = nums[i];
                        k++;
                    }
                }
                return k;
            }
        }
    }
    

