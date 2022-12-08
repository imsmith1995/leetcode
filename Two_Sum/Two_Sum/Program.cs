/*
The following is a practice problem from leetcode.com:

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/

//Below is my solution.
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] output = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int countk = i + 1;
            for (int k = countk; k < nums.Length; k++)
            {
                if (nums[i] + nums[k] == target)
                {
                    output[0] = i;
                    output[1] = k;
                    break;
                }
            }
        }
        return output;
    }
}