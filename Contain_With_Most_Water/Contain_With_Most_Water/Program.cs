/*
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.
*/

public class Solution { 
    public int MaxArea(int[] height)
    {
        var area = new List<int>();
        for(int i = 0; i < height.Length-1; i++)
        {
            int width = 0;
            for(int k = i+1; k < height.Length; k++)
            {
                width++;
                if (height[i] < height[k])
                {
                    area.Add(height[i] * width);
                }
                else
                {
                    area.Add(height[k] * width);
                }
            }
        }
        int ans = area.Max();
        return ans;
    }
}
