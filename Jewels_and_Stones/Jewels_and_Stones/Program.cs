/*
You're given strings jewels representing the types of stones that are jewels,
and stones representing the stones you have. Each character in stones is a type of stone you have.
You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".
*/
public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var jewelcheck = jewels.ToArray();
        var stonescheck = stones.ToArray();
        int counter = 0;

        foreach (char s in stonescheck)
        {
            foreach (char j in jewelcheck)
            {
                if (j.Equals(s)) counter++;
            }
        }
        return counter;
    }
}