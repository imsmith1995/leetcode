
string s = "aab";
LengthOfLongestSubstring(s);
int LengthOfLongestSubstring(string s)
{
    if (s == null || s == "") { return 0; };
    if (s == " ") { return 1; };

    int ans = 0;
    List<int> substringLengths = new();
    substringLengths.Add(1);
    char[] str = s.ToArray();
    int counter = 0;
    int subLength = 0;

    if(str.Length == 2)
    {
        if (str[0].Equals(str[1]))
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    foreach(char c in str)
    {
        //substringLengths.Add(subLength);
        counter++;
        List<char> compare = new();
        compare.Add(c);
        for (int i = counter; i < str.Length; i++)
        {
            subLength++;
            if (compare.Contains(str[i]))
            {
                substringLengths.Add(subLength);
                subLength = 1; break;
            }
            else
            {
                compare.Add(str[i]);
            }
        }
    }
    ans = substringLengths.Max();

    return ans;
}