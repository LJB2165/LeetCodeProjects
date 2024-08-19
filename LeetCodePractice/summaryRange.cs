using System;
using System.Collections.Generic;

public class SolutionSummaryRange
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var ranges = new List<string>();
        if (nums.Length == 0)
        {
            return ranges;
        }

        int start = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            // If the current number is not consecutive
            if (nums[i] != nums[i - 1] + 1)
            {
                // Add the range to the list
                if (start == nums[i - 1])
                {
                    ranges.Add(start.ToString());
                }
                else
                {
                    ranges.Add($"{start}->{nums[i - 1]}");
                }
                start = nums[i]; // Start a new range
            }
        }

        // Add the final range
        if (start == nums[nums.Length - 1])
        {
            ranges.Add(start.ToString());
        }
        else
        {
            ranges.Add($"{start}->{nums[nums.Length - 1]}");
        }

        return ranges;
    }
}
