/*
Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
 */

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var triangle = new List<IList<int>> { new List<int> { 1 } };

        for (int i = 1; i < numRows; i++)
        {
            var level = new List<int> { 1 };
            for (int j = 1; j < i; j++)
            {
                level.Add(triangle[triangle.Count - 1][j - 1] + triangle[triangle.Count - 1][j]);
            }
            level.Add(1);
            triangle.Add(level);
        }
        return triangle;
    }
}