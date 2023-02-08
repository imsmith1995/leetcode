/*
Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
 
*/

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 1)
        {
            return x;
        }
        for (double i = 0; i <= x; i++)
        {

            if (i * i > x)
            {
                return Convert.ToInt32(i - 1);
            }
        }
        return 0;
    }
}