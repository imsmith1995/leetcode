/*
Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

Return the array in the form [x1,y1,x2,y2,...,xn,yn].
*/

public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] ans = new int[nums.Length];
        int half = nums.Length / 2;
        int[] arrX = new int[half];
        int[] arrY = new int[half];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i < (half))
            {
                arrX[i] = nums[i];
            }
            else
                arrY[i - half] = nums[i];
        }
        int q = 0;
        for (int k = 0; k < n; k++)
        {
            ans[q] = arrX[k];
            ans[q + 1] = arrY[k];
            q += 2;
        }
        return ans;
    }
}