/*
You are given a large integer represented as an integer array digits, 
where each digits[i] is the ith digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order. 
The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.
 */

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        //Defining 'int carry' to use in instances of values greater than 9.
        int carry = 0;
        //Here we are incrimenting the last value of 'digits' by 1.
        digits[digits.Length - 1]++;
        //This loop is identifying if any values are greater than 9 and if so,
        //then that value becomes 0 and 'carry' is set to 1 to pass along that carried value.
        //the last line sets carry back to 0.
        for (int i = digits.Length - 1; i >= 1; i--)
        {
            if (digits[i] > 9)
            {
                carry++;
                digits[i] = 0;
            }

            digits[i - 1] += carry;
            carry = 0;

        }
        //If the first value of 'digits' is great than 9, then the next block of code is used.
        //If 'bool flag' remains false then 'digits' is returned,
        //If 'bool flag' is true then 'ans' is returned.
        int[] ans = new int[digits.Length + 1];
        bool flag = false;
        if (digits[0] > 9)
        {
            flag = true;
            ans[0] = 1;
            ans[1] = 0;
            for (int i = 2; i < ans.Length; i++)
            {
                ans[i] = digits[i - 1];
            }
        }
        if (flag is true)
        {
            return ans;
        }
        else
            return digits;
    }
}