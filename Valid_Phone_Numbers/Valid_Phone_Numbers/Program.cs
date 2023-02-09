/*
Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal 
substring
consisting of non-space characters only.
 */

var s = "    orld";
LengthOfLastWord(s);
int LengthOfLastWord(string s)
{
    var holder = s.ToArray();
    int spaceCounter = 0;
    int spaceChecker = 0;
    int ans = 0;
    foreach(var item in holder)
    {
        if(item is ' ')
        {
            spaceCounter++;
        }
    }
    for(int i = 0; i < holder.Length; i++)
    {
        if( spaceCounter == spaceChecker)
        {
            ans++;
        }
        if (holder[i] is ' ')
        {
            spaceChecker++;
        }
    }

    return ans;
}