/*
You are given a 2D integer array stockPrices where 
stockPrices[i] = [dayi, pricei] indicates the price of the stock on day dayi is pricei.
A line chart is created from the array by plotting the points on an XY plane with the X-axis representing
the day and the Y-axis representing the price and connecting adjacent points.
*/

public class Solution
{
    public int MinimumLines(int[][] stockPrices)
    {
        int lines = 1;
        decimal[] slope = new decimal[stockPrices.Length - 1];
        int[][] sortedPrices = stockPrices;
        for (int j = 0; j < sortedPrices.Length - 1; j++)
        {
            int[] holder = new int[2];
            if (sortedPrices[j][0] > sortedPrices[j + 1][0])
            {
                holder = sortedPrices[j + 1];
                sortedPrices[j + 1] = sortedPrices[j];
                sortedPrices[j] = holder;
                j = -1;
            }
        }
        for (int i = 0; i < sortedPrices.Length - 1; i++)
        {
            int x1 = sortedPrices[i][0];
            int y1 = sortedPrices[i][1];
            int x2 = sortedPrices[i + 1][0];
            int y2 = sortedPrices[i + 1][1];

            slope[i] = ((y2 - y1) / (x2 - x1));
        }
        for (int k = 0; k < slope.Length - 1; k++)
        {
            if (slope[k] != slope[k + 1])
            {
                lines++;
            }
        }
        return lines;
    }
}