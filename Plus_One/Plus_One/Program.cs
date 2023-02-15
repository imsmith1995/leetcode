

int[] digits = new int[3] {1,2,3};
PlusOne(digits);

int[] PlusOne(int[] digits)
{
    var total = 0;
    var multiple = 1;
    int[] ans = new int[3];
    if(digits.Length > 1)
    {
        for(int i = 1; i< digits.Length; i++)
        {
            multiple = multiple * 10;
        }
    }
    var deltaMultiple = multiple;
    foreach(int digit in digits)
    {
        total += digit * deltaMultiple;
        deltaMultiple = deltaMultiple / 10;
    }
    total++;
    var betaMultiple = multiple;
    //issues here. needs addressing
    for(int i = 0; i< digits.Length; i++)
    {
        var primeAns = total;
        ans[i] = primeAns/betaMultiple;

    }
    return new int[2];
}