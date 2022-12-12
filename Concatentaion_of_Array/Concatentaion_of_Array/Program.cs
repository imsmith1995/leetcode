/*
Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

Specifically, ans is the concatenation of two nums arrays.

Return the array ans.
*/

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int ansLength = 2 * nums.Length;
        int[] ans = new int[ansLength];
        for (int i = 0; i < ans.Length; i++)
        {
            if (i < nums.Length)
            {
                ans[i] = nums[i];
            }
            else
                ans[i] = nums[i - nums.Length];
        }
        return ans;
    }
}