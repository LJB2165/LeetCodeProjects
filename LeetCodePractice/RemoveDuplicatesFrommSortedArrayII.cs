using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            // If the array has 2 or fewer elements, return the length as all elements are valid.
            if (nums.Length <= 2)
            {
                return nums.Length;
            }

            // Initialize `j` to 2 because the first two elements are always valid.
            int j = 2;

            // Start iterating from the third element (index 2) to the end of the array.
            for (int i = 2; i < nums.Length; i++)
            {
                // Check if the current element is not equal to the element at position `j-2`.
                // This ensures that we allow up to two occurrences of each element.
                if (nums[i] != nums[j - 2])
                {
                    // If the current element is valid, place it in the `j`-th position
                    // and increment `j`.
                    nums[j] = nums[i];
                    j++;
                }
            }

            // Return the length of the array with duplicates removed according to the problem's requirements.
            return j;
        }
    }
}
