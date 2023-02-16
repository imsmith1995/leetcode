/*
You are given a large integer represented as an integer array digits, 
where each digits[i] is the ith digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order. 
The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.
 */

int[] digits = new int[3] {8,9,9};
PlusOne(digits);

int[] PlusOne(int[] digits)
{
    int carry = 0;
    digits[digits.Length-1]++;
    for(int i = digits.Length-1; i >= 1; i--)
    {
        if (digits[i] > 9)
        {
            carry++;
            digits[i] = 0;
        }

        digits[i-1] += carry;
        carry = 0;

    }
    int[] ans = new int[digits.Length + 1];
    bool flag = false;
    if (digits[0] > 9)
    {
        flag = true;
        ans[0] = 1;
        ans[1] = 0;
        for(int i = 2; i < ans.Length; i++)
        {
            ans[i] = digits[i-1];
        }
    }
    if(flag is true)
    {
        return ans;
    }
    else
    return digits;
}
