/*
Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal 
substring
consisting of non-space characters only.
 */

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var lastWord = s.Length;
        int ans = 0;
        bool foundWord = false;

        for (int i = lastWord - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                foundWord = true;
                ans++;
                continue;
            }
            else if (foundWord)
            {
                break;
            }
        }
        return ans;
    }
}