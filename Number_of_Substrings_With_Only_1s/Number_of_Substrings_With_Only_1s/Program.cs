/*
 Given a binary string s, return the number of substrings with all characters 1's.
 Since the answer may be too large, return it modulo 10^9 + 7.

*/
public class Solution
{
    public int NumSub(string s)
    {
        var t = s.ToArray();
        int ans = 0;
        char compare = '1';
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i].Equals(compare))
            {
                int add = NumberUp(t, i, compare);
                ans += add;
                ans++;
            }
        }
        return ans;
    }

    int NumberUp(char[] c, int i, char compare)
    {
        int add = 0;
        for (int k = i; k < c.Length; k++)
        {
            if (k == c.Length - 1)
            {
                break;
            }
            else if (!c[k + 1].Equals(compare))
            {
                break;
            }
            else if (c[k + 1].Equals(compare))
            {
                add++;
                NumberUp(c, k + 1, compare);
            }
        }
        return add;
    }
}