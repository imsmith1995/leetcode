//Given a roman numeral, convert it to an integer.

public class Solution
{

    public int RomanToInt(string s)
    {
        int result = 0, temp = 1000;
        foreach (char Rom in s.ToCharArray())
        {
            int tempnum = translate(Rom);

            if (temp >= tempnum) result += tempnum;

            else result -= 2 * temp - tempnum;

            temp = tempnum;
        }
        return result;
    }


    public int translate(char RomNum)
    {
        int result = 0;
        switch (RomNum)
        {
            case 'M': result = 1000; break;
            case 'D': result = 500; break;
            case 'C': result = 100; break;
            case 'L': result = 50; break;
            case 'X': result = 10; break;
            case 'V': result = 5; break;
            case 'I': result = 1; break;
        }
        return result;
    }
}