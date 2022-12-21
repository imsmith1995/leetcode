
int[][] stockPrices = new int[][] {
    new int[]{2, 6 },
    new int[]{3, 5 },
    new int[]{1, 7 },
    new int[]{4, 4 },
    new int[]{5, 4 },
    new int[]{6, 3 },
    new int[]{7, 2 },
    new int[]{8, 1 }
    };

MinimumLines(stockPrices);

int MinimumLines(int[][] stockPrices)
{
    int lines = 1;
    decimal[] slope = new decimal[stockPrices.Length-1];
    int[][] sortedPrices = stockPrices;
    for(int j = 0; j < sortedPrices.Length-1; j++)
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
    for (int k = 0; k < slope.Length-1; k++)
    {
        if (slope[k] != slope[k + 1])
        {
            lines++;
        }
    }
    return lines;

}