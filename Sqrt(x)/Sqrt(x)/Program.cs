

int x = 4;
MySqrt(x);

int MySqrt(int x)
{
    if (x == 1)
    {
        return x;
    }
    for (double i = 0; i <= x; i++)
    {

        if (i * i > x)
        {
            return Convert.ToInt32(i - 1);
            break;
        }
    }
    return 0;
}