namespace LeetCodePractice
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1; // Last element in the non-zero part of nums1
            int p2 = n - 1; // Last element in nums2
            int p = m + n - 1; // Last position in nums1

            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
                p--;
            }

            // If there are remaining elements in nums2, place them in nums1
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p--;
                p2--;
            }
        }
    }
}