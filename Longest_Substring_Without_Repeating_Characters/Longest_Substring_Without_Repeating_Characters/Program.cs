
string s = "pwwkew";
LengthOfLongestSubstring(s);
int LengthOfLongestSubstring(string s)
{
    if (s == null || s == "") { return 0; };

    int ans = 0;
    List<int> substringLengths = new();
    char[] str = s.ToArray();
    int counter = 0;
    int subLength = 1;

    foreach(char c in str)
    {
        counter++;
        List<char> compare = new();
        compare.Add(c);
        for (int i = counter; i < str.Length; i++)
        {
            if (compare.Contains(str[i]))
            {
                substringLengths.Add(subLength);
                subLength = 1; break;
            }
            else
            {
                subLength++;
                compare.Add(str[i]);
            }
        }
    }
    ans = substringLengths.Max();

    return ans;
}