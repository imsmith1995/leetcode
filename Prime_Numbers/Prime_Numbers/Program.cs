// See https://aka.ms/new-console-template for more information

var start = 2;
var end = 100;

var result = FindPrimeNumbers(start, end);

Console.WriteLine($"Your range of numbers are {start} and {end}.");
foreach (var number in result)
{
    Console.Write($"{number}, ");
}
Console.WriteLine( "are prime numbers.");

List<int> FindPrimeNumbers(int rangeStart, int rangeEnd)
{
    List<int> result = new List<int>();
    for(int i = rangeStart; i <= rangeEnd; i++)
    {
        if( i%2 == 0 )
        {
            result.Add(i);
        }
    }
    return result;
}