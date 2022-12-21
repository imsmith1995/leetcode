
int[][] stockPrices = new int[][] {
    new int[]{1, 7 },
    new int[]{2, 6 },
    new int[]{3, 5 },
    new int[]{4, 4 },
    new int[]{5, 4 },
    new int[]{6, 3 },
    new int[]{7, 2 },
    new int[]{8, 1 }
    };

MinimumLines(stockPrices);

int MinimumLines(int[][] stockPrices)
{
    int lines = 0;
    decimal[] slope = new decimal[stockPrices.Length];
    for (int i = 0; i < stockPrices.Length - 1; i++)
    {
        int x1 = stockPrices[i][0];
        int y1 = stockPrices[i][1];
        int x2 = stockPrices[i + 1][0];
        int y2 = stockPrices[i + 1][1];

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