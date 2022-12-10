//Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

//Return the running sum of nums.
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] ans = new int[nums.Length];
        int counter = 0;
        int adder = 0;
        foreach (int i in nums)
        {
            adder += i;
            ans[counter] = adder;
            counter++;
        }
        return ans;
    }
}