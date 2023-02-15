

int[] digits = new int[3] {1,2,3};
PlusOne(digits);

int[] PlusOne(int[] digits)
{
    var total = 0;
    var multiple = 1;
    if(digits.Length > 1)
    {
        for(int i = 1; i< digits.Length; i++)
        {
            multiple = multiple * 10;
        }
    }
    foreach(int digit in digits)
    {
        var deltaMultiple = multiple;
        total += digit * deltaMultiple;
        multiple = multiple / 10;
    }
    total++;
    for(int i = 0; i< digits.Length; i++)
    {

    }
    return new int[2];
}